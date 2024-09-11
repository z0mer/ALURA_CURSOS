using System.Collections.Concurrent;

class Album
{
    //O campo privado significa que essa variável só está disponível dentro das chaves que compõem a declaração da classe Album
    private List<Musica> musicas = new List<Musica>();

    public string Nome { get; set; }
    public int DuracaoTotal { get; set; }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusica()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}.\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.NomeMusica}");
        }
    }
}
