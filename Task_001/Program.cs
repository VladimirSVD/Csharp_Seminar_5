// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

int rows = ReadInt("Введите колличество строк массива: ");
int cols = ReadInt("Введите колличество столбцов массива: ");
int[,] matrix = GenerateMatrix(rows, cols, 0, 100);
PrintMatrix(matrix);
int IndexRow = ReadInt("Введите индекс строки массива: ");
int IndexCol = ReadInt("Введите индекс столбца массива: ");
if(IndexRow <= rows && IndexCol <= cols) 
{
    try {
            Console.WriteLine($"значение элемента: {matrix [IndexRow, IndexCol]}");
        }
        catch (IndexOutOfRangeException) 
        {
            Console.WriteLine("такого элемента нет");
        }
} 


