namespace ConsoleApp1.Exeptions;

public class E2 : Exception
{
    public E2()
    :base("E2: Ciclo presente")
    {
        
    }
    
    public E2(Exception inner)
        :base("E2: Ciclo presente", inner)
    {
        
    }
}