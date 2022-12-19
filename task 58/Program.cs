// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.


Console.WriteLine("Введите количество строк и столбцов первой матрицы:");
int[,] A = new int [Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
    
    for (int i =0; i<A.GetLength(0); i++)
      {
        for (int j=0; j<A.GetLength(1); j++)
        {
            Console.Write("A[{0},{1}] = ", i,j);
            A[i,j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    Console.WriteLine("Введите количество строк и столбцов второй матрицы:");
    int[,] B = new int [Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
       for (int i =0; i<B.GetLength(0); i++)
      {
        for (int j=0; j<B.GetLength(1); j++)
        {
            Console.Write("B[{0},{1}] = ", i,j);
            B[i,j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    Console.WriteLine("\nМатрица А:");
    Print(A);
    Console.WriteLine("\nМатрица B:");
    Print(B);
    Console.WriteLine("\nМатрица C= А *B: ");
     int[,]C =Multi (A,B);
    Print(C);

    // вычисление матрицы
    static int[,] Multi (int[,] a, int[,] b)
    {
        if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицу нельзя перемножить");
        int[,] r = new int[a.GetLength(0), b.GetLength(1)];
           for (int i =0; i<a.GetLength(0); i++)
        {
            for (int j =0; j<b.GetLength(0); j++)
            {
                for (int k =0; k<b.GetLength(0); k++)
                {
                    r[i,j] += a[i,k] * b[k,j];
                }
            }
        }
        return r;
    }
    // вывод матрицы
    static void Print (int[,] a)
    {
        for (int i =0; i<a.GetLength(0); i++)
        {
            for (int j =0; j<a.GetLength(1); j++)
            {
                Console.Write("{0}", a[i,j]);
            }
        Console.WriteLine();
        }
    }    