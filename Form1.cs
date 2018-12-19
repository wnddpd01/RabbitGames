using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Timers;

namespace sosil3_homework
{
    public partial class Form1 : Form
    {
        SoundPlayer Sound_Message = new SoundPlayer(sosil3_homework.Properties.Resources.Message);
        SoundPlayer Sound_Start = new SoundPlayer(sosil3_homework.Properties.Resources.start);
        rabbit my_rabbit;
        cloud my_cloud;
        itemManager my_itemManager;
        Task cloud;
        int s = 4;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        List<item> itemList = new List<item>();
        int[] i_scores = new int[6];

        public Form1()
        {
            InitializeComponent();
            this.Focus();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox_background;
            label1.BackColor = Color.Transparent;
            label1.Visible = false;
            groupBox1.Visible = false;
            btn_Start_fake.Visible = false;
            my_rabbit = new rabbit(pictureBox_nomal_rabbit, label_Speed, label_Star);

            string[] scores = new string[5];
            if (File.Exists(@"./rank.txt") == false)
            {
                FileStream a = File.Create(@"./rank.txt");
                a.Close();

                StreamWriter sw = new StreamWriter(@"./rank.txt");
                for (int i = 0; i < 5; i++)
                {
                    sw.WriteLine(0.ToString());
                }
                sw.Close();
            }

            StreamReader sr = new StreamReader(@"./rank.txt");
            for (int i = 0; i < 5; i++)
            {
                scores[i] = sr.ReadLine();
            }
            sr.Close();
            for (int i = 0; i < 5; i++)
                i_scores[i] = Int32.Parse(scores[i]);
            Array.Sort(i_scores);
            Array.Reverse(i_scores);

            pictureBox_cloud.Visible = false;
            pictureBox_nomal_rabbit.Visible = false;
            this.Focus();
            this.Show();
            this.SetTopLevel(true);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            my_rabbit.move(e, pictureBox_background.Width, this);
        }
        private void Cloud_move()
        {
            int speed = 100;
            cloud.Wait(100);
            bool p = true;
            Random r = new Random();
            int move_range;
            while (true)
            {
                move_range = r.Next(20, 150);
                for (int i = 0; i < move_range; i++)
                {
                    if (pictureBox_cloud.Location.X <= 2)
                    {
                        p = true;
                    }
                    else if (pictureBox_cloud.Location.X >= pictureBox_background.Width - pictureBox_cloud.Width - 2)
                        p = false;
                    try
                    {
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            IntPtr x;
                            if (!pictureBox_cloud.IsHandleCreated)
                                x = pictureBox_cloud.Handle;
                            pictureBox_cloud.Location = my_cloud.move(p, my_rabbit.score);
                        }));
                        speed = 100 - ((my_rabbit.score / 100) * 20);
                        if (speed < 50) speed = 50;

                        cloud.Wait(speed);
                    }
                    catch (Exception e) { }
                }
                p = !p;
            }
        }


        private void btn_Manual_Click(object sender, EventArgs e)
        {
            Sound_Message.Play();
            MessageBox.Show("NumPad 4 : 왼쪽으로 움직이기\n" + "NumPad 6 : 오른쪽으로 움직이기\n" + "NumPad 8 : 점프\n" + "E : Star 1개 사용하여 무적 3초\n" + "Q : 속도 줄이기\n" + "W : 속도 올리기\n"
                + "하트를 먹으면 Health 증가\n" + "별을 먹으면 Star 증가\n" + "폭탄을 먹으면 Health 감소\n");
        }

        void timer_elapsed(object e, EventArgs a)
        {
            s--;
            label1.Text = s.ToString();
            label1.Visible = true;
            label1.Invalidate(true);
            if (s == 0)
            {
                label1.Dispose();
                timer.Dispose();
                groupBox1.Visible = true;
                btn_Start_fake.Visible = true;
                btn_Start.Visible = false;
                pictureBox_cloud.Visible = true;
                pictureBox_nomal_rabbit.Visible = true;
                pictureBox_nomal_rabbit.Enabled = false;
                groupBox1.Parent = pictureBox_left;

                pictureBox_nomal_rabbit.BackColor = Color.Transparent;
                pictureBox_nomal_rabbit.Parent = pictureBox_background;

                pictureBox_cloud.BackColor = Color.Transparent;
                pictureBox_cloud.Parent = pictureBox_background;

                my_cloud = new cloud(pictureBox_cloud.Location);
                my_itemManager = new itemManager(this, pictureBox_background, pictureBox_cloud, pictureBox_nomal_rabbit, my_rabbit, itemList, label_health, label_Star, label_Score, label_Level);

                cloud = new Task(new Action(Cloud_move));
                cloud.Start();

                label_health.Text = "Health : " + my_rabbit.health.ToString();
                label_Score.Text = "Score : " + my_rabbit.score.ToString();
                label_Level.Text = "Level : " + (my_rabbit.score + 1).ToString();
                this.DoubleBuffered = true;
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Tahoma", 30, FontStyle.Italic);
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_elapsed);
            timer.Start();
            Sound_Start.Play();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_highScore_Click(object sender, EventArgs e)
        {
            Sound_Message.Play();
            for (int i = 0; i < 5; i++)
                Array.Sort(i_scores);
            Array.Reverse(i_scores);
            MessageBox.Show("1 등 : " + i_scores[0].ToString() + "\n" + "2 등 : " + i_scores[1].ToString() + "\n" + "3 등 : " + i_scores[2].ToString() + "\n"
                + "4 등 : " + i_scores[3].ToString() + "\n" + "5 등 : " + i_scores[4].ToString() + "\n");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            i_scores[5] = my_rabbit.score;
            Array.Sort(i_scores);
            Array.Reverse(i_scores);
            StreamWriter sw = new StreamWriter(@"./rank.txt");
            for (int i = 0; i < 5; i++)
            {
                sw.WriteLine(i_scores[i].ToString());
            }
            sw.Close();
        }
    }
}
