using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Tamaguchi.UI.Screens
{
    class ObjectView : Screen
    {
        private Object obj;
        public ObjectView(string title, Object obj) : base(title)
        {
            this.obj = obj;
        }


        public override void Show()
        {
            //Display title
            Console.WriteLine($"{Title}".PadLeft(10));
            //Get the type of the object!
            Type t = obj.GetType();
            // Get the public properties of the instance (not only related to Object).
            PropertyInfo[] propInfos = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            // Display information for all properties.
            foreach (PropertyInfo propInfo in propInfos)
            {
                bool readable = propInfo.CanRead;
                bool writable = propInfo.CanWrite;

                if (readable)
                {
                    Object prop = propInfo.GetValue(obj);
                    //Do not display lists, arrays, classes, etc...
                    if (prop != null)
                    {
                        if (!(prop.GetType().IsClass && !prop.GetType().Equals(typeof(string))))
                            Console.WriteLine("\t{0}: {1}".PadLeft(5), propInfo.Name, propInfo.GetValue(obj));
                    }
                    else
                    {
                        Console.WriteLine("\t{0}: {1}".PadLeft(5), propInfo.Name, "------");
                    }
                }
            }
        }
    }
}
