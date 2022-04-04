//Bonus stampa info libro.

//Dichiaro nelle variabili i valori degli elementi che mi servono ed effettuo le conversioni
Console.WriteLine("Inserire titolo libro");
string titoloLibro = Console.ReadLine();
    Console.Clear();

Console.WriteLine("Inserire nome autore");
string nomeAutore = Console.ReadLine();
    Console.Clear();

Console.WriteLine("Inserire isbn libro");
string isbnLibro = Console.ReadLine();
long isbn = Int64.Parse(isbnLibro);
    Console.Clear();

Console.WriteLine("Inserire numero di pagine");
string numeroPagineLibro = Console.ReadLine(); //int
int numeroPagine = int.Parse(numeroPagineLibro);
    Console.Clear();

Console.WriteLine("Inserire peso libro");
string pesoLibro = Console.ReadLine();
float peso = float.Parse(pesoLibro);
    Console.Clear();

Console.WriteLine("Inserire larghezza libro");
string larghezzaLibro = Console.ReadLine(); //double 
float larghezza = float.Parse(larghezzaLibro);
    Console.Clear();

Console.WriteLine("Inserire lunghezza libro");
string lunghezzaLibro = Console.ReadLine();
float lunghezza = float.Parse(lunghezzaLibro);
    Console.Clear();

Console.WriteLine("Inserire profondità libro");
string profonditàLibro = Console.ReadLine();
float profondità = float.Parse(profonditàLibro);
    Console.Clear();

Console.WriteLine("Inserire numero di recensioni");
string numeroDiRecensioni = Console.ReadLine();
int recensioni = int.Parse(numeroDiRecensioni);
    Console.Clear();

Console.WriteLine("Inserire valutazione media libro");
string valutazioneMediaLibro = Console.ReadLine();
float valutazioneMedia = float.Parse(valutazioneMediaLibro);
    Console.Clear();


//corpo da stampare
Console.WriteLine("--- IL LIBRO DI OGGI: " + titoloLibro + " di " + nomeAutore + " ---");
Console.WriteLine(Environment.NewLine);

//informazioni generali
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Informazioni generiche");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("ISBN: " + isbn);
Console.WriteLine("Numero delle pagine: " + numeroPagine);
Console.WriteLine("Peso Libro: " + peso + " Kg");
Console.WriteLine("Dimensioni del libro: " + larghezza + " cm x " + lunghezza + " cm x " + profondità + " cm");
Console.WriteLine(Environment.NewLine);

//Informazioni Amazon
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Informazioni Amazon");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Numero di recensioni: " + recensioni + " recensioni");
Console.WriteLine("Valutazione media: " + valutazioneMedia + " stelline");
Console.WriteLine("Kindle disponibile: Si");
Console.WriteLine("Copertina flessibile disponibile: Si");



Console.WriteLine(Environment.NewLine);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Premi INVIO per uscire dal programma.");

Console.ReadKey(); 