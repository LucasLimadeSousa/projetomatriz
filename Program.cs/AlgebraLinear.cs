using System.Numerics;
using System.Runtime.Serialization.Formatters;

public class AlgebraLinear
{
    public static int[,] transpose(int[,] matriz) 
    {
        int [,] result = new int[matriz.GetLength(1),matriz.GetLength(0)];
        for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
        {
            for(int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                result[coluna,linha] = matriz[linha,coluna];
            }
        }
        return result;
    }

    public static int[,] sum(int[,] matriz, int[,] matriz2) 
    {
        if (matriz.GetLength(0) == matriz2.GetLength(0) && matriz.GetLength(1) == matriz2.GetLength(1))
        {
            int[,] soma = new int[matriz.GetLength(0), matriz.GetLength(1)];
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

    public static int[,] times(int num, int[,] matriz)
    {
        int [,] result = new int[matriz.GetLength(0),matriz.GetLength(1)];
        for(int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for( int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                result[linha, coluna] = matriz[linha, coluna] * num;
            }
        }
        return result;
    }

    public static int[,] dot(int[,] matriz, int[,] matriz2) 
    {
        if(matriz.GetLength(1) == matriz2.GetLength(0))
        {
            int[,] matrizResultante = new int[matriz.GetLength(0),matriz2.GetLength(1)];
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

    public static int[,] gauss(int[,] a)
    {
        int[,] b = new int[a.GetLength(0),a.GetLength(1)];
        for (int cont = 0; cont < a.GetLength(1); cont++)
        {
            b[0,cont] = a[0,cont];
        }
        for(int i = 1; i < a.GetLength(0); i++) 
        {
            int f = a[i,0] / a[0,0];
            for(int j = 0; j < a.GetLength(1); j++) 
            {
                b[i,j] = a[i,j] - a[0,j] * f ;
            }
        }
        return b;
    }
}

