// See https://aka.ms/new-console-template for more information
//Создайте и реализуйте метод, который вычисляет сумму двух чисел и возвращает их сумму.
//Вызовите метод в методе Main и выведите результат на экран. Два числе передайте в метод как вам угодно.
//Метод, который вы напишите, не должен работать с консолью.
internal class Program
{
    static int Calc(int a, int b)
    {
        int sum = a + b;
        return sum;
    }
    static void Main(string[] args)
    {
        Program.Calc(10, 15);
    }
}
