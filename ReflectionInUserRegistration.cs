using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace UserRegistrationValidator
{
    class ReflectionInUserRegistration
    {
        public static void Reflection()
        {
            Type type = Type.GetType("UserRegistrationValidator.Pattern");
            Console.WriteLine("NameSpace name : {0}",type.FullName);
            Console.WriteLine("Class Name is : {0}",type.Name);
            Console.WriteLine("Methods in pattern class ");
            MethodInfo[] methods = type.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name+" "+method.Name);
            }
            Console.WriteLine("Properties in pattern class ");
            PropertyInfo[] properties = type.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name+" "+property.Name);
            }
            Console.WriteLine("Constructors in pattern class ");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach(ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}
