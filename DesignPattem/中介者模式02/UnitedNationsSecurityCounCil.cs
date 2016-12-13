using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 中介者模式02
{
    /// <summary>
    /// 联合国安全理事会
    /// </summary>
    public class UnitedNationsSecurityCounCil : UnitedNations
    {
        private USA colleague1;
        private Iraq colleague2;

        /// <summary>
        /// 美国
        /// </summary>
        public USA Colleague1
        {
            set { colleague1 = value; }
        }
        /// <summary>
        /// 伊拉克
        /// </summary>
        public Iraq Colleague2
        {
            set { colleague2 = value; }
        }

        /// <summary>
        /// 声明
        /// </summary>
        /// <param name="message"></param>
        /// <param name="country"></param>
        public override void Declare(string message, Country country)
        {
            if (country == colleague1)
            {
                colleague2.GetMessage(message);
            }
            else
            {
                colleague1.GetMessage(message);
            }
        }
    }
}
