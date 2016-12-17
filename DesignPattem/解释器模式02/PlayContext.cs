using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 解释器模式02
{
    /// <summary>
    /// 播放内容
    /// </summary>
    public class PlayContext
    {
        private string playText;
        /// <summary>
        /// 播放
        /// </summary>
        public string PlayText
        {
            set { playText = value; }
            get { return playText; }
        }
    }
}
