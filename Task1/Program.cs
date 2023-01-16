// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void CreateFillArray()
{
  Console.WriteLine("Введите количество строк и столбцов в таблице (ввод числа через enter)");
  double[,] array = new double[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
  Console.WriteLine();
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = Convert.ToDouble(Random.Shared.Next(-100, 100)) / 10;
      Console.Write($"|{array[i, j], 5} | ");
    }
    Console.WriteLine();
  }
}
CreateFillArray();