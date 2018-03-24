using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者5
{
    /// <summary>
    /// 目前状况布告版
    /// </summary>
    public class CurrentConditionsDisplay : IObserver,IDisplayElement
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
        /// 主题
        /// </summary>
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            //将自己做为观察者注册到主题上
            weatherData.RegisterObserver(this);
        }

        /// <summary>
        /// 目前状况布告版显示数据
        /// </summary>
        public void Display()
        {
            Console.WriteLine("目前状况布告板: 温度：{0}度、湿度：{1}%。",temperature,humidity);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;

            Display();
        }
    }
}
