public class Vetor
{
    public int Dimensao { get; set; }
    public int[,] Elementos { get; set; }
    public Vetor(int dimensao, int[] elementos)
    {
        this.Dimensao = dimensao;
        this.Elementos = new int[dimensao,1];
        for (int i = 0; i < elementos.Length; i++) 
        {
            this.Elementos[i,0] = elementos[i];
        }
    }

    public int getValor(int i) 
    {
        return Elementos[i, 0];
    }

    public void setValor(int i, int value)
    {
        Elementos[i, 0] = value;
    }
}

