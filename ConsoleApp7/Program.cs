// Создайте и реализуйте метод, который будет принимать два числа и менять их значения местами. Вызовите метод в Main.

class Program
{
    static void Main()
    {
        int n = 2;
        Console.WriteLine("Введите 2 числа");
        int[] mass = Massive(n);
        for (int i = 0; i < mass.Length; i++)
        {
            mass[i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] mass1 = new int[mass.Length];
        int k = mass.Length - 1;
        for (int i = 0; i < mass.Length; i++, k--)
        {
            mass1[k] = mass[i];
        }
        Console.WriteLine("Числа после смены мест");
        foreach (var item in mass1)
        {
            Console.Write(item + " ");
        }
    }
    static int[] Massive(int n)
    {
        return new int[n];
    }
}