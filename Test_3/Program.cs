namespace Test_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while (key.Modifiers.HasFlag(ConsoleModifiers.Control) && key.Key == ConsoleKey.P)
            Console.WriteLine("Выберете какую актаву хотите использовать где f1 это первая, f2 вторая и f3 третья");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.F1)
            {
                f1();
            }
            if (key.Key == ConsoleKey.F2)
            {
                f2();
            }
            if (key.Key == ConsoleKey.F3)
            {
                f3();
            }
            static void f1()
            {
                int[] f1 = new[] { 1635, 1732, 1835, 1945, 2060, 2183, 2312, 2450, 2596, 2750, 2914, 3087};
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.F2)
                {
                    f2();
                }
                if (key.Key == ConsoleKey.F3)
                {
                    f3();
                }
                if (key.Key == ConsoleKey.C)
                {
                    Console.Beep(f1[0], 100);
                }
                if (key.Modifiers.HasFlag(ConsoleModifiers.Alt) && key.Key == ConsoleKey.C)
                {
                    Console.Beep(f1[1], 100);
                }
                if (key.Key == ConsoleKey.D)
                {
                    Console.Beep(f1[2], 100);
                }
                if (key.Modifiers.HasFlag(ConsoleModifiers.Alt) && key.Key == ConsoleKey.E)
                {
                    Console.Beep(f1[3], 100);
                }
                if (key.Key == ConsoleKey.E)
                {
                    Console.Beep(f1[4], 100);
                }
                if (key.Key == ConsoleKey.F)
                {
                    Console.Beep(f1[5], 100);
                }
                if (key.Modifiers.HasFlag(ConsoleModifiers.Alt) && key.Key == ConsoleKey.F)
                {
                    Console.Beep(f1[6], 100);
                }
                if (key.Key == ConsoleKey.G)
                {
                    Console.Beep(f1[7], 100);
                }
                if (key.Modifiers.HasFlag(ConsoleModifiers.Alt) && key.Key == ConsoleKey.G)
                {
                    Console.Beep(f1[8], 100);
                }
                if (key.Key == ConsoleKey.A)
                {
                    Console.Beep(f1[9], 100);
                }
                if (key.Modifiers.HasFlag(ConsoleModifiers.Alt) && key.Key == ConsoleKey.B)
                {
                    Console.Beep(f1[10], 100);
                }
                if (key.Key == ConsoleKey.B)
                {
                    Console.Beep(f1[11], 100);
                }

            }
            static void f2()
            {
                int[] f2 = new[] { 3270, 3465, 3671, 3889, 4120, 4365, 4625, 4900, 5191, 5500, 5827, 6174 };
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.F1)
                {
                    f1();
                }
                if (key.Key == ConsoleKey.F3)
                {
                    f3();
                }
                if (key.Key == ConsoleKey.C)
                {
                    Console.Beep(f2[0], 100);
                }
                if (key.Modifiers.HasFlag(ConsoleModifiers.Alt) && key.Key == ConsoleKey.C)
                {
                    Console.Beep(f2[1], 100);
                }
                if (key.Key == ConsoleKey.D)
                {
                    Console.Beep(f2[2], 100);
                }
                if (key.Modifiers.HasFlag(ConsoleModifiers.Alt) && key.Key == ConsoleKey.E)
                {
                    Console.Beep(f2[3], 100);
                }
                if (key.Key == ConsoleKey.E)
                {
                    Console.Beep(f2[4], 100);
                }
                if (key.Key == ConsoleKey.F)
                {
                    Console.Beep(f2[5], 100);
                }
                if (key.Modifiers.HasFlag(ConsoleModifiers.Alt) && key.Key == ConsoleKey.F)
                {
                    Console.Beep(f2[6], 100);
                }
                if (key.Key == ConsoleKey.G)
                {
                    Console.Beep(f2[7], 100);
                }
                if (key.Modifiers.HasFlag(ConsoleModifiers.Alt) && key.Key == ConsoleKey.G)
                {
                    Console.Beep(f2[8], 100);
                }
                if (key.Key == ConsoleKey.A)
                {
                    Console.Beep(f2[9], 100);
                }
                if (key.Modifiers.HasFlag(ConsoleModifiers.Alt) && key.Key == ConsoleKey.B)
                {
                    Console.Beep(f2[10], 100);
                }
                if (key.Key == ConsoleKey.B)
                {
                    Console.Beep(f2[11], 100);
                }
            }
            static void f3()
            {
                int[] f3 = new[] { 6541, 6930, 7342, 7778, 8241, 8731, 9250, 9800, 10380, 11000, 11650, 12350 };
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.F1)
                {
                    f1();
                }
                if (key.Key == ConsoleKey.F2)
                {
                    f2();
                }
                if (key.Key == ConsoleKey.C)
                {
                    Console.Beep(f3[0], 100);
                }
                if (key.Modifiers.HasFlag(ConsoleModifiers.Alt) && key.Key == ConsoleKey.C)
                {
                    Console.Beep(f3[1], 100);
                }
                if (key.Key == ConsoleKey.D)
                {
                    Console.Beep(f3[2], 100);
                }
                if (key.Modifiers.HasFlag(ConsoleModifiers.Alt) && key.Key == ConsoleKey.E)
                {
                    Console.Beep(f3[3], 100);
                }
                if (key.Key == ConsoleKey.E)
                {
                    Console.Beep(f3[4], 100);
                }
                if (key.Key == ConsoleKey.F)
                {
                    Console.Beep(f3[5], 100);
                }
                if (key.Modifiers.HasFlag(ConsoleModifiers.Alt) && key.Key == ConsoleKey.F)
                {
                    Console.Beep(f3[6], 100);
                }
                if (key.Key == ConsoleKey.G)
                {
                    Console.Beep(f3[7], 100);
                }
                if (key.Modifiers.HasFlag(ConsoleModifiers.Alt) && key.Key == ConsoleKey.G)
                {
                    Console.Beep(f3[8], 100);
                }
                if (key.Key == ConsoleKey.A)
                {
                    Console.Beep(f3[9], 100);
                }
                if (key.Modifiers.HasFlag(ConsoleModifiers.Alt) && key.Key == ConsoleKey.B)
                {
                    Console.Beep(f3[10], 100);
                }
                if (key.Key == ConsoleKey.B)
                {
                    Console.Beep(f3[11], 100);
                }
            }
            //key = Console.ReadKey();
        }
    }
}