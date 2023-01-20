// Задача 43. Напишите программу, которая найдет точку
// пересечения двух прямых, заданных уравнениями
// y=k1*x+b1, y=k2*x+b2; значения b1, k1, b2, k2
// задаются пользователем.
// b1=2, k1=5, b2=4, k2=9 -> (-0,5; -0,5)

Console.Clear();

Console.WriteLine("Найдем точку пересения двух прямых y=k1*x+b1 и y=k2*x+b2.");
int k1 = GetNumbersFromUser("k1");
int b1 = GetNumbersFromUser("b1");
int k2 = GetNumbersFromUser("k2");
int b2 = GetNumbersFromUser("b2");

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны и не пересекаются!");
}
else
{
    double x = Math.Round(ResultX(k1, b1, k2, b2), 2);
    double y = ResultY(x, k1, b1);
    Console.WriteLine($"b1={b1}, k1={k1}, b2={b2}, k2={k2} -> ({x}; {y})");
}



//Функции, используемые в программе
int GetNumbersFromUser(string message)
{
    while (true)
    {
        Console.Write($"Введите значение {message}: ");
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect) return num;
        else Console.WriteLine("Ошибка ввода!");
    }
}

double ResultX(int k11, int b11, int k22, int b22)
{
    double res1 = b22 - b11;
    double res2 = k11 - k22;
    double res = res1 / res2;
    return res;
}

double ResultY(double x11, int k11, int b11)
{
    double res = k11 * x11 + b11;
    return res;
}