using System;

namespace Codecool.HelloWorld
{
    public class App
    {
        public static void Main(string[] args)
        {

            var hw = new HelloWorld();
            hw.Welcome(args[0]);

        }
    }
}