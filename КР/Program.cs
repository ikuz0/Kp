void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент: >> ");
        array[i] = Console.ReadLine()!;

    }
}

void PrintArray(string[] array)
{
    int count = array.Length;


    Console.WriteLine($"Входной массив: ");
    Console.Write($">> ");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}



Console.WriteLine("Введите колличество элементов: ");
int num = int.Parse(Console.ReadLine()!);
string[] array = new string[num];
FillArray(array);
PrintArray(array);


