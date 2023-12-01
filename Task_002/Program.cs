// Задача 2: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.


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
for (int i = 0; i < matrix.GetLength(1); i++) 
	{ 
		(matrix[0, i], matrix[(rows-1), i]) = (matrix[(rows-1), i], matrix[0, i]);
	}
    Console.WriteLine();
    PrintMatrix(matrix);
    