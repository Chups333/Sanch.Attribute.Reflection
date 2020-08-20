using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.Attribute.Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //атрибус очередной вспомогательный класс 
            var photo = new Photo("hello.png")
            {
                Path = @"C:\hello.png"
            };

            var type = typeof(Photo); // тип - контейнер для хранения информации о классе ( типа класса ) - получаем описания типа класса
            var attribute = type.GetCustomAttributes(false);// получаем наши собственные аттрибуты - аттрибуты представлены массивом
            foreach (var item in attribute)
            {
                Console.WriteLine(item); // вывели класс отмеченный этим аттрибутом
            }

            var properties = type.GetProperties(); // получаем свойства - получаем поллекцию всех свойств класса
            foreach (var item1 in properties)
            {
                ///// Получаем определенное свойство \\\\\\\\\\\\\\\\\\\\\\
                var attributes = item1.GetCustomAttributes(false);

                var propsWithGeoAttr = attributes.Any(a => a.GetType() == typeof(GeoAttribute));
                if (propsWithGeoAttr)
                {
                    Console.WriteLine(item1.PropertyType + " " + item1.Name); // вывели свойство которое отмеченно этим аттрибутом
                }

               ////////// Где получаем все свойства \\\\\\\\\\\\\\\\\\\\\\\
                /*Console.WriteLine(item1.PropertyType + " " + item1.Name); // Можем получить тип свойства
                var attributes = item1.GetCustomAttributes(false);
                foreach ( var item11 in attributes)
                {
                    Console.WriteLine(item11);
                }*/
            }

            Console.ReadKey();
        }
    }
}
