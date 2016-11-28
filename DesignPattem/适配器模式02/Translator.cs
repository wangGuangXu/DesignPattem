using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 适配器模式02
{
    /// <summary>
    /// 翻译者
    /// </summary>
    public class Translator : Player
    {
        //声明并实例化一个内部外籍中锋对象，表示翻译者于外籍球员有关联
        private ForeignCenter wjzf = new ForeignCenter();

        public Translator(string name)
            : base(name)
        {
            wjzf.Name = name;
        }

        public override void Attack()
        {
            wjzf.进攻();
        }

        public override void Defense()
        {
            wjzf.防守();
        }
    }
}
