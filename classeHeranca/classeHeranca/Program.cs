using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeHeranca
{
    // classe base
    internal class Animal
    {
        public string Nome { get; set; }

        // construtor
        public Animal(string nome)
        {
            Nome = nome;
        }

        public virtual void EmitirSom()
        {
            Console.WriteLine("O animal emite um som.");
        }
    }

    // classe derivada
    internal class Cachorro : Animal
    {
        public Cachorro(string nome) : base(nome) { }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} late: AU AU!");
        }
    }

    // outra classe derivada
    internal class Gato : Animal
    {
        public Gato(string nome) : base(nome) { }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} mia: MIAU!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // criando instancias das classes derivadas
            Animal meuCachorro = new Cachorro("Renato Cariani");
            Animal meuGato = new Gato("Leblon James");

            // chamando metodo EmitirSom para cada animal
            meuCachorro.EmitirSom();
            meuGato.EmitirSom();

            // utilizando polimorfismo: array de animais
            Animal[] animais = { meuCachorro, meuGato };
            foreach (var animal in animais)
            {
                animal.EmitirSom();
            }
        }
    }
}