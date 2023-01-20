// Задача 41. Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.
// 0, 7, 8, -2, -3 -> 2

Console.Clear();

int number = GetNumberFromUser();
GetQuantNumber(number);


//Функции, используемые в программе
int GetNumberFromUser()
{
    while (true)
    {
        Console.Write("Введите количество вводимых чисел: ");
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect)
            return num;
        else Console.WriteLine("Ошибка ввода!");
    }
}

void GetQuantNumber(int num)
{
    int[] array = new int[num];
    int count = 0;
    for (int i = 0; i < num; i++)
    {
        while (true)
        {
            Console.Write($"Введите {i+1}-е число: ");
            bool isCorrect = int.TryParse(Console.ReadLine(), out int number);
            if (isCorrect)
            {
                array[i] = number;
                if (array[i] > 0) count++;
                break;
            }
            else Console.WriteLine("Ошибка ввода!");
        }
    }
    Console.WriteLine($"{String.Join(", ", array)} -> {count}");
}
