class Musica
{
    public string nomeMusica;
    public string artistaMusica;
    public int duracaoMusica;
    public bool disponivelMusica;

    public void FichaTecnica()
    {
        Console.WriteLine($"Música: {nomeMusica}");
        Console.WriteLine($"Artista: {artistaMusica}");
        Console.WriteLine($"Duração: {duracaoMusica}");
        if (disponivelMusica)
        {
            Console.WriteLine("Disponível no plano");
        }
        else
        {
            Console.WriteLine("Indisponível no plano atual, adquira o plano Plus+");
        }
        Console.WriteLine(" ");
    }
}

