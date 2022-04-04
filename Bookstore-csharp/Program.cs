//esercizio stampa info libro.

//titolo

//Dichiaro nelle variabili i valori degli elementi che mi servono
{ 

    string titoloLibro = "Clean Code";
    string nomeAutore = "Robert C. Martin";
    long isbnLibro = 9780132350884;
    int numeroPagineLibro = 431;
    double pesoLibro = 0.66;
    double larghezzaLibro = 17.91;
    double lunghezzaLibro = 2.54;
    double profonditàLibro = 23.5;

    Console.ForegroundColor = ConsoleColor.Red;

//Corpo Da stampare
    Console.WriteLine("--- IL LIBRO DI OGGI: " + titoloLibro + " di " + nomeAutore + " ---");
    Console.WriteLine(Environment.NewLine);
    //informazioni generali
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Informazioni generiche");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("ISBN: " + isbnLibro);
    Console.WriteLine("Numero delle pagine: " + numeroPagineLibro);
    Console.WriteLine("Peso Libro: " + pesoLibro + " Kg");
    Console.WriteLine("Dimensioni del libro: " + larghezzaLibro + " cm x " + lunghezzaLibro + " cm x " + profonditàLibro + " cm");
    Console.WriteLine(Environment.NewLine);
}

//Informazioni Amazon

{

    //Dichiaro nelle variabili le informazioni di amazon
    int numeroDiRecensioni = 3308;
    double valutazioneMediaLibro = 4.5;

}