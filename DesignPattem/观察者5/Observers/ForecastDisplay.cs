using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者5
{
    /// <summary>
    /// 预测布告板
    /// </summary>
    public class ForecastDisplay : IObserver, IDisplayElement
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

        public ForecastDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;

            //将对象自己做为观察者注册到主题上
            weatherData.RegisterObserver(this);
        }


        public void Display()
        {
            Console.WriteLine("预测布告板: 温度：{0}度、湿度：{1}%、气压：{2}", temperature, humidity, pressure);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            Display();
        }
    }
}
