public class Matriz : AlgebraLinear
{
    public int Linhas { get; }
    public int Colunas { get; }
    public double[,] Elementos { get; set; }

    public Matriz(int linhas, int colunas)
    {
        this.Linhas = linhas;
        this.Colunas = colunas;
        this.Elementos = new double[linhas,colunas];   
    }

    public void setValorMatriz(int linhas, int colunas, double valor)
    {
        Elementos.SetValue(valor, linhas, colunas);
    }

    public double getValorMatriz(int linhas, int colunas) 
    {
        return (double)Elementos.GetValue(linhas, colunas);
    }

    public static void mostrarMatriz(double[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz.GetValue(i,j));
                Console.Write(" ");
            }
            Console.WriteLine("");
        }
    }
}


