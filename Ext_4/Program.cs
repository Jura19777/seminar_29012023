//В матрице чисел найти сумму элементов главной диагонали

int ReadInt(string str)
{
    Console.Write(str);
    return int.Parse(Console.ReadLine()!);
}

int SumMTR(int[,] mtr)
{
    int sum = 0;
    for (int i=0; i<mtr.GetLength(0); i++)
            sum = mtr[i,i] + sum;
    return sum;
}

int[,] CreateMTR(int m, int n)
{
    Random rnd = new Random();
    int[,] mtr = new int [m,n];
    for (int i=0; i<mtr.GetLength(0); i++)
        for (int j=0; j<mtr.GetLength(1); j++)
            mtr[i,j] = rnd.Next(10);
        return mtr;
}

void PrintMTR(int[,] mtr)
{
    for (int i=0; i<mtr.GetLength(0); i++, Console.WriteLine())
        for (int j=0; j<mtr.GetLength(1); j++)
            Console.Write($"{mtr[i,j]} ");
}

int m = ReadInt("ВВедите m: ");
int n = ReadInt("ВВедите n: ");
int[,] mtr = CreateMTR(m,n);
Console.WriteLine("Выводим матрицу");
PrintMTR(mtr);
Console.Write("Выводим сумму элементов главной диагонали ");
Console.WriteLine(SumMTR(mtr));