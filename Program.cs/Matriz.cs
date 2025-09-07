public class Matriz : AlgebraLinear
{
    public int Linhas { get; set; }
    public int Colunas { get; set; }
    public int[,] Elementos { get; set; }

    public Matriz(int linhas, int colunas)
    {
        this.Linhas = linhas;
        this.Colunas = colunas;
        this.Elementos = new int[linhas,colunas];   
    }

    public void setValorMatriz(int linhas, int colunas, int valor)
    {
        Elementos.SetValue(valor, linhas, colunas);
    }

    public int getValorMatriz(int linhas, int colunas) 
    {
        return (int)Elementos.GetValue(linhas, colunas);
    }

    public static void mostrarMatriz(int[,] matriz)
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


