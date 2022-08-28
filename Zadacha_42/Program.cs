/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10*/

Console.Write("Введите любое десятичное число: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());
int i = 0;
int j = 0;
int lenghtArray = decimalNumber;
while (lenghtArray > 0)
{
    lenghtArray = lenghtArray / 2;
    j++;
}
int[] array = new int[j];
while (decimalNumber > 0)
{
    int binaryNumber = decimalNumber % 2;
    array[i] = binaryNumber;
    decimalNumber = decimalNumber / 2;
    i++;
    }
int[] resultArray = new int[i];
int lastIndex = i - 1;
for (int n = 0; n < i; n++)
{
    resultArray[n] = array[lastIndex - n];
}
Console.WriteLine($"Двоичное число: {string.Join("", resultArray)}");