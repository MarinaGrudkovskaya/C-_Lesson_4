﻿// Р Е К У Р С И Я

int[,] pic = new int[,]  //задали вручную двумерный массив
{
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0},
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    {0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0},
    {0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0},
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    {0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
};
void PrintImage(int[,] image) //метод печатающий картинку
{
for (int i = 0; i < image.GetLength(0); i++)    
{
    for (int j = 0; j < image.GetLength(1); j++) 
    {
        // Console.Write($"{image[i,j]} ");
        if (image[i,j] == 0) Console.Write($" ");
        else Console.Write($"#");
        
    }
    Console.WriteLine();
}
}

void FillImage(int row, int col) // в качестве аргумента метода указали позиции строки и колонки
 {
    if(pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row-1, col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);
        
    }
 }

PrintImage(pic);
FillImage(5, 5); // точку нужно выбирать внутри контура, контур должен быть замкнутый
PrintImage(pic); 

