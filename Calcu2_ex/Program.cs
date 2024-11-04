namespace Calcu2_ex
{
     class Program
    {
        static double Calcu(double a, string op, double b)
        {
            double r = 0;
            switch (op)
            {
                case "+":
                    r = a + b;
                    break;
                case "-":
                    r = a - b;
                    break;
                case "*":
                    r = a * b;
                    break;
                case "/":
                    r = a / b;
                    break;
            }
            return r;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("계속 진행할까요?(중지를 원하시면 q 를 입력하세요)");
                string quit = Console.ReadLine();
                if (quit == "q") break;
                Console.Write("값1?");
                double x = double.Parse(Console.ReadLine());
                Console.Write("연산(+,-,*,/)?");
                string o = Console.ReadLine();
                Console.Write("값2?");
                double y = double.Parse(Console.ReadLine());
                double result = Calcu(x, o, y);
                Console.WriteLine("={0,2:F}", result);
            }

        }
    }
}
