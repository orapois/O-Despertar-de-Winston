using System;
using WinstonApp;

namespace WinstonApp
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Helper.Counter("O Despertar de Winston", 200);
            Helper.Menu();

            Helper.Clear();
            Chapter1 chapter1= new Chapter1();
            chapter1.DisplayChapter();
            
            Helper.Clear();
            Chapter2 chapter2 = new Chapter2();
            chapter2.DisplayChapter();
        }
        
    }
}

