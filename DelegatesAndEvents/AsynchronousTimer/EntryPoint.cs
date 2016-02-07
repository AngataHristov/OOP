using System;

namespace AsynchronousTimer
{
    using System;

    public class EntryPoint
    {
        public static void Main()
        {

            Action f = testMethod; ;
            AsyncTimer test = new AsyncTimer(f, 10, 500);
            test.Run();
            string testString = Console.ReadLine();

        }
        public static void testMethod()
        {
            Console.WriteLine("test");
        }
    }
}
