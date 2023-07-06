using System;
using static System.Console;

    static string[] GetArray()
    {
        // Запросить у пользователя размер массива
        Write("Введите размер массива: ");
        int n = int.Parse(ReadLine());

        // Создать массив заданного размера
        string[] array = new string[n];

        // Запросить у пользователя ввод символов или строк и добавить их в массив
        for (int i = 0; i < n; i++)
        {
            Write($"Введите символ или строку {i + 1}: ");
            string input = ReadLine();
            array[i] = input;
        }

        // Вывести массив
        WriteLine("Массив элементов: " + string.Join(", ", array));
        return array;
    }

        // Очищаем консоль, чтобы пользователь мог вводить данные
        Clear();

        string[] myArray = GetArray();

        // Ожидание нажатия клавиши, чтобы консоль не закрылась сразу
        ReadKey();

