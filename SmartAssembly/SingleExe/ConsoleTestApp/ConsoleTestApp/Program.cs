using System;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new MySecretClassLib.SecretClassLib();
            t.ToString();
            Console.WriteLine($"{t}");
            Console.WriteLine($"{t.MySecretMethod()}");
        }
    }
}
