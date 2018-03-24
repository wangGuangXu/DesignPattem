using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者5
{
    /// <summary>
    /// 统计布告板
    /// </summary>
    public class StatisticsDisplay:IObserver,IDisplayElement
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
        /// 气压
        /// </summary>
        private float pressure;
        /// <summary>
        /// 主题
        /// </summary>
        private ISubject weatherData;

        /// <summary>
        /// 统计布告版
        /// </summary>
        /// <param name="weatherData"></param>
        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;

            weatherData.RegisterObserver(this);
        }

        /// <summary>
        /// 显示统计布告板
        /// </summary>
        public void Display()
        {
            Console.WriteLine("统计布告板: 温度：{0}度、湿度：{1}%、气压：{2}", temperature, humidity, pressure);
        }

        /// <summary>
        /// 更新气象数据
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            Display();
        }
    }
}
