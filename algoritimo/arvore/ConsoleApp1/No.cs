using System.Reflection.Metadata.Ecma335;
using ConsoleApp1.Exeptions;

namespace ConsoleApp1;

public class No
{
    public char? chave { get; set; }

    public No? esquerda { get; set; }

    public No? direita { get; set; }

    public No()
    {
        this.chave = null;
    }

    public No(char dado)
    {
        this.chave = dado;
        this.init_filhos();
    }

    private void init_filhos()
    {
        this.esquerda = new No();
        this.direita = new No();
    }

    public No Adiciona(char pai, char filho)
    {
        if (filho == this.chave)
        {
            throw new E2();
        }
        
        if (pai == this.chave)
        {
            return this._adicionar(filho);
        }
        else
        {
            return this._adiciona_filho(pai, filho);
        }
    }

    private No _adiciona_filho(char pai, char filho)
    {
        try
        {
            if (filho == this.esquerda.chave || filho == this.direita.chave)
            {
                throw new E2();
            }
            
            if (this.esquerda.chave == pai)
            {
                return this.esquerda.Adiciona(pai, filho);
            }
            else if (this.direita.chave == pai)
            {
                return this.direita.Adiciona(pai, filho);
            }
            else if (this.esquerda._eFilho(pai))
            {
                return this.esquerda._adiciona_filho(pai, filho);
            }
            else if (this.direita._eFilho(pai))
            {
                return this.direita._adiciona_filho(pai, filho);
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

    private bool _eFilho(char pai)
    {
        if (this.esquerda == null && this.direita == null)
        {
            return false;
        }
        
        if (this.esquerda.chave == pai || this.direita.chave == pai)
        {
            return true;
        }
        else
        {
            if (this.esquerda != null)
            {
                return this.esquerda._eFilho(pai);
            }
            else if (this.direita != null)
            {
                return this.direita._eFilho(pai);
            }

            return false;
        }
    }

    private No _adicionar(char filho)
    {
        try
        {
            
            if (this.esquerda.chave == null)
            {
                return this.esquerda = new No(filho);
            }
            else if (this.direita.chave == null)
            {
                return this.direita = new No(filho);
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

    public string toString()
    {
        try
        {
            string str = "[";
        
            if (this.chave != null)
            {
                str += this.chave;
            }

            if (this.esquerda.chave != null)
            {
                str += this.esquerda.toString();
            }
        
            if (this.direita.chave != null)
            {
                str += this.direita.toString();
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