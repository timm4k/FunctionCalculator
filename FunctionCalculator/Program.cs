class Program
{
    static void Main()
    {
        double x0 = 4.6;
        double xk = 5.8;
        double dx = 0.2;
        double d = 1.3;
        double y;

        Console.WriteLine("Step\t x\t y");

        double x = x0;
        int step = 1;

        while (x <= xk)
        {
            y = Math.Pow(x, 4) + Math.Cos(2 + Math.Pow(x, 3) - d);
            Console.WriteLine($"{step}\t {x:F4}\t {y:F4}");
            x += dx;
            step++;
        }
    }
}
