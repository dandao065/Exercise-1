namespace CSLT_B2
{
    internal class Exercises_02
    {
        static void Main()
        {
            Ex01();
            Ex02();
            Ex03();
            Ex04();
            Ex05();
            Ex06();
            Ex07();
            Ex08();
            Ex09();
            Ex10();
        }
        //1. Add/sum two numbers.
        static void Ex01()
        {
            int a = 3, b = 4;
            int c = a + b;
            Console.WriteLine($"a={a},b={b}");
            Console.WriteLine($"c=a+b={c}");
        }
        //2. Swap values of two variables.
        static void Ex02()
        {
            int a = 3, b = 4;
            int c = a;
            Console.WriteLine("so ban dau:");
            Console.WriteLine($"a={a},b={b}");
            a = b;
            b = c;
            Console.WriteLine("so luc sau:");
            Console.WriteLine($"a={a},b={b}");
        }
        //3. Multiply two Floating Point Numbers.
        static void Ex03()
        {
            float a = 5.7f;
            float b = 6.3f;
            float c = a * b;
            Console.WriteLine($"a*b=c={c}");
        }
        //4. convert feet to meter
        static void Ex04()
        {
            Console.Write("Enter a number in feet:");
            double ftnumber = Convert.ToDouble(Console.ReadLine());
            double result = ftnumber * 0.3048;
            Console.WriteLine($"Meter=: {result}m");
        }
        //5. convert Celsius to Fahrenheit and vice versa.
        static void Ex05()
        {
            Console.Write("Enter a number in Celsius:");
            double cnumber = Convert.ToDouble(Console.ReadLine());
            double fresult = cnumber * 1.8 + 32;
            Console.WriteLine($"Fahrenheit= {fresult}F");

            Console.Write("Enter a number in Farenheit:");
            double fnumber = Convert.ToDouble(Console.ReadLine());
            double cresult = (fnumber - 32) / 1.8;
            Console.WriteLine($"Celsius= {cresult}C");
        }
        //6. find the Size of data types.
        static void Ex06()
        {
            Console.WriteLine("kich thuoc byte: " + sizeof(byte) + "byte");
            Console.WriteLine("kich thuoc boolean: " + sizeof(bool) + "byte");
            Console.WriteLine("kich thuoc integer: " + sizeof(int) + "bytes");
            Console.WriteLine("kich thuoc char: " + sizeof(char) + "byte");
            Console.WriteLine("kich thuoc double: " + sizeof(double) + "bytes");
            Console.WriteLine("kich thuoc float: " + sizeof(float) + "bytes");
            Console.WriteLine("kich thuoc long: " + sizeof(long) + "bytes");
            Console.WriteLine("kich thuoc decimal: " + sizeof(decimal) + "bytes");
            Console.WriteLine("kich thuoc uint: " + sizeof(uint) + "bytes");
            Console.WriteLine("kich thuoc short: " + sizeof(short) + "bytes");
        }
        //7. Print ASCII Value.
        static void Ex07()
        {
            Console.Write("Enter a random char: ");
            char random_char = Console.ReadKey().KeyChar;
            Console.WriteLine($"\nASCII Value: {(int)random_char}");
        }
        //8. Calculate Area of Circle.
        static void Ex08()
        {
            Console.WriteLine("Area of circle:");
            Console.Write("Enter radius(r): ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double A = radius * radius * 3.14;
            Console.WriteLine($"Area of circle= {A}");
        }
        //9. Calculate Area of Square.
        static void Ex09()
        {
            Console.WriteLine("Area of square:");
            Console.Write("Enter side(a): ");
            double side = Convert.ToDouble(Console.ReadLine());
            double A = side * side;
            Console.WriteLine($"Area of square= {A}");
        }
        //10.  convert days to years, weeks and days.
        static void Ex10()
        {
            Console.Write("Enter number of days: ");
            int totaldays = Convert.ToInt32(Console.ReadLine());
            int year = totaldays / 365;
            int week = (totaldays - 365 * year) / 7;
            int day = totaldays - 365 * year - 7 * week;
            Console.WriteLine($"Convert into {year} year(s), {week} week(s), {day} day(s)");
        }
    }
}

