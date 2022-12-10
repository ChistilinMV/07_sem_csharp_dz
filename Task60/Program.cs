// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateUn3DArray(int row, int col, int page)
{
    int[,,] array = new int[row, col, page];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            int k = 0;
            while (k < page)
            {
                int element = new Random().Next(10, 100);
                if (FindElement(array, element)) continue;
                array[i, j, k] = element;
                k++;
            }
        }
    }
    return array;
}

bool FindElement(int[,,] array, int fel)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == fel) return true;
            }
        }
    }
    return false;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int x = 2;
int y = 2;
int z = 2;
int [,,] my3Darray = CreateUn3DArray(x,y,z);
Print3DArray(my3Darray);
