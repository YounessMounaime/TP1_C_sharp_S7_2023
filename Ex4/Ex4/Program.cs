int CalculerMinimum(int[,]mat)
{
    int min = mat[0, 0];
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            if (min > mat[i, j])
            {
                min = mat[i, j];
            }
        }      
    }
    return min;
}
int CalculerMaximum(int[,] mat)
{
    int max = mat[0, 0];
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            if (max < mat[i, j])
            {
                max = mat[i, j];
            }
        }
    }
    return max;
}

int CalculerSomme(int[,] matrice)
{
    int somme = 0;

    for (int i = 0; i < matrice.GetLength(0); i++)
    {
        for (int j = 0; j < matrice.GetLength(1); j++)
        {
            somme += matrice[i, j];
        }
    }

    return somme;
}
int CalculerMoyenne(int[,] matrice)
{
    int moy;
    int totale_mat = matrice.GetLength(0) * matrice.GetLength(1);
    moy=CalculerSomme(matrice)/(totale_mat);
    return moy;
}





int[,] matrice = new int[3, 3];
for (int i = 0; i < matrice.GetLength(0); i++)
{
    for (int j = 0; j < matrice.GetLength(1); j++)
    {
        Console.Write("matrice["+(i+1)+","+(j+1)+"] = ");
        matrice[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("Matrice  :");

for (int i = 0; i < matrice.GetLength(0); i++)
{
    for (int j = 0; j < matrice.GetLength(1); j++)
    {
        Console.Write(matrice[i, j] + "\t");
    }
    Console.WriteLine();
    

}
Console.WriteLine("La valeur minimale dans la matrice :" + CalculerMinimum(matrice));
Console.WriteLine("La valeur maximal dans la matrice :" + CalculerMaximum(matrice));
Console.WriteLine("La valeur somme est  : " + CalculerSomme(matrice) + " et le moyenne des éléments de la matrice : " + CalculerMoyenne(matrice));
Console.ReadLine();