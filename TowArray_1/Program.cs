// // строковый двумерный массив

// // string[,] table = new string[2, 5];
// // // String.Empty   -  инициализация строк
// // // table[0,0] table[0,1] table[0,2]  table[0,3]  table[0,4]
// // // table[1,0] table[1,1] table[1,2]  table[1,3]  table[1,4]

// // table[1,2] = "слово";

// // for (int rows = 0; rows < 2; rows++)
// // {
// //    for (int columns = 0; columns < 5; columns++)
// //    {
// //     Console.WriteLine($"-{table[rows, columns]}-");
// //    } 
// // }

// // численный двумерный массив

// int[,] matrix = new int[3,4];

// for (int i = 0; i < matrix.GetLength(0); i++)     // через "GetLength(0)" указали кол.строк
// {
//     for (int j = 0; j < matrix.GetLength(1); j++) // через "GetLength(1)" указали кол.столбцов
//     {
//         Console.Write($"{matrix[i,j]} ");
//     }
//     Console.WriteLine();
// }

// метод печатающий двумерный массив:
void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)    
{
    for (int j = 0; j < matr.GetLength(1); j++) 
    {
        Console.Write($"{matr[i,j]} ");
    }
    Console.WriteLine();
}
}
// PrintArray(matrix);

// метод заполняющий двумерный массив

void FillArray(int[,] matr)
  {
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(10,100);
        }
    }
  }

  int[,] matrix = new int[3,4];
  PrintArray(matrix);
  Console.WriteLine();
  FillArray(matrix);
  PrintArray(matrix);
