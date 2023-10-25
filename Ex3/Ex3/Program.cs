 int CalculerSomme(int[] tab)
{
    int somme = 0;
    for(int i = 0; i < tab.Length; i++)
    {
        somme += tab[i];
    }
    return somme;
}
int SommeElementsInferieurs(int[] tab , int val)
{
    int somme = 0;
    for (int i = 0; i < tab.Length; i++)
    {
        if (tab[i] < val)
        {
            somme += tab[i];
        }

    }
    return somme;
}   
        
Console.Write("Veuillez entrer la taille du tableau : ");
        int taille = Convert.ToInt32(Console.ReadLine());
        int[] Tab = new int[taille];
        for (int i = 0; i < Tab.Length; i++)
        {
            Console.Write("Tab[" + (i+1) + "] = ");
            Tab[i] = Convert.ToInt32(Console.ReadLine());
        }
Console.Write("Veuillez entrer la valeur seuil : ");
int v = Convert.ToInt32(Console.ReadLine());
Console.Write("La somme du tableau est : "+ CalculerSomme(Tab)+ " et la somme  inférieurs à la "+v+
                 " est "+ SommeElementsInferieurs(Tab, v));

Console.ReadLine();









