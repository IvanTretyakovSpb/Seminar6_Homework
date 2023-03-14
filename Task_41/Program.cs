/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
/////////////////////////////////////////////////////////////////////////////////
// Код основной программы
Console.Clear();
int M = GetNumberFromUser("Укажите количество вводимых чисел: ", "Ошибка ввода!");
int[] arrayNumbers = GetArray(M);
int result = FindAmountPositivNumbers(arrayNumbers);
Console.WriteLine($"{String.Join(", ", arrayNumbers)} -> {result}");
//////////////////////////////////////////////////////////////////////////////////
// Запрашивает у пользователя целое положительное число
int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
        {
            return userNumber;
        }
        Console.WriteLine(errorMessage);
    }
}
// создаем массив из вводимых пользователем чисел
int[] GetArray(int size)
{
    int[] resultArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = GetNumberFromUser($"Укажите {i + 1} число: ", "Ошибка ввода!");
    }
    return resultArray;
}
// вычисляем количество положительных элементов массива
int FindAmountPositivNumbers(int[] arr)
{
    var count = 0;
    foreach (var element in arr)
    {
        if (element > 0)
        {
            count++;
        }
    }
    return count;
}