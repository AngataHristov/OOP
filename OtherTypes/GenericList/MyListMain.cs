
namespace GenericList
{
    using System;
    using System.Reflection;
    using System.Linq;

    public class MyListMain
    {
        public static void Main()
        {
            var list = new MyGenericList<int>();

            list.Add(1);
            list.Add(4);
            list.Add(7);
            list.Add(5);

            //list.Incert(9, 1);

            // for (int i = 0; i < list.Count; i++)
            // {
            //     Console.WriteLine(list[i]);
            // }

            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());

            Console.WriteLine(list);

            Type type = typeof(MyGenericList<object>);
            var allAttributes = type.GetCustomAttributes(false);

            var otherList = allAttributes.Where(a => a is VersionAttribute).ToList();

            foreach (var attribute in otherList)
            {                
                    Console.WriteLine(attribute.ToString());               
            }
        }
    }
}
