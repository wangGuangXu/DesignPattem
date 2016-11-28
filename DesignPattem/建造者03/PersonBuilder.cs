using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace 建造者03
{
    /// <summary>
    /// 人---建造抽象类
    /// 将建造过程中的步骤进行拆分
    /// </summary>
    public abstract class PersonBuilder
    {
        /// <summary>
        /// 画布
        /// </summary>
        protected Graphics graphics;
        /// <summary>
        /// 画笔
        /// </summary>
        protected Pen pen;

        public PersonBuilder(Graphics graphics, Pen pen)
        {
            this.graphics = graphics;
            this.pen = pen;
        }

        /// <summary>
        /// 头
        /// </summary>
        public abstract void BuilderHead();
        /// <summary>
        /// 身体
        /// </summary>
        public abstract void BuilderBody();
        /// <summary>
        /// 左手
        /// </summary>
        public abstract void BuilderArmLeft();
        /// <summary>
        /// 右手
        /// </summary>
        public abstract void BuilderArmRight();
        /// <summary>
        /// 左脚
        /// </summary>
        public abstract void BuilderLegLeft();
        /// <summary>
        /// 右脚
        /// </summary>
        public abstract void BuilderLegRight();
    }
}
