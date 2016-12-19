using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 访问者模式01
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Person> persons = new List<Person>();

            Person main1 = new Man();
            main1.Action = "成功";
            persons.Add(main1);

            Person woman1 = new Woman();
            woman1.Action = "成功";
            persons.Add(woman1);

            Person main2 = new Man();
            main2.Action = "失败";
            persons.Add(main2);

            Person woman2 = new Woman();
            woman2.Action = "失败";
            persons.Add(woman2);

            Person main3 = new Man();
            main3.Action = "恋爱";
            persons.Add(main3);

            Person woman3 = new Woman();
            woman3.Action = "恋爱";
            persons.Add(woman3);

            foreach (var item in persons)
            {
                item.GetConclusion();
            }

            Console.Read();
        }
    }
}
