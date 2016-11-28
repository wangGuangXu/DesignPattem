using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace 建造者02
{
    /// <summary>
    /// 瘦人生成器
    /// </summary>
    public class PersonThinBuilder
    {
        private Graphics graphics;
        private Pen pen;

        /// <summary>
        /// 初始化时确定画板和颜色
        /// </summary>
        /// <param name="graphics">画板</param>
        /// <param name="pen">画笔</param>
        public PersonThinBuilder(Graphics graphics, Pen pen)
        {
            this.graphics = graphics;
            this.pen = pen;
        }

        /// <summary>
        /// 开始绘制瘦人
        /// </summary>
        public void Build()
        {
            graphics.DrawEllipse(pen, 50, 20, 30, 30);//头

            graphics.DrawRectangle(pen, 60, 50, 10, 50);//身体

            graphics.DrawLine(pen, 60, 50, 40, 100);//左手
            graphics.DrawLine(pen, 70, 50, 90, 100);//右手

            graphics.DrawLine(pen, 60, 100, 45, 150);//左脚
            graphics.DrawLine(pen, 70, 100, 85, 150);//右脚
        }

    }
}
