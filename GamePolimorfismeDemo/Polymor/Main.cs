using System;

namespace GamePolymorfismeDemo
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Hero h = new Hero();
            h = new Knight();
            h = new Wizard();

        }
    }
}