using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;



namespace D_Sobitiya_05._10._2020
{
   

    class Sobitiya
    {
        public delegate void MyDelegat();

        public event MyDelegat sobitiya;

        //для вывода сколько прошло времени с момента отчета
        Stopwatch stopWatch = new Stopwatch(); // секундомер
      
        public void test1()
        {

            sobitiya();

        }
        
        public void Messge()
        {
            stopWatch.Start(); // запустить секундомер
            Console.WriteLine(DateTime.Now.ToString()+"\nЗапуска  события\n\t\tНачат отчет с 0 до 10");
        }
        public void Messge2()
        {
            for (int i = 0; i < 11; i++)
            {
                //добавил задержку по времени для визуализации отчета
                Thread.Sleep(300);
                Console.WriteLine(i);

                if (i == 10)
                {

                    Console.WriteLine(DateTime.Now.ToString() + "\n\t\tОтчет закончен значение достигло 10");

                }
            }

           
            Console.WriteLine();
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;//для вывода сколько прошло времени
            Console.Write("С момента отчета прошло времени :");
            Console.WriteLine($"{ts.Seconds:00 сек}:{ts.Milliseconds:00 м.сек}\n\n"); // вывод секунд и милисекунд
        }
    }

    



    class Program
    {
        static void Main(string[] args)
        {

            


            Sobitiya sobitiya = new Sobitiya();

            sobitiya.sobitiya+= sobitiya.Messge;
            sobitiya.sobitiya += sobitiya.Messge2;

          

            sobitiya.test1();

        }
    }
}
