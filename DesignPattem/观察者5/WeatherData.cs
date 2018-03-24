using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者5
{
    /// <summary>
    /// 气象数据
    /// </summary>
    public class WeatherData : ISubject
    {
        /// <summary>
        /// 观察者列表
        /// </summary>
        private List<IObserver> observers;
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
        /// 气象数据
        /// </summary>
        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        /// <summary>
        /// 通知观察者列表
        /// </summary>
        public void NotifyObservers()
        {
            if (observers==null || observers.Count<1)
            {
                return;
            }

            foreach (var observer in observers)
            {
                observer.Update(temperature,humidity,pressure);
            }
        }
        
        /// <summary>
        /// 注册观察者
        /// </summary>
        /// <param name="o"></param>
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        /// <summary>
        /// 移除观察者
        /// </summary>
        /// <param name="o"></param>
        public void RemoveObserver(IObserver o)
        {
            if (observers==null || observers.Count<1)
            {
                return;
            }
            observers.Remove(o);
        }

        /// <summary>
        /// 气象站数据变化时及时通知观察者
        /// </summary>
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        /// <summary>
        /// 设置气象参数
        /// </summary>
        /// <param name="temperature"></param>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        public void SetMeasurements(float temperature,float humidity,float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            MeasurementsChanged();
        }
    }
}
