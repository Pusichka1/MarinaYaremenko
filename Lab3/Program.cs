using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            double f;
            double min;
            double max;
        m1: Console.WriteLine("Значення X");
            double x = double.Parse((Console.ReadLine()));
            Console.WriteLine("Значення Y");
            double y = double.Parse((Console.ReadLine()));
            Console.WriteLine("Значення Z");
            double z = double.Parse((Console.ReadLine()));
            if (x > y)
            {
                max = x;
            }
            else
            {
                max = y;
            }

            if (x + z > x)

            {
                min = x;
            }
            else
            {
                min = (x * y);
            }

            double c = max + (x + z);
            if (c == 0)
            {
                Console.WriteLine(+'\n' + "Для завершення програми натиснiть Enter");


                string j = Console.ReadLine();
                if (j == "") goto m1;
                goto m1;
            }
            else
            {
                f = max + min / (x);
            }
            Console.WriteLine('\n' + "X=" + x + "Y=" + y + "Z=" + z + '\n' + "F  =" + f);
            Console.WriteLine('\n' + "+" + '\n' + "Для завершення програми натиснiть Enter");
            string p = Console.ReadLine();
            if (p != "") goto m1;

        }
    }
}
