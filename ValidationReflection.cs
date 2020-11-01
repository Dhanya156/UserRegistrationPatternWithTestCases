using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace UserRegistrationPattern
{
    class ValidationReflection
    {
        public static void ServiceInfo()
        {
            Type type = Type.GetType("UserRegistrationPattern.ServiceInfo");

            Console.WriteLine("full Name:{0}", type.FullName);

            Console.WriteLine("class Name:{0}", type.Name);

            Console.WriteLine("Methods in customer class");

            MethodInfo[] methods = type.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + "" + method.Name);
            }

            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties )
            {
                Console.WriteLine(property.PropertyType.Name + "" + property.Name);
            }
        }
    }
}
