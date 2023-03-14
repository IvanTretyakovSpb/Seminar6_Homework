// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/////////////////////////////////////////////////////////////////////////////////
// Код основной программы
Console.Clear();
int k1 = GetNumberFromUser("Укажите для уравнения y = k1 * x + b1 значение k1: ", "Ошибка ввода!");
int b1 = GetNumberFromUser("Укажите для уравнения y = k1 * x + b1 значение b1: ", "Ошибка ввода!");
int k2 = GetNumberFromUser("Укажите для уравнения y = k2 * x + b2 значение k2: ", "Ошибка ввода!");
int b2 = GetNumberFromUser("Укажите для уравнения y = k2 * x + b2 значение b1: ", "Ошибка ввода!");
double x = GetX(k1, b1, k2, b2);
double y = GetY(x, k1, b1);
Console.WriteLine($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} -> ({x:f}; {y:f})");
//////////////////////////////////////////////////////////////////////////////////
// Запрашивает у пользователя целое положительное число
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber != 0)
        {
            return userNumber;
        }
        Console.WriteLine(errorMessage);
    }
}
// вычисляем координату Х точки пересечения прямых
double GetX(int k1, int b1, int k2, int b2)
{
    return (double)(b2 - b1) / (k1 - k2);
}
// // вычисляем координату У точки пересечения прямых
double GetY(double x, int k1, int b1)
{
    return (double)k1 * x + b1;
}