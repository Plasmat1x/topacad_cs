using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBT
{
    public delegate void handler(string text);
    public delegate bool handler2(string text);

    internal class Program
    {
        static public event handler eventhandler;
        static public event handler2 eventhandler2;

        static string answer;
        static void Main(string[] args)
        {
            Console.WriteLine("write 1 to continue ");

            answer = Console.ReadLine();

            eventhandler += Show;
            eventhandler += Show2;
            eventhandler2 += Show3;

            if (answer == "1")
            {
                Console.WriteLine("Wirte str ");
                answer = Console.ReadLine();
                eventhandler(answer);

                if(eventhandler2(answer))
                {
                    Console.WriteLine(answer + " " + eventhandler2(answer).ToString());
                }
            }

            Console.ReadKey();
        }

        static void Show(string text)
        {
            Console.WriteLine(text);
        }

        static void Show2(string text)
        {
            Console.WriteLine("Pressed");
        }

        static bool Show3(string text)
        {
            if (text.Length > 0)
                return true;

            return false;
        }
    }
}
