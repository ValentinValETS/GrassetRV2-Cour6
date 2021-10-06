using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicATM
{
    class Program
    {
        static void Main(string[] args)
        {
            char suivant;
            Console.WriteLine("Veuillez entrer votre nom.");
            BankAccount account = new BankAccount(Console.ReadLine(), 10000);
            do
            {                
                int num;
                Console.WriteLine("Bonjour " + account.Nom + " veuillez choisir une opération à effectuer");
                Console.WriteLine("\nEntrer 1 pour déposer un montant. \nEntrer 2 pour retirer un montant. \nEntrer 3 pour consulter le montant disponible.");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Entrer un montant à déposer:");
                        double deposit = Convert.ToDouble(Console.ReadLine());
                        account.Deposit(deposit);
                        break;
                    case 2:
                        Console.WriteLine("Entrer un montant à retirer :");
                        double withdraw = Convert.ToDouble(Console.ReadLine());
                        account.Withdraw(withdraw);
                        break;
                    case 3:
                        Console.WriteLine("Le compte de " + account.Nom + " contient un montant égal à " + account.Balance + "$.");
                        break;
                    default:
                        Console.WriteLine("Action non valide");
                        break;
                }
                Console.WriteLine("\nVoulez-vous effectuer une autre opération ? (o/n)");
                suivant = Convert.ToChar(Console.ReadLine());

            } while (suivant == 'o');

            Console.ReadKey();
        }
    }

   

}
