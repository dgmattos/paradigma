namespace ConsoleApp1.Exeptions;

public class E4 : Exception
{

    public E4()
    :base("E4: Qualquer outro erro")
    {
            
    }

    public E4(Exception inner)
    :base("E4: Qualquer outro erro", inner)
    {
        
    }
}