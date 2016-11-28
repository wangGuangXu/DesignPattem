using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace 建造者03
{
    /// <summary>
    /// 胖人
    /// </summary>
    public class PersonFatBuilder:PersonBuilder
    {
        public PersonFatBuilder(Graphics graphics, Pen pen) : base(graphics, pen)
        {

        }

        public override void BuilderHead()
        {
            graphics.DrawEllipse(pen, 50, 20, 30, 30);          //头
        }

        public override void BuilderBody()
        {
            graphics.DrawRectangle(pen, 45, 50, 40, 50);        //身体
        }

        public override void BuilderArmLeft()
        {
            graphics.DrawLine(pen, 50, 50, 30, 100);            //左手
        }

        public override void BuilderArmRight()
        {
            graphics.DrawLine(pen, 80, 50, 100, 100);           //右手
        }

        public override void BuilderLegLeft()
        {
            graphics.DrawLine(pen, 60, 100, 45, 150);           //左脚
        }

        public override void BuilderLegRight()
        {
            graphics.DrawLine(pen, 70, 100, 85, 150);           //右脚
        }

    }
}
