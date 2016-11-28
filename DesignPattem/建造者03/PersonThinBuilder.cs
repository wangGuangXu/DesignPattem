using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace 建造者03
{
    /// <summary>
    /// 瘦人生成器
    /// </summary>
    public class PersonThinBuilder:PersonBuilder
    {
        /// <summary>
        /// 初始化时确定画板和颜色
        /// </summary>
        /// <param name="graphics">画板</param>
        /// <param name="pen">画笔</param>
        public PersonThinBuilder(Graphics graphics, Pen pen):base   (graphics,pen)
        {
            
        }

        public override void BuilderHead()
        {
            graphics.DrawEllipse(pen, 50, 20, 30, 30);//头
        }

        public override void BuilderBody()
        {
            graphics.DrawRectangle(pen, 60, 50, 10, 50);//身体
        }

        public override void BuilderArmLeft()
        {
            graphics.DrawLine(pen, 60, 50, 40, 100);//左手
        }

        public override void BuilderArmRight()
        {
            graphics.DrawLine(pen, 70, 50, 90, 100);//右手
        }

        public override void BuilderLegLeft()
        {
            graphics.DrawLine(pen, 60, 100, 45, 150);//左脚
        }

        public override void BuilderLegRight()
        {
            graphics.DrawLine(pen, 70, 100, 85, 150);//右脚
        }
    }
}
