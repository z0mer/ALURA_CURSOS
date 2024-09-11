Musica musica1 = new Musica();
musica1.NomeMusica = "Another Love";
musica1.ArtistaMusica = "Tom Odell";
musica1.DuracaoMusica = 244;
musica1.DisponivelMusica = true;
Console.WriteLine(musica1.ResumoC);

Musica musica2 = new Musica();
musica2.NomeMusica = "Easy On Me";
musica2.ArtistaMusica = "Adele";
musica2.DuracaoMusica = 224;
musica2.DisponivelMusica = false;
Console.WriteLine(musica2.DisponivelMusica);

musica1.FichaTecnica();
musica2.FichaTecnica();
