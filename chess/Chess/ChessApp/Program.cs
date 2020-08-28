using System;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X");
            Console.WriteLine("0");

            Console.ReadKey();

            for (var y = 0; y < 8; y++)
            {
                for (var x = 0; x < 16; x++)

                {
                    var characterIndex = (x / 2 + y) % 2;
            char character = characterIndex == 0 ? 'X' : '0';

            Console.Write(character);

        }

            Console.Write('\n');

            }


            Console.ReadKey();

        }








            //Console.WriteLine(c);
                //Console.Write("X");
                //Console.Write("0");
                //Console.ReadKey();


            }
    }

