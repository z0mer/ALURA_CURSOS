Album albumQueen = new Album();
albumQueen.Nome = "A night at the opera";

Musica musica1 = new Musica();
musica1.NomeMusica = "Love of my life";

Musica musica2 = new Musica();
musica2.NomeMusica = "Bohemian Rhapsody";

albumQueen.AdicionarMusica(musica1);
albumQueen.AdicionarMusica(musica2);
albumQueen.ExibirMusica();
