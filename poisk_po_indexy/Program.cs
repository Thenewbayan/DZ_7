// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1(строчка) 7 (столбец) -> такого числа в массиве нет
Console.WriteLine("Создадим двухмерный массив, укажите количество строк и столбцов через enter");
int controlRows=Convert.ToInt32(Console.ReadLine());
int controlCols=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Мы решили что будет справедливо если массив будет из случайнух чисел от и до, введите их через enter");
int minControlValue=Convert.ToInt32(Console.ReadLine());
int maxControlValue=Convert.ToInt32(Console.ReadLine());
int[,] controlMatrix=GetMatrix(controlRows, controlCols, minControlValue, maxControlValue);
int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)//сщздаем 2 мерный массив
{
    int[,] matrix=new int [rows, cols];//строки, столбцы
    for (int i=0; i<matrix.GetLength(0); i++)//строки
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j]=new Random().Next(minValue, maxValue+1);
        }
    }
    return matrix;//вернцли или вычислили результат
}
void PrintMatrix(int [,] matr)//печатаем 2 мерн массив
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write(matr[i,j]+"\t");
        }
        Console.WriteLine();
    }
}//ЗАПОМНИТЬ И ЗНАТЬ!!!!
Console.WriteLine("Отлично, теперь проверим принадлежит ли наша контрольная ячейка созданному массиву");
Console.WriteLine("Введите праметры ячейки (х,у) через enter, учтите что программитсы страшные люди и считают с 0");
int cellX=Convert.ToInt32(Console.ReadLine());
int cellY=Convert.ToInt32(Console.ReadLine());
if(cellX>=controlRows||cellY>=controlCols)
{
    Console.WriteLine($"Ячейка координаты который вы указали {cellX},{cellY} не принадлежит нашему массиву");
}
else 
{
    Console.WriteLine($"Ячейка координаты который вы указали {cellX},{cellY}  принадлежит нашему массиву");
    Console.WriteLine($"В данной ячейке {cellX},{cellY} хранится значение  {controlMatrix[cellX,cellY]}");
}
Console.WriteLine("Проверим так ли это");
PrintMatrix(controlMatrix);