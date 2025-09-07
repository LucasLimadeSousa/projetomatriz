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
            return matriz;
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
}

