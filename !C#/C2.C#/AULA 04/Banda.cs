class Banda
{
    private List<Album> albums = new List<Album>();
    //Ao digitar ctor e apertar "Tab", o Visual Studo gera o modelo de um construtor.
    public Banda(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }
    public void ExibirDiscografia()
    {
        Console.WriteLine($"\nDiscografia da banda {Nome}\n");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}
