class Musica
{
    public string NomeMusica {  get; set; }
    public string ArtistaMusica { get; set; }
    public int DuracaoMusica { get; set; }
    //letra de começo do atributo maiúscula pq é uma propriedade
    public bool DisponivelMusica {  get; set; }
    public string ResumoC =>
        $"A música {NomeMusica} pertence ao artista {ArtistaMusica}";

    public void FichaTecnica()
    {
        Console.WriteLine($"Música: {NomeMusica}");
        Console.WriteLine($"Artista: {ArtistaMusica}");
        Console.WriteLine($"Duração: {DuracaoMusica}");
        if (DisponivelMusica)
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

