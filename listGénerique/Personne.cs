using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listGénerique
{
    internal class Personne
    {
        public String Code { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }

        // Constructeur par defaut
        public Personne() {}
        //constructeur parametrique
        public Personne(String code ,String nom, String prenom, int age)
        {
            Code = code;
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }

        public String getinfo()
        {
            return " Je m’appelle " + Nom + " " + Prenom + " J’ai " + Age + " an j'ai le code " + Code;
        }
        // Creer une Liste des personnes
        static List<Personne> personnes = new List<Personne>();
        public void ajouter(Personne p)
        {
            personnes.Add( p );
            Console.WriteLine("Personne ajoutée avec succès!\n");
        }
        public void modifier_nom(String code, string nom)
        {
            bool isUpdate = false;
            foreach (Personne p in personnes)
            {
                if (code.Equals(p.Code))
                {
                    p.Nom = nom;
                    Console.WriteLine($"Vous avez modifié le nom de la personne {code}");
                    isUpdate = true;
                    break;
                }
            }
            if (!isUpdate)
            {
                Console.WriteLine($"Aucune personne trouvée avec le code {code}. Le nom n'a pas été modifié.");
            }
        }
        public void supprimer(String nom)
        {
            bool isDelete = false;
            foreach (Personne p in personnes)
            {
                if (p.Nom.Equals(nom))
                {
                    personnes.Remove(p);
                    Console.WriteLine($"Vous avez supprimé la personne {Code}");
                    isDelete = true;
                    break;
                }
            }
            if (!isDelete)
            {
                Console.WriteLine($"Aucune personne trouvée avec le nom {nom}. La suppression a échoué");
            }
        }

        public void chercher(String code)
        {
            bool isFound = false;
            foreach (Personne p in personnes)
            {
                if (p.Code.Equals(code))
                {
                    Console.WriteLine("la personne cherche est :" + p.getinfo());
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"Aucune personne trouvée avec le code {code}");
            }
        }
        public void affichage()
        {
            foreach (Personne p in personnes)
            {
                  Console.WriteLine("Les personnes  :" + p.getinfo());
            }
        }
        public int compter()
        {
            return personnes.Count;
        }
        public void categories()
        {
            foreach (Personne p in personnes)
            {
                if (p.Age <= 18)
                    Console.WriteLine("la catégorie de " + p.Nom + "est: P" );
                if (p.Age >= 19 && p.Age <= 35)
                    Console.WriteLine("la catégorie de " + p.Nom + " est: J");
                if (p.Age >= 36)
                    Console.WriteLine("la catégorie de " + p.Nom + "est: G");
            }
        }
    }
}
