Console.WriteLine("Write a number a: ");
int a = int.Parse(Console.ReadLine ());

Console.WriteLine("Write a number b: ");
int b = int.Parse(Console.ReadLine ());

Console.WriteLine("Write a number c: ");
int c = int.Parse(Console.ReadLine ());

if (c > b)
{
    if (c > a)
    {
        Console.Write("Максимальное  - ");
        Console.WriteLine(c);
    }
    else
    {
        Console.Write("Максимальное  - ");
        Console.WriteLine(a);
    }
}
else
{
    if (b > a)
    {
        Console.Write("Максимальное - ");
        Console.WriteLine(b);
    }
    else
    {
        Console.Write("Максимальное - ");
        Console.WriteLine(a);
    }
}