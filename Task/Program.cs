/*
Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо 
равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int LengthSearchArray(string[] array, int number)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int length = array[i].Length;
        if (length <= number)
        {
            j++;
        }
    }
    return j;
}

string[] GetNewArray(string[] array, int number, int length)
{
    string[] result = new string[length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= number)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

Console.WriteLine($"Введи количество элементов планируемых ко вводу: ");
int i = Convert.ToInt32(Console.ReadLine());

int number = 3;

string[] text = new string[i];
for (int j = 0; j < i; j++)
{
    Console.WriteLine($"Введите элемент {j + 1}: ");
    text[j] = Console.ReadLine();
}
Console.WriteLine($"Предоставлен массив: ");

PrintArray(text);

int length = LengthSearchArray(text, number);

string[] array = GetNewArray(text, number, length);
if (array.Length <= 0)
{
    Console.WriteLine($"Элементы массива короче или равны длины {number}: ");
    Console.WriteLine($"[]");
}
else
{
    Console.WriteLine($"Элементы массива короче или равны длины {number}: ");
    PrintArray(array);
}
