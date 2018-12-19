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
    class itemManager
    {
        private Thread MakeItem;
        public itemManager(Form1 Form1, PictureBox background, PictureBox Cloud, PictureBox prabbit, rabbit rabbit, List<item> itemList, Label label_health, Label label_Star, Label label_score, Label label_level)
        {
            MakeItem = new Thread(delegate()
                {
                    makeitem(Form1, background, Cloud, prabbit, rabbit, itemList, label_health, label_Star, label_score, label_level);
                });
            MakeItem.Start();
        }
        private void makeitem(Form1 Form1, PictureBox background, PictureBox Cloud, PictureBox prabbit, rabbit rabbit, List<item> itemList, Label label_health, Label label_Star, Label label_score, Label label_level)
        {
            int a = 1200;
            Thread.Sleep(3000);
            while(rabbit.health > 0)
            {
                if(a > 500) a = 2000 - (rabbit.score/100) * 300;
                if (a < 500) a = 500;
                itemList.Add(new item(Form1, background, Cloud, prabbit, rabbit, label_health, label_Star, label_score, label_level));
                for(int i = itemList.Count - 1; i >= 0; i--)
                {
                    if(itemList[i].state == false)
                    itemList.RemoveAt(i);
                }
                Thread.Sleep(a);
            }
        }
    }
}
