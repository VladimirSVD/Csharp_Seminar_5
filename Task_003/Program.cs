// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange) 
{ 
	int[,] tempMatrix = new int[row, col]; 
	Random rand = new Random(); 
	for (int i = 0; i < tempMatrix.GetLength(0); i++) 
	{ 
		for (int j = 0; j < tempMatrix.GetLength(1); j++) 
		{ 
			tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1); 
		} 
	} 
	return tempMatrix; 
}
void PrintMatrix(int[,] matrixForPrint) 
{ 
	for (int i = 0; i < matrixForPrint.GetLength(0); i++) 
	{ 
		for (int j = 0; j < matrixForPrint.GetLength(1); j++) 
		{ 
			System.Console.Write(matrixForPrint[i, j] + "\t"); 
		} 
	System.Console.WriteLine(); 
	} 
}

int Sum = 0;
int SumMin = 0;
int StrMin = 0;
int rows = ReadInt("Введите колличество строк массива: ");
int cols = ReadInt("Введите колличество столбцов массива: ");
int[,] matrix = GenerateMatrix(rows, cols, 0, 10);
PrintMatrix(matrix);
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++) 
		{ 
			Sum = matrix[i, j] + Sum;
        }
    if(i == 0) SumMin = Sum;
    if(Sum < SumMin)
    {
        StrMin = i;
        SumMin = Sum;
    }
    Sum = 0;
}
Console.WriteLine($"индекс строки с наименьшей суммой элементов: {StrMin}");