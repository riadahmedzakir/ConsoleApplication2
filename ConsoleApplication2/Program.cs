using System;

namespace Hangman
{
    class TheGame
    {
            public static int counter = 0;
            public static int life = 5;
        static void Main(string[] args)
        {
            TheGame n = new TheGame();
            String[] words = { "CAT", "DOG", "HORSE", "CHICKEN", "PENGUIN" };
            Random r1 = new Random();
            int value = r1.Next(1, 5);
            //int life = 5;
            //public static int counter = 0;

            Char[] checker = new Char[10];

            for(int i=0; i<10; i ++)
            {
                checker[i] = '_';
            }

            int wordSize = words[value].Length;

            
            //Console.WriteLine("Value: {0}", value);
            Console.WriteLine("The Size of the worst is: {0}", wordSize);
            Console.ReadKey();


            while (life != 0)
            {
                Char a = n.input();
                //Console.WriteLine("{0}", a);
                Console.WriteLine("The Current Situation");
                n.printWord(words[value], words[value].Length, checker, a );           
                Console.ReadKey();
                Boolean c = n.checkGameOver(words[value].Length);
                if( c == true ) { Console.ReadKey(); break; }
                if( life == 0 ) { Console.WriteLine("Game Over"); Console.ReadKey(); }
                

            }
        }


            //-------------------------------------//
            //-----------Functions-----------------//
            //------------------------------------//
            public void printWord(String a, int b, Char[] c, Char d)
            {
                int anotherCounter = 0;
                for (int i = 0; i < b; i++)
                {
                    if ( Convert.ToChar(a[i]) == d )
                    {
                        c[i] = a[i];
                        //Console.WriteLine("{0}", c[i]);
                        Console.Write("{0}", c[i]);
                        counter++;
                        //Console.WriteLine("{0}", counter);
                    }
                    else 
                    {
                        anotherCounter++;
                        //Console.WriteLine("{0}", a[i]);
                        //Console.WriteLine("{0}", c[i]);
                        Console.Write("{0} ", c[i]);
                        if (anotherCounter == b) { life--; }
                        //Console.WriteLine("{0}", life);
                    }
                }
                Console.WriteLine();
            }

    
            public Char input()
            {
                Console.Write("Enter Character :");
                object a = (Console.ReadKey().Key);
                Char b = Convert.ToChar(a);
                Console.WriteLine();
                return b;                        
            }

            public Boolean checkGameOver(int b)
            {
                if (counter == b)
                {
                    Console.WriteLine("You Win");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
}

