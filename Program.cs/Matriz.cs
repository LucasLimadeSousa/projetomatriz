public class Matriz
{
    private int Linhas { get; set; }
    private int Colunas { get; set; }
    public Array Elementos { get; set; }

    public Matriz(int linhas, int colunas)
    {
        Linhas = linhas;
        Colunas = colunas;
        Elementos = new int[linhas, colunas];
    }

    public void setValorMatriz(int linhas, int colunas, int valor)
    {
        Elementos.SetValue(valor, linhas, colunas);
    }

    public int getValorMatriz(int linhas, int colunas) 
    {
        return (int)Elementos.GetValue(linhas, colunas);
    }

    public void mostrarMatriz()
    {
        for (int i = 0; i < Linhas; i++)
        {
            for (int j = 0; j < Colunas; j++)
            {
                Console.Write(Elementos.GetValue(i, j));
                Console.Write(" ");
            }
            Console.WriteLine("");
        }
    }
}


