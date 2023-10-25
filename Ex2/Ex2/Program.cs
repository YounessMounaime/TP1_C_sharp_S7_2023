//TP1:Ex2
Console.WriteLine("Saisir un mois : ");
string mois = Console.ReadLine();
switch (mois.ToLower())
{
    case "janvier" or "mars" or  "mai" or "juillet" or "aout" or "octobre" or "decembre":
        Console.WriteLine("31");
        break;

    case "avril" or "juin" or "septembre" or "novembre":
        Console.WriteLine("30");
        break;

    case "fevrier":
        Console.WriteLine("28");
        break;

    default:
        Console.WriteLine("Erreur");
        break;
}
Console.ReadLine();
