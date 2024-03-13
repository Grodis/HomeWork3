// Создайте и реализуйте метод, который принимает на вход массив и инвертирует его.
// Вызовите его в методе Main. Исходный массив задайте сами. Инвертированный массив выведите на экран консоли.

class Program
{
    static void Main()
    {
        Massive();
    }

    static int Massive()
    {
        int[] mass = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] mass1 = new int[mass.Length];
        int k = mass.Length - 1;
        for (int i = 0; i < mass.Length; i++, k--)
        {
            mass1[k] = mass[i];
        }
        foreach (var item in mass1)
        {
            Console.Write(item + " ");
        }
        return 0;
    }
}