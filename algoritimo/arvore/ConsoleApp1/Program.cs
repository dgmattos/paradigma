using ConsoleApp1.BLL;
using ConsoleApp1.Exeptions;

try
{
    
    char[,] exemplo = {}; // OK
    
    Arvore arvore = new Arvore();

    string result = arvore.resolver(exemplo);

    Console.WriteLine("Resultado: {0}", result);
}
catch (Exception ex)
{
    Console.WriteLine("E4: {0}", ex.Message);
}