/*Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/

string[] array = { "hello", "2", "world", ":-)", "1234", "-2", "computer science", "Russia" };
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}   ");
    if (array[i].Length <= 3)
    {
        count++;
    }
}

Console.WriteLine();

string[] array2 = new string[count];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        array2[j] = array[i];
        Console.Write($"{array2[j]}   ");
        j++;
    }
}
