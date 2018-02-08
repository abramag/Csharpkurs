
using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string names in args) {
                Console.WriteLine("Witamy " +names);
            }
//            string name = args[0];
            //Console.WriteLine(name);
            Console.WriteLine("test");
            Console.ReadLine();
            
        }
    }
}
