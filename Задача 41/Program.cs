/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Clear();
int[] InputIntArray()
{
    Console.Write("Введите массив чисел через пробел: ");
    string line = Console.ReadLine();
    string[] nums = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] array = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        array[i] = int.Parse(nums[i]);
    }
    return array;
}

int CountPositiveNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] numbers = InputIntArray();
Console.WriteLine($"Положительных чисел введено: {CountPositiveNumber(numbers)}");
