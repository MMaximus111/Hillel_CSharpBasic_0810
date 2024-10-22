internal class Program
{
    private int _age;

    private static void Main(string[] args)
    {
        //decimal x = 2;
        //decimal y = 4;

        //Console.WriteLine(x + y);
        //Console.WriteLine(x - y);
        //Console.WriteLine(x * y);
        //Console.WriteLine(x / y);
        //Console.WriteLine(y % x);


        //bool result = x > y;
        //bool result2 = x < y;
        //bool result3 = x <= y;
        //bool result4 = x >= y;

        int x = 2;
        int y = 5;

        //if (y > x && y % x == 0)
        //{
        //    Console.WriteLine("Yes");
        //}
        //else
        //{
        //    Console.WriteLine("No");
        //}

        //if ((y > x && y >= 5) && y % x == 0)
        //{
        //    Console.WriteLine("Yes");
        //}

        x += y;
        x -= y;
        x /= y;

        x = x * y;
        x *= y;

        Console.WriteLine(x);
    }
}
