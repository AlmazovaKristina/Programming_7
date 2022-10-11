int[,] CreateMatrixRndInt(int rows,int columns,int min,int max)
{
    int [,] matrix = new int[rows,columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        matrix[i,j] = rnd.Next(min,max + 1);
      }  
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
            Console.Write($"{matrix[i,j],5} |");
    }   
     Console.WriteLine("");   
}
}

void PrintArray (double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]}; ");
    Console.Write($"{array[array.Length - 1]}");
}

double[] Average(int[,] matrix)
{
    double[] average = new double [matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i,j];
        }
        average[j] = sum / matrix.GetLength(0);
        average[j] = Math.Round(average[j],2,MidpointRounding.ToZero);
    }
    return average;
}

int [,] array2D = CreateMatrixRndInt(4,5,-10,10);
PrintMatrix(array2D);
Console.WriteLine();
double [] array = Average(array2D);
PrintArray(array);
Console.WriteLine();
