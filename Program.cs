class Program{
        static Dictionary<string, List<int>> students = new Dictionary<string, List<int>>();
        static void take_student()
        {
                List<string> listStudent = new List<string>();
                List<int> Notes = new List<int>();
                int nombre;
                string name = Console.ReadLine();

                if (students.ContainsKey(name)) {
                        Console.WriteLine("L'étudiant est déjà enregistré !");
                        return;
                }

                listStudent.Add(name);

                while(Notes.Count < 3) {
                        Console.Write($"Ajouter une note :");
                        string insertNb = Console.ReadLine();

                        if (int.TryParse(insertNb, out nombre)) {
                                if (nombre <= 20) {
                                        Notes.Add(nombre);
                                } else {
                                        Console.WriteLine("La note doit être inférieur à 20");
                                }
                        }
                }
                students[name] = Notes;
                Console.WriteLine($"Élève : {listStudent[0]}");
                Console.WriteLine($"Notes : {string.Join(", ", Notes)}");
        }

        static void display_student_notes()
        {
                string name = Console.ReadLine();

                if (students.ContainsKey(name)) {
                        List<int> Notes = students[name];
                        Console.WriteLine($"Notes : {string.Join(", ", Notes)}");
                } else {
                        Console.WriteLine("FAUX");
                }
        }

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
                                Console.Write("Entrez le nom de l'étudiant :");
                                take_student();
                                Console.WriteLine(" ");
                                break;
                        case 2:
                                Console.Write("Entrez le nom de l'étudiant :");
                                display_student_notes();
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



