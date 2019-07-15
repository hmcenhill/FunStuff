using System;

namespace FunStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new App();
            app.Run();

            Console.WriteLine("\n\n-----------------------------------");
            Console.WriteLine("End of Demo. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
