/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/


int M = 5;
int[] array = new int[M];
Console.Write("Введите M чисел: ");
for (int i = 0; i < M; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int positiveNumber = 0;
for (int j = 0; j < M; j++)
{
    if (array[j] > 0) positiveNumber++;
}
Console.WriteLine($"Array: [{string.Join(", ", array)}]");
Console.Write($"Количество чисел больше 0: {positiveNumber}");
