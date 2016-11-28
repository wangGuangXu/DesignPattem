using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 备忘录模式01
{
    /// <summary>
    /// 游戏角色类
    /// </summary>
    public class GameRole
    {
        /// <summary>
        /// 生命力
        /// </summary>
        private int vit;
        public int Vitality
        {
            get { return vit; }
            set { vit = value; }
        }

        /// <summary>
        /// 攻击力
        /// </summary>
        private int atk;
        public int Attack
        {
            get { return atk; }
            set { atk = value; }
        }

        /// <summary>
        /// 防御力
        /// </summary>
        private int def;
        public int Defense
        {
            get { return def; }
            set { def = value; }
        }

        /// <summary>
        /// 状态显示
        /// </summary>
        public void StateDisplay()
        {
            Console.WriteLine("角色当前状态： ");
            Console.WriteLine("体力{0}",this.vit);
            Console.WriteLine("攻击力{0}",this.atk);
            Console.WriteLine("防御力{0}",this.def);

            Console.WriteLine("");
        }

        /// <summary>
        /// 获得初始状态
        /// </summary>
        public void GetInitState()
        {
            this.vit = 100;
            this.atk = 100;
            this.def = 100;
        }

        /// <summary>
        /// 战斗
        /// </summary>
        public void Fight()
        {
            this.vit = 0;
            this.atk = 0;
            this.def = 0;
        }

    }
}
