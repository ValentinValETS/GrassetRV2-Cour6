using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logiciel de calcul d'Indice de masse corporelle (IMC)");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Veuillez inscrire votre taille en m");

            double taille = 0;

            do
            {
                try
                {
                    taille = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {

                    Console.WriteLine("Échec de la lecture de la taille en m, veuillez corriger votre dernière entrée");
                }
            } while (taille == 0);

            
            Console.WriteLine("Veuillez inscrire votre poids en kg");

            double poids = 0;
            do
            {
                try
                {
                    poids = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {

                    Console.WriteLine("Échec de la lecture du poids en kg, veuillez corriger votre dernière entrée");
                }
            } while (poids == 0);


            double imc = poids/(taille * taille);
            string categorie = "";

            if (imc < 18.5)
            {
                categorie = "Poids insuffisant";
            }
            else if (imc < 24.9)
            {
                categorie = "Poids santé";
            }
            else if (imc < 29.9)
            {
                categorie = "Léger excès de poids";
            }
            else if (imc > 30)
            {
                categorie = "Obésité classe I";
            }
            else
            {
                categorie = "Inconnue";
            }

            Console.WriteLine("Votre est IMC est égal à : "+imc.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("Votre catégorie est : " + categorie);

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Calcul terminé, veuillez taper sur n'importe quelle touche pour continuer...");

            Console.ReadKey();
        }
    }
}
