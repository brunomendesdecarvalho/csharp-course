using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenUm.Entities
{
    class PrintService<T>
    {
        List<T> values = new List<T>();

        public void AddValue(T value)
        {
            values.Add(value);
        }

        public T First()
        {
            if (values.Count == 0)
            {
                throw new Exception("No elements in PrintService.");
            }
            return values[0];
        }

        public void Print()
        {
            Console.Write("[");
            foreach (T value in values)
            {
                if (value.Equals(values[(values.Count - 1)]))
                {
                    Console.Write(value.ToString()
                                     + "]");
                }
                else
                {
                    Console.Write(value.ToString()
                                      + ", ");
                }
            }

            Console.WriteLine("\nFirst: "
                            + values.First().ToString());
        }
    }
}
