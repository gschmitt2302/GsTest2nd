using CoreLib;
using FrameworkLib;
using StandardLib;
using System;

namespace CoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var c = new CoreClass1();
            c.SayHello();
            var f = new FrameworkClass1();
            f.SayHello();
            var s = new StandardClass1();
            s.SayHello();
        }
    }
}
