using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 建造者01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //在窗体中必须添加重绘事件否则绘制的效果出不来
            this.Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                //DrawTheVillain();
                DrawFatVillain();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 瘦人
        /// </summary>
        void DrawTheVillain()
        {
            Pen pen = new Pen(Color.Yellow);

            //创建画布
            Graphics gThin = pictureBox1.CreateGraphics();

            gThin.DrawEllipse(pen, 50, 20, 30, 30);//头

            gThin.DrawRectangle(pen, 60, 50, 10, 50);//身体

            gThin.DrawLine(pen, 60, 50, 40, 100);//左手
            gThin.DrawLine(pen, 70, 50, 90, 100);//右手

            gThin.DrawLine(pen, 60, 100, 45, 150);//左脚
            gThin.DrawLine(pen, 70, 100, 85, 150);//右脚

        }

        /// <summary>
        /// 胖人
        /// </summary>
        void DrawFatVillain()
        {
            Pen pen = new Pen(Color.Green);

            Graphics gFat = pictureBox2.CreateGraphics();

            gFat.DrawEllipse(pen,50,20,30,30);                //头

            gFat.DrawRectangle(pen, 45, 50, 40, 50);        //身体

            gFat.DrawLine(pen, 50, 50, 30, 100);            //左手
            gFat.DrawLine(pen, 80, 50, 100, 100);           //右手

            gFat.DrawLine(pen, 60, 100, 45, 150);           //左脚
            gFat.DrawLine(pen, 70, 100, 85, 150);           //右脚
        }

    }
}
