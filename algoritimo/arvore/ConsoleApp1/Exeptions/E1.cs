namespace ConsoleApp1.Exeptions;

public class E1 : Exception
{
    public E1()
    :base("E1: Mais de 2 filhos")
    {
            
    }
    
    public E1(Exception inner)
        :base("E1: Mais de 2 filhos", inner)
    {
        
    }
}