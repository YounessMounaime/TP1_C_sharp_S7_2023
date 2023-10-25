//Youness Mounaime
//4IRR2
List<string> tache = new List<string>();
//Fonction pour ajoute une nouvelle tâche à la liste
void AjouterTache()
{
    Console.Write("Veuillez entrez la description de la tâche : ");
    string Description = Console.ReadLine();
    tache.Add(Description);
    Console.WriteLine("Tâche "+Description+" a ajoutée avec succès !");
}
//Fonction pour affiche la liste des tâches numérotés
void AfficherTache()
{
    Console.WriteLine("**** Liste des tâches ****");
    int index = 1;
    foreach (String i in tache)
    {
        
           Console.WriteLine(index +" ----> "+i);
        index++;
    }
    }
//Fonction pour marquer une tâche comme terminée
void MarquerTache()
{
    AfficherTache();
    Console.Write("Veuillez entrez le numéro de la tâche terminée : ");
    int Index_t = Convert.ToInt32(Console.ReadLine()) - 1;
    if (Index_t >= 0 && Index_t < tache.Count)
    {
        Console.WriteLine("La tâche "+tache[Index_t]+" est marquée comme terminée.");
      
    }
    else
    {
        Console.WriteLine("Numéro de tâche non valide. Veuillez entrer un numéro de tâche correct.");
    }
}
//Fonction pour supprimer une tâche de la liste
void SupprimerTache()
{
    AfficherTache();
    Console.Write("Entrez le numéro de la tâche à supprimer : ");
    int Index_t = Convert.ToInt32(Console.ReadLine()) - 1;

    if (Index_t >= 0 && Index_t < tache.Count)
    {
        string suppTache = tache[Index_t];
        tache.RemoveAt(Index_t);
        Console.WriteLine("La tâche "+suppTache+ " a été supprimée avec succès.");
    }
    else
    {
        Console.WriteLine("Numéro de tâche non valide. Veuillez entrer un numéro de tâche correct.");
    }
}

//main
bool quitter = false;
while (!quitter)
{
    Console.WriteLine("********    Menu      ********");
    Console.WriteLine("1- Ajouter une nouvelle tâche");
    Console.WriteLine("2- Afficher la liste des tâches");
    Console.WriteLine("3- Marquer une tâche comme terminée");
    Console.WriteLine("4- Supprimer une tâche ");
    Console.WriteLine("5- Quitter ");
    Console.WriteLine("************************************");
    Console.Write("Choix : ");

    string choix = Console.ReadLine();

    switch (choix)
    {
        case "1":
            AjouterTache();
            break;
        case "2":
            AfficherTache();
            break;
        case "3":
            MarquerTache();
            break;
        case "4":
            SupprimerTache();
            break;
        case "5":
            quitter = true;
          
            break;
        default:
            Console.WriteLine("Choix invalide. Veuillez réessayer.");
            break;
    }
}