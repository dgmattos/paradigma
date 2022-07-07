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
        public void TESTE_OK()
        {
            char[,] exemplo = { { 'A', 'B' }, { 'A', 'C' }, { 'B', 'G' }, { 'C', 'H' }, { 'B', 'D' }, { 'C', 'E' }, { 'E', 'F' } }; // OK

            Arvore arvore = new Arvore();

            string result = arvore.resolver(exemplo);

            Assert.AreEqual("[A[B[G][D]][C[H][E[F]]]]", result);
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
            //[A,B] [A,C] [B,D] [D,C]
            char[,] exemplo = { { 'A', 'B' }, { 'A', 'C' }, { 'B', 'D' }, { 'D', 'C' } }; // OK

            Arvore arvore = new Arvore();

            string result = arvore.resolver(exemplo);

            Assert.AreEqual("E3: Raízes múltiplas", result);
        }

        [Test]
        public void TESTE_E4()
        {
            char[,] exemplo = {  }; // OK

            Arvore arvore = new Arvore();

            string result = arvore.resolver(exemplo);

            bool e4id = result.Contains("E4:");

            Assert.IsTrue(e4id);
        }
    }
}