Banda queen = new Banda("Queen");

Album albumQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    DuracaoMusica = 213,
    DisponivelMusica = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    DuracaoMusica = 354,
    DisponivelMusica = false,
};

albumQueen.AdicionarMusica(musica1);
albumQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumQueen);
musica1.FichaTecnica();
musica2.FichaTecnica();
albumQueen.ExibirMusica();
queen.ExibirDiscografia();
