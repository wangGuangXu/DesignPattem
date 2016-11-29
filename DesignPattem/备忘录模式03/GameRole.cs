using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 备忘录模式03
{
    /// <summary>
    /// 游戏角色
    /// </summary>
    public class GameRole
    {
        private int vit;
        private int atk;
        private int def;

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

        /// <summary>
        /// 状态显示
        /// </summary>
        public void StateDisplay()
        {
            Console.WriteLine("角色当前状态： ");
            Console.WriteLine("体力{0}", this.vit);
            Console.WriteLine("攻击力{0}", this.atk);
            Console.WriteLine("防御力{0}", this.def);

            Console.WriteLine("");
        }

        /// <summary>
        /// 保存角色状态
        /// </summary>
        /// <returns></returns>
        public RoleStateMemento SaveState()
        {
            return (new RoleStateMemento(vit, atk, def));
        }

        /// <summary>
        /// 恢复角色状态
        /// </summary>
        /// <param name="memento"></param>
        public void RecoveryState(RoleStateMemento memento)
        {
            this.vit = memento.Vitality;
            this.atk = memento.Attack;
            this.def = memento.Defense;

        }
    }
}
