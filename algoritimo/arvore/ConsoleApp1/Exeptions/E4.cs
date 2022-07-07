namespace ConsoleApp1.Exeptions;

public class E4 : Exception
{
    /// <summary>
    /// Erro lançado quando houver qualquer outro não tratado previamente
    /// </summary>
    public E4()
    :base("E4: Qualquer outro erro")
    {
            
    }

    public E4(string message)
        : base("E4: Qualquer outro erro: "+message)
    {

    }

    public E4(Exception inner)
    :base("E4: Qualquer outro erro", inner)
    {
        
    }
}