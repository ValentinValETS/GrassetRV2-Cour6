using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicATM
{
    class BankAccount
    {
        private double balance = 0;
        private string nom = "";
        public double Balance { get => balance; set => balance = value; }
        public string Nom { get => nom; set => nom = value; }


        public BankAccount(string nom, int initialBalance)
        {
            this.nom = nom;
            this.balance = initialBalance;
        }

        public void Deposit(double deposit)
        {
            this.balance += deposit;
            Console.WriteLine("------------------------------\n");
            Console.WriteLine("Fonds disponibles dans ce compte : " + this.balance);

        }
        public void Withdraw(double withdraw)
        {
            if (withdraw <= this.balance)
            {
                this.balance -= withdraw;
                Console.WriteLine("------------------------------\n");
                Console.WriteLine("Fonds disponibles dans le compte : " + this.balance);
            }
            else
                Console.WriteLine("\n\nImpossible de retirer ce montant, fonds insuffisants pour ce compte (" + this.balance + ").");
        }
    }
}
