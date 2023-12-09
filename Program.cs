using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module15_dz_zd2
{
    class MyClass
    {
        public int MyProperty1 { get; set; }
        public string MyProperty2 { get; set; }
    }

    class Program
    {
        static void Main()
        {
            MyClass myObject = new MyClass
            {
                MyProperty1 = 42,
                MyProperty2 = "Salamualeykum, Reflection!"
            };

            Type objectType = myObject.GetType();
            var properties = objectType.GetProperties();

            Console.WriteLine("Свойства и их значения:");
            foreach (var property in properties)
            {
                object value = property.GetValue(myObject);
                Console.WriteLine($"{property.Name}: {value}");
            }
        }
    }
}
