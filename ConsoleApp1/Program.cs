// See https://aka.ms/new-console-template for more information
//Создать метод GetName, который возвращает строку и не принимает аргументов.
//Реализовывать метод не нужно, тело должно остаться пустым, но код должен компилироваться.
//Можно использовать string.Empty для того, чтобы вернуть пустую строку. Метод вызовите в методе Main.
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    public static string GetName(string str)
    {
        return str;
    }
    static void Main(string[] args)
    {
        Program.GetName(string.Empty);
    }
}