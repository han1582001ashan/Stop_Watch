
using System;
namespace Program
{
    class Program{
        static void Main(string[] args){
           Console.WriteLine("1. start");
           Console.WriteLine("2. end");
           Console.WriteLine("3. Exit");
           StopWatch stopWatch = new StopWatch();
           stopWatch.Start();
           int lc= Int32.Parse(Console.ReadLine());
           do{
        
            switch(lc){
                case 1: stopWatch.Start();
                break;
                case 2: stopWatch.Stop();
                 lc= Int32.Parse(Console.ReadLine());
                
                Console.WriteLine("Total time: "+stopWatch.GetElapsedTime());
                break;
            }

           }while (lc!=3);
        }
    }
}