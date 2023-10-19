using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Note;
using Data;

namespace NoteLine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool run = true;

            while (run)
            {
                Console.WriteLine();
                Console.WriteLine("NoteLine > create - read - del - delete - exit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "create":
                        Factory.Create();
                        break;

                    case "read":
                        Factory.Read();
                        break;

                    case "delete":
                        Factory.Delete();
                        break;

                    case "del":
                        Factory.Del();
                        break;

                    case "exit":
                        run = false;
                        break;
                };
            }
        }

    }
}