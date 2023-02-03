//Показать двумерный массив размером m×n заполненный вещественными числами

int ReadInt(string str)
{
    Console.Write(str);
    return int.Parse(Console.ReadLine()!);
}

double[,] CreateMTR(int m, int n)
{
    Random rnd = new Random();
    double[,] mtr = new double [m,n];
    for (int i=0; i<mtr.GetLength(0); i++)
        for (int j=0; j<mtr.GetLength(1); j++)
            mtr[i,j] = rnd.NextDouble()*100;
        return mtr;
}

void PrintMTR(double[,] mtr)
{
    for (int i=0; i<mtr.GetLength(0); i++, Console.WriteLine())
        for (int j=0; j<mtr.GetLength(1); j++)
            Console.Write("{0:0.00} ", mtr[i,j]);
}

int m = ReadInt("ВВедите m: ");
int n = ReadInt("ВВедите n: ");
double[,] mtr = CreateMTR(m,n);
Console.WriteLine("Выводим матрицу");
PrintMTR(mtr);