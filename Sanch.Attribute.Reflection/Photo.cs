using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.Attribute.Reflection
{
    //[Geo(10,20)] // присоединение мето-данных, VS умная и не надо дописывать GeoAttribute , достаточно просто Geo
    //мето данные будут прикреплены к каждому экзампляру класса 
    public class Photo
    {
        [Geo(10, 20)]
        public string Name { get; set; }
        public string Path { get; set; }
        
        public Photo(string name)
        {
            //Проверка
            Name = name;
            //для того что бы присоединить наш атрибут , для того что бы указать дополнительные мето-данные

        }
       
    }
}
