class Musica
{
    //Um construtor é um método especial que é executado no momento da criação do objeto.
    public Musica(Banda artista, string nomeMusica)
    {
        ArtistaMusica = artista;
        NomeMusica = nomeMusica;
    }
    public string NomeMusica {  get; }
    //o artista não é mais um texto (string), é a própria Banda, ou seja, a própria classe.
    public Banda ArtistaMusica { get; }
    public int DuracaoMusica { get; set; }
    //letra de começo do atributo maiúscula pq é uma propriedade
    public bool DisponivelMusica {  get; set; }
    public string ResumoC =>
        $"A música {NomeMusica} pertence ao artista {ArtistaMusica}";

    public void FichaTecnica()
    {
        Console.WriteLine($"Música: {NomeMusica}");
        Console.WriteLine($"Artista: {ArtistaMusica.Nome}");
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

