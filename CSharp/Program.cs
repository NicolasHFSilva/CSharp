using System;
using Primeiro; //Primeiro modo de Referênciar é chamando o namespace pelo 'using'.
using CSharp;
using Interface; //Queremos usar a Interfácie 'IAnimal'
using Enum;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var classe = new Classe();
            var classe2 = new Segundo.Classe(); //Segundo modo de referenciar a classe, colocando o namespace Segundo.

            //tipo explicito de variável || nome do objeto || = || new || classe Pessoa  
            Pessoa person = new Pessoa();
            person.Nome = "Nicolas";
            person.Sobrenome = "Henrique";
            person.Idade = 26;

            //tipo implícito de variável || nome do objeto || = || new || classe Pessoa
            var person2 = new Pessoa();
            person2.Nome = "Jhenifer";
            person2.Sobrenome = "Cristine";
            person2.Idade = 25;

            //Precisamos usar o método explicito para a classe Animal da interfácie IAnimal
            Animal animal = new Animal();
            animal.Nome = "Ticoliro";
            animal.Dono = "Little's";
            animal.Especie = "Rato";

            var pessoa1 = (Pessoas)0;//pessoa1 vai conter Nícolas que é índice 0
            Pessoas pessoa2 = Pessoas.Rogérinho;//pessoa2 vai conter Rogérinho, sem ter a necessidade do índice.
            Pessoas pessoa3 = (Pessoas)4; //pessoa2 vai conter Pichuléco, que é o índice 4.

            Console.WriteLine("Nome: " + person2.Nome + "\n" + 
                              "Sobrenome: " + person2.Sobrenome + "\n" +
                              "Idade: " + person2.Idade);
            Console.WriteLine("\nNome: " + animal.Nome + "\n" +
                              "Dono: " + animal.Dono + "\n" +
                              "Espécie: " + animal.Especie);
            Console.WriteLine(pessoa3);

        }
    }
}