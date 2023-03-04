// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
double[,] GetMatrix(int rows, int cols)//сщздаем 2 мерный массив
{
    double[,] matrix = new double[rows, cols];//строки, столбцы
    for (int i = 0; i < matrix.GetLength(0); i++)//строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(((new Random().NextDouble()) * 10), 2);
        }
    }
    return matrix;//метод копируем из семинара и меняем тип с инт на дабл
}
void PrintMatrix(double[,] matr)//печатаем 2 мерн массив
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}///метод копируем из семинара и меняем тип с инт на дабл
double[,] resultArray = GetMatrix(3, 4);
PrintMatrix(resultArray);
