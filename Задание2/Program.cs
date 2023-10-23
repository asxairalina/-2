int a;
int b;
int c;
double v1;
double v2;
double v3;

while (true)
{
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    c = Convert.ToInt32(Console.ReadLine());
    if (a < 100000 && b < 100000 && c < 100000)
    {
         v1 = (double) a / 2;
        Console.WriteLine(v1);
         v2 = (double) b / 2;
        Console.WriteLine(v2);
        v3 = (double) c / 2;
        Console.WriteLine(v3);
        double d = Math.Ceiling(v1) + Math.Ceiling(v2) + Math.Ceiling(v3);
        Console.WriteLine(d);
    }
}