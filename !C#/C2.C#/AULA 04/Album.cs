using System.Collections.Concurrent;

class Album
{
    //O campo privado significa que essa variável só está disponível dentro das chaves que compõem a declaração da classe Album
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    //No método Sum(), vamos representar cada música como m, adicionar uma arrow function logo depois, e por fim escrever m.Duracao,
    //indicando que para cada música queremos somar a duração.
    public int DuracaoTotal => musicas.Sum(m => m.DuracaoMusica);

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
        Console.WriteLine($"\nPara ouvir este álbum inteiro, você precisa de {DuracaoTotal}");
    }
}
