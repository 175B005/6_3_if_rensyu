using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_3_if_rensyu
{
    public partial class Form1 : Form
    {
        int vx = 10,vy = 10;
       // int a = 0;
       // int hoge = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vx = -vx;
            vy = -vy;
           

            //a++;
            //button1.Text = ("" + a + "回");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button1.Left <=0){
                vx = -vx;
            }//form参照Client.button1→ボタン参照,幅Width高さHeigth
            else if (button1.Left >= ClientSize.Width - 80)
            {
                vx = -vx;
                
            }
            if (button1.Top <= 0)
            {
                vy = - vy;
            }
            else if (button1.Top >= ClientSize.Height - 60)
            {
                vy = -vy;
            }
            button1.Left = button1.Left + vx;
            button1.Top = button1.Top + vy;
            /*       if (vx > 0)
                   {
                       hoge = 1;
                   }
                   else
                       hoge = 2;
                   if (vy > 0)
                   {
                       hoge = 3;
                   }
                   else
                   {
                       hoge = 4;
                   }
                   switch (hoge)
                   {
                       case 1:
                           button1.Text = ("右");
                           break;
                       case 2:
                           button1.Text = ("左");
                           break;
                       case 3:
                           button1.Text = ("上");
                           break;
                       case 4:
                           button1.Text = ("下");
                           break;
                   }
                   */
        }
    }
}
