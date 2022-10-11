double[,] CreateMatrixRndInt(int rows,int columns,double min,double max)
{
    double [,] matrix = new double[rows,columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        matrix[i,j] = rnd.NextDouble()*(max - min) + min;
        matrix[i,j] = Math.Round(matrix[i,j],1,MidpointRounding.ToZero);
      }  
    }
    return matrix;
}

double [,] array2D = CreateMatrixRndInt(3,4,-10,10);

void PrintMatrix (double[,] matrix)
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
PrintMatrix(array2D);





