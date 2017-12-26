using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializer_Dz
{
    [Serializable]
    [My("Атрибут успешно использован!")]
    public class Book : MyAttribute
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public string GetMessage()
        {
            var type = this.GetType(); // получение описания типа
            if (Attribute.IsDefined(type, typeof(MyAttribute))) // проверка на существование атрибута
            {
                var attributeValue = Attribute.GetCustomAttribute(type, typeof(MyAttribute)) as MyAttribute; // получаем значение атрибута
                Console.WriteLine("Атрибут успешно использован!");
                return Text;
            }
            return Text;
        }
    }
}
