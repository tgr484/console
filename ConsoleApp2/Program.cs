using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            args = new string[] { "b", "183687232" };
            if (args.Length == 0)
            {
                Console.WriteLine("Выбери борду! ");
            }
            if(args.Length == 1)
            {
                var a = dvoshLibCore.Functions.GetFunctions.GetBoardByName(args[0]);
                foreach (var q in a.Threads)
                {
                    Console.WriteLine($@"{q.Id} # {q.Subject}");
                }
            }
            if (args.Length == 2)
            {
                var c = dvoshLibCore.Functions.GetFunctions.GetThreadByBoardNameAndId(args[0], int.Parse(args[1]));
                Console.Clear();
                foreach (var q in c.Posts)
                {
                    Console.WriteLine($@"{q.Number}#  {q.Id}  # {q.Text}");
                }
            }
            //    var b = Console.ReadLine();
            //var c = dvoshLibCore.Functions.GetFunctions.GetThreadByBoardNameAndId("b", int.Parse(b));
            //Console.Clear();
            //foreach (var q in c.Posts)
            //{
            //    Console.WriteLine($@"{q.Number}#  {q.Id}  # {q.Text}");
            //}
            Console.ReadLine();
        }
    }
}

