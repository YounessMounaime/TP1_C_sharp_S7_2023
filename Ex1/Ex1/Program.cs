//TP1-EX1
double nbr1, nbr2;
do
{
    Console.Write("Entrez le premier nombre : ");
    nbr1 = Convert.ToDouble(Console.ReadLine());
} while (nbr1 == 0);

do
{
    Console.Write("Entrez le deuxième nombre : ");
    nbr2 = Convert.ToDouble(Console.ReadLine());
} while (nbr2 == 0);
if ((nbr1 > 0 && nbr2 > 0) || (nbr1 < 0 && nbr2 < 0))
{
    Console.Write("Le produit est positif.");
}
else
{
    Console.Write("Le produit est négatif.");
}
Console.ReadLine();
