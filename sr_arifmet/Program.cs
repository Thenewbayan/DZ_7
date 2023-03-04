// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Создадим двухмерный массив, укажите количество строк и столбцов через enter");
int controlRows = Convert.ToInt32(Console.ReadLine());
int controlCols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Мы решили что будет справедливо если массив будет из случайнух чисел от и до, введите их через enter");
int minControlValue = Convert.ToInt32(Console.ReadLine());
int maxControlValue = Convert.ToInt32(Console.ReadLine());
int[,] controlMatrix = GetMatrix(controlRows, controlCols, minControlValue, maxControlValue);
int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)//сщздаем 2 мерный массив
{
    int[,] matrix = new int[rows, cols];//строки, столбцы
    for (int i = 0; i < matrix.GetLength(0); i++)//строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;//вернцли или вычислили результат
}
void PrintMatrix(int[,] matr)//печатаем 2 мерн массив
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}//ЗАПОМНИТЬ И ЗНАТЬ!!!!
Console.WriteLine("найдем среднее арифметическое для строки или столбца на выбор");
Console.WriteLine("чтобы выбрать строку введите 0, чтобы выбрать столбец введите 1");
int el = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("укажите индекс строки или столбца который мы ищем");
int index = Convert.ToInt32(Console.ReadLine());
double average = 0;
if (el == 0)
{
    double summ = 0;
    for (int i = 0; i < controlMatrix.GetLength(1); i++)//индекс столбца
    {
        int j = index;//индекс строки, потому что ищем столбец
        summ += controlMatrix[j, i];
        average = Math.Round((summ / (i + 1)), 2);//индекс +1 потому что количество а не номер по порядку
    }
    Console.WriteLine($"среднее арифметическое строки с индексом {index} равно {average}");
    Console.WriteLine("для проверки");
    PrintMatrix(controlMatrix);
}
else if (el == 1)
{
    double summ = 0;
    for (int i = 0; i < controlMatrix.GetLength(0); i++)//индекс строки
    {
        int j = index;//индекс столбца, потому что ищем строку
        summ += controlMatrix[i, j];
        average = Math.Round((summ / (i + 1)), 2);//индекс +1 потому что количество а не номер по порядку
    }
    Console.WriteLine($"среднее арифметическое столбца с индексом {index} равно {average}");
    Console.WriteLine("для проверки");
    PrintMatrix(controlMatrix);
}
else
{
    Console.WriteLine("вы ввели некоректное значение, вас просили указать 0 ли 1 при выборе строки/столбца");
}

