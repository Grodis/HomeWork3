// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Replace(ref a, ref b);

        Console.WriteLine("После перестановки чисел:");
        Console.WriteLine("Теперь первое число: " + a);
        Console.WriteLine("Теперь второе число: " + b);
    }

    static void Replace(ref int x, ref int y)
    {
        int i = x;
        x = y;
        y = i;
    }
}
