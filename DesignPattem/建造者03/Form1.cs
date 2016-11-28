using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 建造者03
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
            PersonDirector director;

            //画瘦人
            director = new PersonDirector(new PersonThinBuilder(pictureBox1.CreateGraphics(), pen));
            director.CreatePerson();

            //画胖人
            director = new PersonDirector(new PersonFatBuilder(pictureBox2.CreateGraphics(), pen));
            director.CreatePerson();
        }
    }
}
