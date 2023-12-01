// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен 
// наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца

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
int[,] matrix = GenerateMatrix(rows, cols, 0, 99);
int[,] matrix1 = new int[rows-1, cols-1];
PrintMatrix(matrix);
Console.WriteLine();
int Min = matrix[0, 0];
int Row = 0;
int Col = 0;
int k = 0;
int p = 0;
for (int i = 0; i < matrix.GetLength(0); i++) 
	{ 
		for (int j = 0; j < matrix.GetLength(1); j++) 
		{ 
			if(matrix[i, j] < Min) 
            {
                Min = matrix[i, j];
                Row = i;
                Col = j;
		    } 
        }
	}
for (int i = 0; i < matrix.GetLength(0); i++) 
	{ 
		for (int j = 0; j < matrix.GetLength(1); j++) 
		{ 
			if(j == Col) continue;
            int Temp = matrix[i, j];
            matrix1[k, p] = Temp;
            p++;
        }
        p = 0;
        if(i == Row) continue;
        k++;
	}    
PrintMatrix(matrix1);

