using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 建造者02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //画笔
            var pen = new Pen(Color.Red);

            //画瘦人
            //var thin = new PersonThinBuilder(this.pictureBox1.CreateGraphics(), pen);
            //thin.Build();

            //画胖人
            var fat = new PersonFatBuilder(this.pictureBox2.CreateGraphics(), pen);
            fat.Build();
        }
    }
}
