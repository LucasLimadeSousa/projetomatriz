public class Vetor : AlgebraLinear
{
    public int Dimensao { get; set; }
    public double[,] Elementos { get; set; }
    public Vetor(int dimensao, int[] elementos)
    {
        this.Dimensao = dimensao;
        this.Elementos = new double[dimensao,1];
        for (int i = 0; i < elementos.Length; i++) 
        {
            this.Elementos[i,0] = elementos[i];
        }
    }

    public double getValor(int i) 
    {
        return Elementos[i, 0];
    }

    public void setValor(int i, double value)
    {
        Elementos[i, 0] = value;
    }

    public static void mostrarVetor(double[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz.GetValue(i, j));
                Console.Write(" ");
            }
            Console.WriteLine("");
        }
    }
}

