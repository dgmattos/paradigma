namespace ConsoleApp1.Exeptions;

public class E3 : Exception
{
    public E3()
    :base("E3: Raízes múltiplas")
    {
            
    }
    
    public E3(Exception inner)
        :base("E3: Raízes múltiplas", inner)
    {
        
    }
}