internal class Labubu
{
    public string SkinName { get; set; }
    public string Producao { get; set; }
    private int ano = 1900;

    public int Ano
    {
        get { return ano; }
        set
        {
            if (value >= 1900 && value <= DateTime.Now.Year)
            {
                ano = value;
            }
            else
            {
                Console.WriteLine("Ano Invalido.");
            }
        }
    }
}