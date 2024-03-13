// Создайте и реализуйте метод, который будет принимать число по ссылке (ref) и менять его знак на противоположный.
// Метод должен принимать один аргумент и не возвращать ничего.

class Program
{
    static void Main()
    {
        int k;
        Console.WriteLine("Введите число");
        k = Convert.ToInt32(Console.ReadLine());
        Znak(ref k);
        Console.WriteLine("Число после изменения знака "+ k);
    }

    static void Znak(ref int n)
    {
        n = -n;
    }
}