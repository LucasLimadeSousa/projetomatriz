using System.Numerics;
using System.Runtime.Serialization.Formatters;

public class AlgebraLinear
{
    public static double[,] transpose(int[,] matriz) 
    {
        double[,] result = new double[matriz.GetLength(1),matriz.GetLength(0)];
        for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
        {
            for(int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                result[coluna,linha] = matriz[linha,coluna];
            }
        }
        return result;
    }

    public static double[,] sum(double[,] matriz, double[,] matriz2) 
    {
        if (matriz.GetLength(0) == matriz2.GetLength(0) && matriz.GetLength(1) == matriz2.GetLength(1))
        {
            double[,] soma = new double[matriz.GetLength(0), matriz.GetLength(1)];
            for (int linha = 0; linha < matriz2.GetLength(0); linha++) 
            {
                for(int coluna = 0; coluna < matriz2.GetLength(1); coluna++) 
                {
                    soma[linha,coluna] = matriz[linha, coluna] + matriz2[linha, coluna];
                }
            }
            return soma;
        }
        else 
        {
            Console.WriteLine("IMPOSSIVEL FAZER A SOMA DA MATRIZ");
            return null;
        }
    }

    public static double[,] times(int num, double[,] matriz)
    {
        double[,] result = new double[matriz.GetLength(0), matriz.GetLength(1)];
        for(int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for( int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                result[linha, coluna] = matriz[linha, coluna] * num;
            }
        }
        return result;
    }

    public static double[,] dot(double[,] matriz, double[,] matriz2) 
    {
        if(matriz.GetLength(1) == matriz2.GetLength(0))
        {
            double[,] matrizResultante = new double[matriz.GetLength(0), matriz2.GetLength(1)];
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz2.GetLength(1); coluna++)
                {
                    matrizResultante[linha, coluna] = 0;
                    for (int i = 0; i < 2; i++)
                    {
                        matrizResultante[linha,coluna]  += (matriz[linha, i] * matriz2[i, coluna]);
                    }
                    
                }
            }
            return matrizResultante;
        } 
        else
        {
            Console.WriteLine("IMPOSSIVEL REALIZAR A MULTIPLICAÇÃO DAS MATRIZES");
            return null;
        }
    }

    public static double[,] gauss(double[,] a)
    {
        double[,] b = new double[a.GetLength(0), a.GetLength(1)];
        for (int cont = 0; cont < a.GetLength(1); cont++)
        {
            b[0,cont] = a[0,cont];
        }
        for(int i = 1; i < a.GetLength(0); i++) 
        {
            double f = a[i,0] / a[0,0];
            for(int j = 0; j < a.GetLength(1); j++) 
            {
                b[i,j] = a[i,j] - a[0,j] * f ;
            }
        }
        return b;
    }
    public static double[,] solve(double[,] a)
    {
        double[,] b = gauss(a);
        var c = new double[b.GetLength(1) - 1,1];
        if (b.GetLength(1) - 1 != 3) 
        {
            double x, y;
            y = b[1,2] / b[1, 1];
            x = (b[0,2] - b[0,1] * y) / b[0,0];
            c[0,0] = x;
            c[1,0] = y;
            return c;
        } else
        {
            double x, y,z;
            z = b[2, 3] / b[2, 2];
            y = (b[1, 3] - b[1, 2] * z) / b[1, 1];  
            x = (b[0, 3] - b[0, 2] * z - b[0,1] * y) / b[0, 0];
            c[0, 0] = x;
            c[1, 0] = y;
            c[2, 0] = z;
            return c;
        }
    }
}

