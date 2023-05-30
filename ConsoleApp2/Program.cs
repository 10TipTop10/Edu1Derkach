using System;

class Programm
{
    static void Main(string[] args)
    {
        //Новая строка кода не добавляет новую строку в консоли.
        Console.Write("Привет Мир!!!");

        //Переход на новую строку.
        Console.WriteLine();

        //Каждая строка кода отображается в той же строке консоли.
        Console.Write("Привет ");
        Console.Write("Мир");
        Console.Write("!!!");

        //Переход на новую строку.
        Console.WriteLine();

        //Строка в коде использует новую строку в консоли.
        Console.WriteLine("Привет Мир!!!");

        //Каждая новая строка кода выводится с новой строки в консоли.
        Console.WriteLine("Привет ");
        Console.WriteLine("Мир");
        Console.WriteLine("!!!");

        //Цикл с проверкой кнопки "Enter". Текст в консоль не выводится. Я не делал с помощью ReadLine, так как тогда вводимые символы выводятся в консоль.
        //С ReadLine мне это не понравилось, а как ограничить ввод пока не знаю.
        while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
        //Console.ReadLine();
    }

}