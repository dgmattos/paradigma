using ConsoleApp1.BLL;
using ConsoleApp1.Exeptions;

try
{
    char[,] exemplo = { { 'B', 'D' }, { 'D', 'E' }, { 'A', 'B' }, { 'E', 'G' }, { 'A', 'C' }, { 'C', 'F' } }; // OK
    
    Arvore arvore = new Arvore();

    string result = arvore.resolver(exemplo);

    Console.WriteLine("Resultado: {0}", result);
}
catch (Exception ex)
{
    Console.WriteLine("E4: {0}", ex.Message);
}