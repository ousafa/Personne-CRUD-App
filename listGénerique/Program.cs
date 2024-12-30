using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace listGénerique
{
    internal class Program
    {
        // MENU
        public static void AfficherMenu()
        {
            Console.WriteLine("------------- Menu -----------");
            Console.WriteLine("1. Ajouter une personne");
            Console.WriteLine("2. Modifier une personne");
            Console.WriteLine("3. supprimer une personne");
            Console.WriteLine("4. Rechercher une personne");
            Console.WriteLine("5. Afficher les Personnes");
            Console.WriteLine("6. compter les Personnes");
            Console.WriteLine("7. Afficher la gategorie");
            Console.WriteLine("8. Quitter");
        }
        static void Main(string[] args)
        {
            String prenom,nom,code;
            int age, choix;

            // Creer un objet
            Personne p = new Personne();


            
            do
            {
                AfficherMenu();
                Console.Write("\nVeuillez choisir une option (1-8):");
                choix = int.Parse(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        Console.Write("Entrez le code (format: P###):");
                        code = Console.ReadLine();
                        Console.Write("Entrez le prénom:");
                        prenom = Console.ReadLine();
                        Console.Write("Entrez le nom:");
                        nom = Console.ReadLine();
                        Console.Write("Entrez l'âge:");
                        age = int.Parse(Console.ReadLine());
                        p.ajouter(new Personne(code,nom,prenom,age));
                        break;
                    case 2:
                        Console.Write("Entrez le code (format: P###):");
                        code = Console.ReadLine();
                        Console.Write("Entrez le nouveau nom:");
                        nom = Console.ReadLine();
                        p.modifier_nom(code, nom);
                        break;
                    case 3:
                        Console.Write("Entrez le nom à supprimer:");
                        nom = Console.ReadLine();
                        p.supprimer(nom);
                        break;
                    case 4:
                        Console.Write("Entrez le code à chercher:");
                        code = Console.ReadLine();
                        p.chercher(code);
                        break;
                    case 5:
                        p.affichage();
                        break;
                    case 6:
                        Console.WriteLine("le nombre des personnes est: " + p.compter());
                        break;
                    case 7:
                        p.categories();
                        break;
                    case 8:
                        Console.WriteLine("Au revoir!");
                        break;
                    default:
                        Console.WriteLine("Option invalide. Veuillez choisir entre 1 et 8.");
                        break;
                }
            } while(choix != 8);

            Console.ReadKey();

        }
    }
}
