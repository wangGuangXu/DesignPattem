using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者5.Observers
{
    /// <summary>
    /// 酷热指数布告板
    /// </summary>
    public class HeatIndex : IObserver, IDisplayElement
    {
        /// <summary>
        /// 温度
        /// </summary>
        private float temperature;
        /// <summary>
        /// 湿度
        /// </summary>
        private float humidity;
        /// <summary>
        /// 压力
        /// </summary>
        private float pressure;
        /// <summary>
        /// 主题
        /// </summary>
        private ISubject weatherData;

        public HeatIndex(ISubject weatherData)
        {
            this.weatherData = weatherData;

            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public void Update(float temp, float humidity, float pressure)
        {
            throw new NotImplementedException();
        }
    }
}
