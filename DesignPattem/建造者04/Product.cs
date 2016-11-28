using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 建造者04
{
    public class Product
    {
        IList<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine(string.Format("\n产品"));
            foreach (var item in parts)
            {
                Console.WriteLine(item);
            }
        }

    }
}
