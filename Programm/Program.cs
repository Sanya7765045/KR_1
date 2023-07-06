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

static string[] GenerateArray(string[] array)
{
    // Генерируем случайное число элементов для нового массива (от 1 до 3 или меньше, если исходный массив меньше)
    int numElements = new Random().Next(1, 4);

    // Создаем новый массив с сгенерированным числом элементов
    string[] changedArray = new string[numElements];

    // Создаем массив индексов, содержащий индексы элементов исходного массива
    int[] indices = Enumerable.Range(0, array.Length).ToArray();
    // Enumerable.Range(0, array.Length): Это статический метод из класса Enumerable, который генерирует последовательность чисел в указанном диапазоне. 
    // В данном случае, Enumerable.Range(0, array.Length) создает последовательность чисел от 0 до array.Length. 
    // Таким образом, это создает последовательность индексов для элементов массива array.
    // ToArray(): Это метод, применяемый к объектам типа IEnumerable<T>, который преобразует последовательность в массив. 
    // В данном случае, метод ToArray() преобразует созданную последовательность индексов Enumerable.Range(0, array.Length) в массив целых чисел.
    // Перемешиваем индексы для выбора случайных элементов без повторений
    for (int i = 0; i < numElements; i++)
    {
        // Генерируем случайный индекс для выбора элемента из оставшейся части массива
        int randomIndex = new Random().Next(i, array.Length);

        // Меняем местами текущий индекс с случайно выбранным индексом
        int temp = indices[randomIndex];
        indices[randomIndex] = indices[i];
        indices[i] = temp;

        // Выбираем элемент из исходного массива, используя выбранный индекс
        changedArray[i] = array[indices[i]];
    }
    WriteLine("Измененный массив с элементами: " + string.Join(", ", changedArray));
    return changedArray;
}


        // Очищаем консоль, чтобы пользователь мог вводить данные
        Clear();

        string[] myArray = GetArray();
        string[] newArray = GenerateArray(myArray);


        // Ожидание нажатия клавиши, чтобы консоль не закрылась сразу
        ReadKey();

