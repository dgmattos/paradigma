namespace ConsoleApp1.Exeptions;

public class E2 : Exception
{
    /// <summary>
    /// Erro lançado para referência1 circular de pai e filho
    /// </summary>
    public E2()
    : base("E2: Ciclo presente")
    {

    }

    public E2(Exception inner)
        : base("E2: Ciclo presente", inner)
    {

    }
}