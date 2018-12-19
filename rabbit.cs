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
using System.Media;

namespace sosil3_homework
{
    class rabbit
    {
        private Point location;
        private PictureBox myrabbit;
        private Label my_speedlabel;
        private Label my_starlabel;
        public int health = 10;
        public int star = 10;
        public int speed = 30;
        public int score = 0;
        public bool over = false;
        SoundPlayer Sound_jump = new SoundPlayer(sosil3_homework.Properties.Resources.Jump);
        SoundPlayer Sound_anger = new SoundPlayer(sosil3_homework.Properties.Resources.anger);
        public rabbit(PictureBox rabbit, Label label_speed, Label label_star)
        {
            location = rabbit.Location;
            myrabbit = rabbit;
            label_star.Text = "Star : " + star.ToString();
            label_speed.Text = "Speed : " + speed.ToString();
            my_starlabel = label_star;
            my_speedlabel = label_speed;
        }

        public void move(KeyEventArgs e, int Width_limit, Form1 form)
        {
            if (e.KeyCode == Keys.NumPad4)
            {
                (new Thread(() =>
                {
                    form.Invoke(new MethodInvoker(delegate ()
                    {
                        location.X = location.X - speed;
                        if (location.X <= 0)
                        {
                            location.X = 1;
                        }
                        myrabbit.SetBounds(location.X, location.Y, myrabbit.Width, myrabbit.Height);
   
                    }));
                })).Start();

            }
            else if (e.KeyCode == Keys.NumPad6)
            {
                (new Thread(() =>
                 {
                     form.Invoke(new MethodInvoker(delegate ()
                     {
                         location.X = location.X + speed;
                         if (location.X >= Width_limit - 60)
                         {
                             location.X = Width_limit - 60;
                         }
                         myrabbit.Location = location;

                     }));

                 })).Start();
              
            }
            else if (e.KeyCode == Keys.NumPad8)
            {
                if (location.Y == 278)
                { 
                    (new Thread(() =>
                    {
                        Sound_jump.Play();
                        double p = location.Y;
                        int i = 0;
                        int dir = -1;
                        while (i < 10)
                        {
                            form.Invoke(new MethodInvoker(delegate ()
                            {
                                if (location.Y == p - 75)
                                    dir = 1;

                                location.Y = location.Y + (dir * 15);
                                myrabbit.Location = new Point(myrabbit.Location.X, location.Y);

                            }));
                            i++;
                            Thread.Sleep(30);
                        }
                    })).Start();
                }
            }
            else if (e.KeyCode == Keys.E)
            {
                if (over != true && star != 0)
                {
                    (new Thread(() =>
                    {
                        star--;
                        Sound_anger.Play();
                        over = true;
                        form.Invoke(new MethodInvoker(delegate ()
                        {
                            myrabbit.Image = sosil3_homework.Properties.Resources.angryrabbit;
                            my_starlabel.Text = "Star : " + star.ToString();
                        }));
                        Thread.Sleep(3000);
                        form.Invoke(new MethodInvoker(delegate ()
                        {
                            myrabbit.Image = sosil3_homework.Properties.Resources.rabbit;
                            over = false;
                        }));
                    })).Start();
                }
            }
            else if(e.KeyCode == Keys.Q)
            {
                speed = speed - 3;
                if (speed <= 1) speed = 0;
                my_speedlabel.Text = "Speed : " + speed.ToString();
            }
            else if (e.KeyCode == Keys.W)
            {
                speed = speed + 3;
                if (speed >= 60) speed = 60;
                my_speedlabel.Text = "Speed : " + speed.ToString();
            }
        }
    }
}
