//Задача 2. Реализуйте класс "Matrix", представляющий двумерную матрицу. 
//Реализуйте индексатор, который позволяет получать и задавать элементы матрицы по индексу 
//строки и столбца. Создайте объект типа "Matrix" и заполните его элементами. 
//Затем выведите некоторые элементы матрицы, используя индексатор.

using System;

Console.WriteLine("Матрица");

Matrix matrix = new Matrix(2, 3);
matrix[0, 0] = 13;
matrix[0, 1] = 64;
matrix[0, 2] = 75;
matrix[1, 0] = 23;
matrix[1, 1] = 3;
matrix[1, 2] = 56;

for (int i = 0; i < matrix.Rows; i++)
{
    for (int j = 0; j < matrix.Cols; j++)
    {

        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Некоторые элементы матрицы:");
Console.WriteLine(matrix[0, 0]);
Console.WriteLine(matrix[1, 0]);
Console.WriteLine(matrix[1, 2]);


