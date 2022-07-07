namespace ConsoleApp1.Exeptions;

public class E3 : Exception
{
    /// <summary>
    /// Erro lançado quando houver mais de um nó inicial
    /// </summary>
    public E3()
    : base("E3: Raízes múltiplas")
    {

    }

    public E3(Exception inner)
        : base("E3: Raízes múltiplas", inner)
    {

    }
}