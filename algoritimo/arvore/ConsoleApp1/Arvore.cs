using ConsoleApp1.Exeptions;

namespace ConsoleApp1;

public class Arvore
{
    private No raiz { get; set; }

    public string erro { get; set; }

    public Arvore()
    {
        
    }

    public string resolver(char[,] itens)
    {
        try
        {
            try
            {
                raiz = new No();

                this._resolver(itens);
            }
            catch (Exception ex)
            {
                this.erro = ex.Message;
            }

            if (!string.IsNullOrEmpty(this.erro))
            {
                throw new Exception(this.erro);
            }

            string res = this.raiz.toString();

            return res;
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }

    private void _resolver(char[,] itens)
    {
        try
        {
           
            int linhas = itens.Length / 2;
            
            for (int i = 0; i < linhas; i++)
            {
                char itemPai = itens[i, 0];
                char itemFilho = itens[i, 1];
                ;

                if (raiz.chave == null)
                {
                    raiz = new No(itemPai);
                    raiz.Adiciona(itemPai, itemFilho);
                }
                else
                {
                    raiz.Adiciona(itemPai, itemFilho);
                }
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public string toString()
    {
        try
        {
            if (!string.IsNullOrEmpty(this.erro))
            {
                return erro;
            }

            return raiz.toString();
        }
        catch (Exception e)
        {
            throw new E4(e);
        }
    }
}