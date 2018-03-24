using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者5
{
    /// <summary>
    /// 观察者接口
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="temp">温度</param>
        /// <param name="humidity">湿度</param>
        /// <param name="pressure">压力</param>
        void Update(float temp,float humidity,float pressure);
    }
}
