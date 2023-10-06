// See https://aka.ms/new-console-template for more information
using ConsoleAppEnuma;

Console.WriteLine("Hello, World!");

MusicCollection collection = new MusicCollection();


//IF object collection doesn't implement Ienumrable, foreach loop cant be used (therefore array, list, etc inherits from this class)
foreach (var album in collection)
{
    //filteringis occuring with this loop

    //if (!Char.IsUpper(album.Name[0])) 
    //{
    //    Console.WriteLine(@"the album: {0}, is lowercase.", album.Name);
    //}

    //if (album.Name.Length <= 8)
    //{
    //    Console.WriteLine(@"the album: {0}, has shortest title.", album.Name);
    //}

    //Filtering is occuring in the enumarable 
    Console.WriteLine(album.Name);
}