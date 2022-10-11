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

bool checkCoordinates(int cI, int cJ, int[,] m)
{
    if (cI < 0)
    {
        Console.WriteLine("Координата i меньше нуля");
        return false;
    }
    if (cJ < 0)
    {
        Console.WriteLine("Координата j меньше нуля");
        return false;
    }
    if (cI >= m.GetLength(0))
    {
        Console.WriteLine("Координата i больше размера строки");
        return false;
    }
    if (cJ >= m.GetLength(1))
    {
        Console.WriteLine("Координата j больше размера столбца");
        return false;
    }
    return true;
}

int [,] array2D = CreateMatrixRndInt(3,4,-10,10);
PrintMatrix(array2D);

Console.Write("Введите число i:");
int numI = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число j:");
int numJ= Convert.ToInt32(Console.ReadLine());

bool correct = checkCoordinates(numI, numJ, array2D);
if (!correct)
{
    return;
}

int number = array2D[numI, numJ];
Console.WriteLine($"{number}");



