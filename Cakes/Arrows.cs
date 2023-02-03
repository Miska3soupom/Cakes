using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cakes
{
    internal class Arrows
    {
        static Program Prog = new Program();
        public int ArrowsPick(int amount, int pos) 
        {
            ConsoleKey key = ConsoleKey.UpArrow;
            do
            {
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.UpArrow:
                        pos--;
                        if (pos >= 2)
                        {
                            Console.SetCursorPosition(0, pos);
                            Console.WriteLine("-->");
                        }
                        else if (pos < 2) 
                        {
                            pos = amount;
                            Console.SetCursorPosition(0, pos);
                            Console.WriteLine("-->");
                        }
                        if (amount == 9)
                        {
                            Prog.MainMenu();
                        }
                        else 
                        {
                            Prog.UnderMenu();
                        }
                        key = Console.ReadKey().Key;
                        Console.Clear();
                        continue;

                    case ConsoleKey.RightArrow:
                    case ConsoleKey.DownArrow:
                        pos++;
                        if (pos <= amount)
                        {        
                            Console.SetCursorPosition(0, pos);
                            Console.WriteLine("-->");
                        }
                        if (pos > amount)
                            {
                                pos = 2;
                            }
                        if (amount == 9)
                        {
                            Prog.MainMenu();
                        }
                        else
                        {
                            Prog.UnderMenu();
                        }
                        key = Console.ReadKey().Key;
                        Console.Clear();
                        continue;
                    case ConsoleKey.Enter:
                        return pos;
                    default:
                        key = Console.ReadKey().Key;
                        continue;
                }
            } while (key != ConsoleKey.Escape);
            if (amount == 9) 
            {
                return 9;
            }
            else
            {
                return 0;
            }
        }
    }
}
