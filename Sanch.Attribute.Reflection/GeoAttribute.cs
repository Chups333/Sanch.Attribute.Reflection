using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.Attribute.Reflection
{
    //[AttributeUsage(AttributeTargets.)] для кого доступен наш аттрибут
    class GeoAttribute : System.Attribute//атрибут наследуется от базового класса
    {
        public int X { get; set; }
        public int Y { get; set; }

        public GeoAttribute()
        {
            // конструктор для атрибутов без параметров - задание этих свойств является не обязательным
        }

        public GeoAttribute(int x, int y)
        {
            //Проверять входные данные

            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"[{X};{Y}]";
        }
    }
}
