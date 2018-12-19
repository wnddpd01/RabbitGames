using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sosil3_homework
{
    class item
    {
        public bool state;
        public int type = 0;
        Point location;
        public PictureBox my_item;
        public Task T_move;
        public rabbit myrabbit;
        public Label health_label;
        public Label Star_label;
        public Label Score_label;
        public Label Level_label;
        public Form1 Form1;
        public PictureBox pic_rabbit;
        public item(Form1 Form1, PictureBox parent, PictureBox Cloud,PictureBox pictureboxrabbit, rabbit rabbit, Label healtlabel, Label label_Star, Label label_score, Label label_level)
        {
            pic_rabbit = pictureboxrabbit;
            Bitmap my_image = getMyImage(rabbit.score);
            state = true;
            location = Cloud.Location;
            location.X = location.X + 35;
            location.Y = location.Y + 50;
            my_item = new PictureBox();
            try
            {
                Form1.Invoke(new MethodInvoker(delegate ()
                {
                    health_label = healtlabel;
                    Star_label = label_Star;
                    Score_label = label_score;
                    Level_label = label_level;
                    IntPtr x;
                    if (!my_item.IsHandleCreated)
                        x = my_item.Handle;
                    my_item.Parent = parent;
                    my_item.BackColor = Color.Transparent;
                    my_item.Name = "item";
                    my_item.Size = new Size(30, 30);
                    my_item.Location = location;
                    my_item.Image = my_image;
                    my_item.Visible = true;
                    my_item.SizeMode = PictureBoxSizeMode.StretchImage;
                }));
                this.myrabbit = rabbit;
                this.Form1 = Form1;
                T_move = new Task(new Action(move));
                T_move.Start();
            }
            catch (Exception e) { }
        }
        public Rectangle getMyBound()
        {
            return my_item.Bounds;
        }
        private Bitmap getMyImage(int score)
        {
            Random r = new Random((int)DateTime.Now.Ticks);
            int i = r.Next(0, 13 + (score / 300));
            switch (i)
            {
                case 0:
                    return sosil3_homework.Properties.Resources.f_carrot;
                case 1:
                    return sosil3_homework.Properties.Resources.f_apple;
                case 2:
                    type = 2;
                    return sosil3_homework.Properties.Resources.f_bomb;
                case 3:
                    return sosil3_homework.Properties.Resources.f_cherry;
                case 4:
                    return sosil3_homework.Properties.Resources.f_grapes;
                case 5:
                    type = 1;
                    return sosil3_homework.Properties.Resources.f_heart;
                case 6:
                    return sosil3_homework.Properties.Resources.f_kiwi;
                case 7:
                    return sosil3_homework.Properties.Resources.f_orange;
                case 8:
                    return sosil3_homework.Properties.Resources.f_pear;
                case 9:
                    return sosil3_homework.Properties.Resources.f_pineapple;
                case 10:
                    type = 3;
                    return sosil3_homework.Properties.Resources.f_star;
                case 11:
                    return sosil3_homework.Properties.Resources.f_strawberry;
                case 12:
                    return sosil3_homework.Properties.Resources.f_watermelon;
            }
            type = 2;
            return sosil3_homework.Properties.Resources.f_bomb;
        }

        public void move()
        {
            int a = 1;
            try
            {
                while (state == true)
                {
                    my_item.Invoke(new MethodInvoker(delegate ()
                            {

                                if (location.Y > 375)
                                {
                                    if (type == 0 && myrabbit.over == false)
                                    {
                                        myrabbit.health--;
                                        if (myrabbit.health < 1)
                                        {
                                            Application.Restart();
                                        }
                                        health_label.Text = "Health : " + myrabbit.health.ToString();
                                    }
                                    state = false;
                                    if (my_item.IsDisposed == false)
                                    {
                                        my_item.Dispose();
        
                                    }
                                }
                                else
                                {
                                    for (int i = 0; i < 2 + a / 5; i++)
                                    {
                                        location.Y += 3;
                                        my_item.SetBounds(location.X, location.Y, my_item.Width, my_item.Height);
                                    }
                                    if (pic_rabbit.Bounds.IntersectsWith(getMyBound()))
                                    {
                                        if (type == 1) myrabbit.health++;
                                        else if (type == 2 && myrabbit.over == false)
                                        {
                                            myrabbit.health--;
                                            if (myrabbit.health < 1)
                                            {
                                                Application.Restart();
                                            }
                                        }
                                        else if (type == 3) myrabbit.star++;
                                        else myrabbit.score = myrabbit.score + 10;
                                        health_label.Text = "Health : " + myrabbit.health.ToString();
                                        Score_label.Text = "Score : " + myrabbit.score.ToString();
                                        Star_label.Text = "Star : " + myrabbit.star.ToString();
                                        Level_label.Text = "Level : " + (myrabbit.score/100 + 1).ToString();
                                        state = false;
                                        my_item.Dispose();
                                    }
                                }
                                a++;
                            }));
                    /*if (a > 20) a = a - 10;
                    else a = 10;*/
                    T_move.Wait(30);
                }
            }
            catch (InvalidOperationException e)
            { }
        }

    }
}
