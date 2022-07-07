using System.Reflection.Metadata.Ecma335;
using ConsoleApp1.Exeptions;

namespace ConsoleApp1.BLL;

public class No
{
    public char? chave { get; set; }

    public No? esquerda { get; set; }

    public No? direita { get; set; }

    public No()
    {
        chave = null;
    }

    public No(char dado)
    {
        chave = dado;
        init_filhos();
    }

    /// <summary>
    /// Inicia os filhos do nó
    /// </summary>
    private void init_filhos()
    {
        esquerda = new No();
        direita = new No();
    }


    /// <summary>
    /// Gerencia a adição do nó
    /// </summary>
    /// <param name="pai"></param>
    /// <param name="filho"></param>
    /// <returns></returns>
    /// <exception cref="E2"></exception>
    public No Adiciona(char pai, char filho)
    {
        if (filho == chave)
        {
            throw new E2();
        }

        if (pai == chave)
        {
            return _adicionar(filho);
        }
        else
        {
            return _adiciona_filho(pai, filho);
        }
    }

    /// <summary>
    /// Adiciona novo nó nas pontas da raiz
    /// </summary>
    /// <param name="pai"></param>
    /// <param name="filho"></param>
    /// <returns></returns>
    /// <exception cref="E2"></exception>
    /// <exception cref="E3"></exception>
    private No _adiciona_filho(char pai, char filho)
    {
        try
        {
            if (filho == esquerda.chave || filho == direita.chave)
            {
                throw new E2();
            }

            if (esquerda.chave == pai)
            {
                return esquerda.Adiciona(pai, filho);
            }
            else if (direita.chave == pai)
            {
                return direita.Adiciona(pai, filho);
            }
            else if (esquerda._eFilho(pai))
            {
                return esquerda._adiciona_filho(pai, filho);
            }
            else if (direita._eFilho(pai))
            {
                return direita._adiciona_filho(pai, filho);
            }
            else
            {
                throw new E3();
            }
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    /// <summary>
    /// Verifica se o registro é um filho
    /// </summary>
    /// <param name="pai"></param>
    /// <returns></returns>
    private bool _eFilho(char pai)
    {
        if (esquerda == null && direita == null)
        {
            return false;
        }

        if (esquerda.chave == pai || direita.chave == pai)
        {
            return true;
        }
        else
        {
            if (esquerda != null)
            {
                return esquerda._eFilho(pai);
            }
            else if (direita != null)
            {
                return direita._eFilho(pai);
            }

            return false;
        }
    }

    /// <summary>
    /// Cria um novo nó
    /// </summary>
    /// <param name="filho"></param>
    /// <returns></returns>
    /// <exception cref="E1"></exception>
    private No _adicionar(char filho)
    {
        try
        {

            if (esquerda.chave == null)
            {
                return esquerda = new No(filho);
            }
            else if (direita.chave == null)
            {
                return direita = new No(filho);
            }
            else
            {
                throw new E1();
            }
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    /// <summary>
    /// Imprime a estrutura
    /// </summary>
    /// <returns></returns>
    /// <exception cref="E4"></exception>
    public string toString()
    {
        try
        {
            string str = "[";

            if (chave != null)
            {
                str += chave;
            }

            if (esquerda.chave != null)
            {
                str += esquerda.toString();
            }

            if (direita.chave != null)
            {
                str += direita.toString();
            }

            str += "]";

            return str;
        }
        catch (Exception e)
        {
            throw new E4(e);
        }
    }
}