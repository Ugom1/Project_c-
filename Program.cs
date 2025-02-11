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
                                if (nombre > 0 && nombre <= 20) {
                                        Notes.Add(nombre);
                                } else {
                                        Console.WriteLine("La note doit être inférieur à 20 ou supérieur à 0");
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

        static void display_all_notes()
        {
               foreach (var student in students) {
                        Console.WriteLine($"Elève: {student.Key} - Notes : {string.Join(", ", student.Value)}");
               }
        }

        static void moyenne_etudiant()
        {
                string name = Console.ReadLine();
                List<int> Notes = students[name];
                int sum = 0;
                int moyenne;

                if (students.ContainsKey(name)) {
                        foreach(int note in Notes) {
                                sum += note;
                        }
                        moyenne = sum / Notes.Count;
                        Console.WriteLine($"Moyenne de {name} : {moyenne}");
                } else {
                        Console.WriteLine("L'étudiant n'existe pas !");
                }
                
        }

        static void display_moyenne_classe()
        {
                int TotalSum = 0;
                int NoteCount = 0;
                int moyenne;

                foreach(var student in students) {
                        TotalSum += student.Value.Sum();
                        NoteCount += student.Value.Count;
                }
                if (NoteCount > 0) {
                        moyenne = TotalSum / NoteCount;
                        Console.WriteLine($"Moyenne de la classe : {moyenne}");
                }
        }

        static void display_best_moyenne()
        {
                int moyenne;
                int meilleurMoyenne = 0;
                string meilleurEtudiant = "";

                foreach(var student in students) {
                        moyenne = student.Value.Sum() / student.Value.Count;

                        if (moyenne > meilleurMoyenne) {
                                meilleurMoyenne = moyenne;
                                meilleurEtudiant = student.Key;
                        }
                }
                Console.WriteLine($"L'étudiant avec la meilleure moyenne est {meilleurEtudiant} avec une moyenne de {meilleurMoyenne}.");

        }

        static void display_worst_moyenne()
        {
                int moyenne;
                int pireMoyenne = int.MaxValue;
                string pireEtudiant = "";

                foreach(var student in students) {
                        moyenne = student.Value.Sum() / student.Value.Count;

                        if (moyenne < pireMoyenne) {
                                pireMoyenne = moyenne;
                                pireEtudiant = student.Key;
                        }
                }
                Console.WriteLine($"L'étudiant avec la meilleure moyenne est {pireEtudiant} avec une moyenne de {pireMoyenne}.");

        }

        static void display_basic_moyenne()
        {
                int moyenne;

                foreach(var student in students) {
                        moyenne = student.Value.Sum() / student.Value.Count;
                        if (moyenne >= 10) {
                                Console.WriteLine($"L'étudiant avec la meilleure moyenne est {student.Key} avec une moyenne de {moyenne}.");
                        }
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
                                display_all_notes();
                                Console.WriteLine(" ");
                                break;
                        case 4:
                                Console.Write("Entrez le nom de l'étudiant :");
                                moyenne_etudiant();
                                Console.WriteLine(" ");
                                break;
                        case 5:
                                Console.WriteLine("--- Listes de la moeynne de la classe ---");
                                display_moyenne_classe();
                                Console.WriteLine(" ");
                                break;
                        case 6:
                                Console.WriteLine("--- Etudiant ayant la meilleure moyenne ---");
                                display_best_moyenne();
                                Console.WriteLine(" ");
                                break;
                        case 7:
                                Console.WriteLine("--- Etudiant ayant la pire moyenne ---");
                                display_worst_moyenne();
                                Console.WriteLine(" ");
                                break;
                        case 8:
                                Console.WriteLine("--- Listes des étudiants ayant une moyenne ≥ 10 ---");
                                display_basic_moyenne();
                                Console.WriteLine(" ");
                                break;
                        case 9:
                                Console.WriteLine("Fin du programme.");
                                break;
                        }
                } while (nb != 9);
        }
}



