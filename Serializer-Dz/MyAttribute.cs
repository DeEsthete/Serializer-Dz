using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializer_Dz
{
    [Serializable]
    public class MyAttribute : Attribute
    {
        public string Text { get; set; }

        public MyAttribute(string text)
        {
            Text = text;
        }
        public MyAttribute()
        {
            //
        }
    }
}
