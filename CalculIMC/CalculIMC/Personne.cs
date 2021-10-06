using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculIMC
{
    class Personne
    {
        private string name;
        public string Name { get => name; set => name = value; }

        private int age;
        public int Age { get { return age; } set { age = value; } }

        public Personne()
        {
            Console.WriteLine("Nouvelle personne créée avec les valeurs par défaut.");
        }

        public Personne(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("Nouvelle personne créée avec les valeurs par défaut. Elle s'appelle " + this.name + " et a " + this.age + " ans.");
        }

        ~Personne()
        {
            Console.WriteLine("Objet Personne détruit.");
        }

        //public void SayHi()
        //{
        //    Console.WriteLine("Bonjour ! Je m'appelle " + this.name + " et j'ai " + this.age + " ans.");
        //}
    }
}
