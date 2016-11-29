using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 备忘录模式03
{
    /// <summary>
    /// 角色状态(存储箱)备忘录
    /// </summary>
    public class RoleStateMemento
    {
        private int vit;
        private int atk;
        private int def;

        /// <summary>
        /// 将生命力、攻击力、防御力等状态存入状态存储箱(备忘录)中
        /// </summary>
        /// <param name="vit"></param>
        /// <param name="atk"></param>
        /// <param name="def"></param>
        public RoleStateMemento(int vit, int atk, int def)
        {
            this.vit = vit;
            this.atk = atk;
            this.def = def;
        }

        /// <summary>
        /// 生命力
        /// </summary>
        public int Vitality
        {
            get { return vit; }
            set { vit = value; }
        }

        /// <summary>
        /// 攻击力
        /// </summary>
        public int Attack
        {
            get { return atk; }
            set { atk = value; }
        }

        /// <summary>
        /// 防御力
        /// </summary>
        public int Defense
        {
            get { return def; }
            set { def = value; }
        }
    }
}
