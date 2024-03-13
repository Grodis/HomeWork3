// See https://aka.ms/new-console-template for more information
//Создайте и реализуйте метод, который принимает на вход размер массива n и возвращает пустой массив указанного размера.
//Вызовите метод в методе Main и заполните его полученный массив. Содержимое массива выведите на экран.

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите размер массива");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Заполните массив");
        int[] massive = Massive(n);
        for (int i = 0; i < massive.Length; i++)
        {
            massive[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Содержимое массива:");
        foreach (var item in massive)
        {
            Console.Write(item + " ");
        }
    }
    static int[] Massive(int n)
    {
        return new int[n];
    }
}