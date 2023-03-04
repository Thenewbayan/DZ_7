// в массиве найти сумму элементов по главной диагонали
//(0,0)+(1,1)+(2,2) и тд

//скопипастим создание массива с пред задачи
Console.WriteLine("Создадим двухмерный массив, укажите количество строк и столбцов через enter");
int controlRows = Convert.ToInt32(Console.ReadLine());
int controlCols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Мы решили что будет справедливо если массив будет из случайнух чисел от и до, введите их через enter");
int minControlValue = Convert.ToInt32(Console.ReadLine());
int maxControlValue = Convert.ToInt32(Console.ReadLine());
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
int[,] controlMatrix = GetMatrix(controlRows, controlCols, minControlValue, maxControlValue);
int summ=0;
int i=0;
int j=0;
//i  индекс строк, j индекс столбцов
while ((i<controlMatrix.GetLength(0)) && (j<controlMatrix.GetLength(1)))
{
    summ+=controlMatrix[i,j];
    i+=1;
    j+=1;
}
Console.WriteLine($"Сумма элементов по главной диагонали равна {summ}");
Console.WriteLine("проверяем");
PrintMatrix(controlMatrix);
