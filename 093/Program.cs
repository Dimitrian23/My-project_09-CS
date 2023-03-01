//Задача_№93  Задайте две матрицы. Напишите программу с подпрограммой MultiMatrix, которая будет находить произведение двух матриц. 
// а) простым поэлементным перемножением
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

void FillArray (int [,] a) 
{
    for (int i = 0;i< a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i,j]=new Random().Next(1,10);
        }
    }


}

void FillArray1 (int [,] b) 
{
    for (int i = 0;i< b.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            b[i,j]=new Random().Next(1,10);
        }
    }


}

void PrintArray ( int[,] a)
{

   for (int i = 0;i< a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            System.Console.Write($"{a[i,j],5}");

        }       
        System.Console.WriteLine();
    }

}

void PrintArray1 ( int[,] b)
{

   for (int i = 0;i< b.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            System.Console.Write($"{b[i,j],5}");

        }       
        System.Console.WriteLine();
    }

}

void multiplication (int [,]a , int[,]b, int[,]c)
{
for (int i = 0;i< a.GetLength(0); i++)
    {
    
        for (int j = 0; j < a.GetLength(1); j++)
        {
            c[i,j]=a[i,j]*b[i,j];
            // System.Console.Write($"{c[i,j],5}"); 
            
        }
        
    }
}

void PrintArray2 ( int[,] c)
{

   for (int i = 0;i< c.GetLength(0); i++)
    {
        for (int j = 0; j < c.GetLength(1); j++)
        {
            System.Console.Write($"{c[i,j],5}");

        }       
        System.Console.WriteLine();
    }

}

int[,] a= new int[2,4];
int[,] b= new int[2,4];
int[,] c= new int[2,4];
Random random=new Random();

FillArray(a);
System.Console.WriteLine("Массив (a) заполненный случайными числами:");
PrintArray(a);
System.Console.WriteLine();

FillArray1(b);
System.Console.WriteLine("Массив (b) заполненный случайными числами:");
PrintArray1(b);
System.Console.WriteLine();

multiplication (a,b,c);

System.Console.WriteLine("Массив (c) заполненный произведением массива (а) на массив (b):");
PrintArray2(c);
System.Console.WriteLine();