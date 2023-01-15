// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] CreateFillArray()
{
    Console.WriteLine("Введите количество строк и столбцов в таблице (ввод числа через enter): ");
    int[,] arr = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Random.Shared.Next(10);
            Console.Write($"|{arr[i, j]}| ");
        }
        Console.WriteLine();
    }
    return arr;
}
void GetMidleArithmetic(int[,] array)
{
    double midlAr = 0;
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            midlAr += array[i,j];
        }
        Console.WriteLine ($"Среднее арифмитическое числел {j + 1} столбца = {Math.Round(midlAr / array.GetLength(1), 2)}");
        midlAr = 0;
    }
}
int[,] array = CreateFillArray();
GetMidleArithmetic(array);