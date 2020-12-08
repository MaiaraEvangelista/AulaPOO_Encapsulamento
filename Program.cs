using System;
using Encapsulamento.classes;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            master m = new master();

            m.RegistrarCompra(true);

            m.ReceberNome("Maiara Evangelista de Souza");

            m.exibirNome();
            m.exibirLimite();

          m.Numero = "16254431";
          Console.WriteLine(m.Numero);
        }
    }
}
