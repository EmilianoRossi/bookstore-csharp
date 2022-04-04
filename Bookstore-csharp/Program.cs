//esercizio stampa info libro.

//primo blocco di info
{
//Dichiaro nelle variabili i valori degli elementi che mi servono

    string titoloLibro = "Clean Code";
    string nomeAutore = "Robert C. Martin";
    long isbnLibro = 9780132350884;
    int numeroPagineLibro = 431;
    float pesoLibro = 0.66F;
    float larghezzaLibro = 17.91F;
    float lunghezzaLibro = 2.54F;
    float profonditàLibro = 23.5F;

    Console.ForegroundColor = ConsoleColor.Red;

//Corpo Da stampare
    Console.WriteLine("--- IL LIBRO DI OGGI: " + titoloLibro + " di " + nomeAutore + " ---");
    Console.WriteLine(Environment.NewLine);

//informazioni generali
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Informazioni generiche");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("ISBN: " + isbnLibro);
    Console.WriteLine("Numero delle pagine: " + numeroPagineLibro);
    Console.WriteLine("Peso Libro: " + pesoLibro + " Kg");
    Console.WriteLine("Dimensioni del libro: " + larghezzaLibro + " cm x " + lunghezzaLibro + " cm x " + profonditàLibro + " cm");
    Console.WriteLine(Environment.NewLine);
}

//secondo blocco di info

{

//Dichiaro nelle variabili le informazioni di amazon

    int numeroDiRecensioni = 3308;
    float valutazioneMediaLibro = 4.5F;

    //corpo da stampare

//Informazioni Amazon
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Informazioni Amazon");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Numero di recensioni: " + numeroDiRecensioni + " recensioni");
    Console.WriteLine("Valutazione media: " + valutazioneMediaLibro + " stelline");
    Console.WriteLine("Kindle disponibile: Si");
    Console.WriteLine("Copertina flessibile disponibile: Si");
    
}
Console.WriteLine(Environment.NewLine);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Premi INVIO per uscire dal programma.");

Console.ReadKey();