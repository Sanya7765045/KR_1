# Программа для ввода и изменения массива

Программа позволяет пользователю ввести массив символов или строк с клавиатуры и изменить его, генерируя новый массив с уникальными элементами.

## Ввод массива

Функция `GetArray()` запрашивает у пользователя размер массива и последовательно принимает ввод символов или строк. Введенные элементы сохраняются в массиве и выводятся на экран.

## Изменение массива

Функция `GenerateArray(array)` принимает исходный массив `array` в качестве параметра. Она генерирует новый массив с уникальными элементами из исходного массива, не превышающими 3 элемента. Алгоритм случайного выбора уникальных элементов без повторений использует перемешивание индексов массива.

## Использование программы

1. Программа начинается с очистки консоли для удобного ввода данных.
2. Вызывается функция `GetArray()`, в результате которой пользователь вводит массив.
3. Вызывается функция `GenerateArray(myArray)`, где `myArray` - исходный массив пользователя. Функция генерирует новый массив с уникальными элементами и выводит его на экран.
4. После завершения работы программы ожидается нажатие клавиши, чтобы консоль не закрылась сразу.

## Запуск программы

1. Скомпилируйте программу с использованием C# компилятора.
2. Запустите скомпилированную программу.
3. Введите размер массива и элементы массива по указаниям программы.

Введите размер массива: 5
Введите символ или строку 1: A
Введите символ или строку 2: B
Введите символ или строку 3: C
Введите символ или строку 4: D
Введите символ или строку 5: E
Массив элементов: A, B, C, D, E
Измененный массив с элементами: B, C, E

## Требования к окружению

- Язык программирования: C#
- Компилятор C#
- Консольное окружение
- Версия C#: 7.0 или выше

---
Автор: Дьячков Александр
