
void ajouterTaches(List<String> maListe)
{
    string taches;
    Console.WriteLine("Sasir votre taches : ");
    taches = Console.ReadLine();
    maListe.Add(taches);
}
void SupprimerTaches(List<String> maListe)
{
    string taches;
    Console.WriteLine("Sasir votre taches : ");
    taches = Console.ReadLine();
    maListe.Remove(taches);
}
void AfficherTaches(List<String> maListe)
{
    foreach (String  n in maListe)
    {
        Console.WriteLine(n);
    }

}
Console.WriteLine("Application de gestion de tâches (To-Do List)");
List<String> maListe = new List<String>();
ajouterTaches(maListe);
AfficherTaches(maListe);
Console.ReadLine();

