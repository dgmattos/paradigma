using System.Runtime.CompilerServices;
using ConsoleApp1.BLL;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TESTE_EX1()
        {
            char[,] exemplo = { { 'A', 'B' }, { 'A', 'C' }, { 'B', 'G' }, { 'C', 'H' }, { 'B', 'D' }, { 'C', 'E' }, { 'E', 'F' } }; // OK

            Arvore arvore = new Arvore();

            string result = arvore.resolver(exemplo);

            Assert.AreEqual("[A[B[G][D]][C[H][E[F]]]]", result);
        }

        [Test]
        public void TESTE_EX2()
        {
            /*
             * O exemplo a cima gera a exeção de indice inexistente, uma vez que o C só será adicionado no final da lista.
                Uma opção para resolver esse problema seria presuimir que se o índice não existe ele é filho do primeiro nó disponível, porém como estrutura de arvore mencionada no exemplo trabalha com pares, entendo que o fato do indice C ainda não existir como filho deve ser interpretado como erro.
             */
            char[,] exemplo = { { 'B', 'D' }, { 'D', 'E' }, { 'A', 'B' }, { 'C', 'F' }, { 'E', 'G' }, { 'A', 'C' } }; // OK

            Arvore arvore = new Arvore();

            string result = arvore.resolver(exemplo);

            Assert.AreEqual("[A[B[D[E[G]]]][C[F]]]", result);
        }

        public void TESTE_EX2_CORRIGIDO()
        {
            /*
             * O exemplo a cima gera a exeção de indice inexistente, uma vez que o C só será adicionado no final da lista.
                Uma opção para resolver esse problema seria presuimir que se o índice não existe ele é filho do primeiro nó disponível, porém como estrutura de arvore mencionada no exemplo trabalha com pares, entendo que o fato do indice C ainda não existir como filho deve ser interpretado como erro.
             */
            char[,] exemplo = { { 'B', 'D' }, { 'D', 'E' }, { 'A', 'B' }, { 'E', 'G' }, { 'A', 'C' }, { 'C', 'F' } }; // OK

            Arvore arvore = new Arvore();

            string result = arvore.resolver(exemplo);

            Assert.AreEqual("[A[B[D[E[G]]]][C[F]]]", result);
        }

        [Test]
        public void TESTE_E1()
        {
            char[,] exemplo = { { 'A', 'B' }, { 'A', 'C' }, { 'A', 'Z' }, { 'B', 'G' }, { 'C', 'H' }, { 'B', 'D' }, { 'C', 'E' }, { 'E', 'F' } }; // OK

            Arvore arvore = new Arvore();

            string result = arvore.resolver(exemplo);

            Assert.AreEqual("E1: Mais de 2 filhos", result);
        }

        [Test]
        public void TESTE_E2()
        {
            char[,] exemplo = { { 'A', 'B' }, { 'A', 'C' }, { 'C', 'A' } }; // OK

            Arvore arvore = new Arvore();

            string result = arvore.resolver(exemplo);

            Assert.AreEqual("E2: Ciclo presente", result);
        }

        [Test]
        public void TESTE_E3()
        {
            char[,] exemplo = { { 'A', 'B' }, { 'A', 'C' }, { 'B', 'D' }, { 'D', 'C' } }; // OK

            Arvore arvore = new Arvore();

            string result = arvore.resolver(exemplo);

            Assert.AreEqual("E3: Raízes múltiplas", result);
        }

        [Test]
        public void TESTE_E4()
        {
            char[,] exemplo = { }; // OK

            Arvore arvore = new Arvore();

            string result = arvore.resolver(exemplo);

            bool e4id = result.Contains("E4:");

            Assert.IsTrue(e4id);
        }
    }
}