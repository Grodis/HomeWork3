// See https://aka.ms/new-console-template for more information
// Создать метод GetArray, который возвращает массив целых чисел и не принимает аргументов.
// Реализовывать метод не нужно, тело должно остаться пустым, но код должен компилироваться.
// В теле метода можно вернуть пустой массив. Метод вызовите в методе Main.
using System.Linq.Expressions;


internal class Program
{
    public static int GetArray(int[] mass)
    {
        return mass[0];
    }
    static void Main()
    {
        Program.GetArray();
    }
}
