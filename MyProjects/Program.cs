using System;


namespace c_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("My Projects Made by HolyJLS");
            Console.WriteLine("1) Quadratic Formula");
            Console.WriteLine("2) FizzBuzz");
            Console.WriteLine("3) Number Guesser");
            Console.WriteLine("4) Calculator");
            Console.WriteLine("5)Exit");
            Console.WriteLine("================================");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.Clear();
                    qf();
                    break;
                case 2:
                    Console.Clear();
                    fb();
                    break;
                case 3:
                    Console.Clear();
                    ngg();
                    break;
                case 4:
                    Console.Clear();
                    calc();
                    break;
                case 5:
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Invaid Input");
                    break;
            }

        }

        static void qf()
        {
                int a, b, c;
                double d, x1, x2;

                Console.WriteLine("a: ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("b: ");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("c: ");
                c = Convert.ToInt32(Console.ReadLine());


                d = b * b - 4 * a * c;
                if (d == 0)
                {
                    Console.WriteLine("Both roots are equal.\n");
                    x1 = -b / (2.0 * a);
                    x2 = x1;
                    Console.WriteLine("First Root Root1 = {0}", x1);
                    Console.WriteLine("First Root Root2 = {0}", x2);
                }
                else if (d > 0)
                {
                    Console.WriteLine("Both roots are real and diff-2\n");
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("First Root Root1 = {0}", x1);
                    Console.WriteLine("First Root Root2 = {0}", x2);
                }
                else
                {
                    Console.WriteLine("No Solution");
                }
           
        }
        static void fb()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void ngg()
        {
            int num, comp;
            Console.WriteLine("Your Number(1-10):");
            num = Convert.ToInt32(Console.ReadLine());
            Random randm = new Random();
            comp = randm.Next(1,10);
            Console.WriteLine(comp);
            
            if(num == comp)
            {
                Console.WriteLine("Win");
            } else if(num != comp)
            {
                Console.WriteLine("Loss");
            } else
            {
                Console.WriteLine("Error");
            }
        }

        static void calc()
        {
            Double num1, num2;
            string op;

            Console.WriteLine("Enter a Number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an Operator:");
            op = Console.ReadLine();

            Console.WriteLine("Enter a Number:");
            num2 = Convert.ToDouble(Console.ReadLine());


            if(op == "+")
            {
                Console.WriteLine("Answer:");
                Console.WriteLine(num1 + num2);
            } else if(op == "-")
            {
                Console.WriteLine("Answer:");
                Console.WriteLine(num1 - num2);
            } else if (op == "*")
            {
                Console.WriteLine("Answer:");
                Console.WriteLine(num1 * num2);
            } else if (op == "/")
            {
                Console.WriteLine("Answer:");
                Console.WriteLine(num1 / num2);
            } else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
