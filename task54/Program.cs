// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. (можно использовать готовую функцию)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// -—

Console.WriteLine("Введите количество строк маccива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите элементы массива согласно количеству строк и столбцов через пробел:");
int [,] Array2d = new int [m,n];
string[] str_arr;

for (int i = 0; i < m; i++)
{
    str_arr = (Console.ReadLine()).Split(' ');
    for (int j = 0; j < n; j++)
    {
        Array2d[i,j] = Convert.ToInt32(str_arr[j]);
    }     
}
for (int a = 0; a < m; a++)
{
        for(int b = n-1; b>0; b--)
            {
                for(int c=0; c<b; c++)
                {
                    if(Array2d[a,c]<Array2d[a,c+1])
                    {
                        int temp = Array2d[a,c];
                        Array2d[a,c]=Array2d[a,c+1];
                        Array2d[a,c+1]=temp;
                    }
                }
            }
            Console.WriteLine();
}

Console.WriteLine("Упорядочный массив:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(Array2d[i, j] + "\t");
    } 
        Console.WriteLine("\n");
    
}

