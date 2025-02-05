// using System;

class Program{
    static void Main() 
    {
        int nb;

        do {
            Console.WriteLine("Bienvenue dans l'application de gestion des notes");
            Console.WriteLine("1. Ajouter un étudiant et ses notes");
            Console.WriteLine("2. Afficher les notes d'un étudiant");
            Console.WriteLine("3. Afficher toutes les notes");
            Console.WriteLine("4. Calculer la moyenne d'un étudiant");
            Console.WriteLine("5. Afficher la moyenne de la classe");
            Console.WriteLine("6. Afficher l'étudiant ayant la meilleure moyenne");
            Console.WriteLine("7. Afficher l'étudiant ayant la pire moyenne");
            Console.WriteLine("8. Afficher les étudiants ayant une moyenne ≥ 10");
            Console.WriteLine("9. Quitter");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.Write("Entrez votre choix : ");
            nb = int.Parse(Console.ReadLine());

            switch(nb)
            {
                case 1:
                        Console.WriteLine("Entrez le nom de l'étudiant :");
                        Console.WriteLine(" ");
                        break;
                case 2:
                        Console.WriteLine("Entrez le nom de l'étudiant :");
                        Console.WriteLine(" ");
                        break;
                case 3:
                        Console.WriteLine("--- Listes des étudiants et leurs notes ---");
                        Console.WriteLine(" ");
                        break;
                case 4:
                        Console.WriteLine("Entrez le nom de l'étudiant :");
                        Console.WriteLine(" ");
                        break;
                case 5:
                        Console.WriteLine("--- Listes de la moeynne de la classe ---");
                        Console.WriteLine(" ");
                        break;
                case 6:
                        Console.WriteLine("--- Etudiant ayant la meilleure note ---");
                        Console.WriteLine(" ");
                        break;
                case 7:
                        Console.WriteLine("--- Etudiant ayant la pire note ---");
                        Console.WriteLine(" ");
                        break;
                case 8:
                        Console.WriteLine("--- Listes des étudiants ayant une moyenne ≥ 10 ---");
                        Console.WriteLine(" ");
                        break;
            }
        } while (nb != 9);
    }
}



