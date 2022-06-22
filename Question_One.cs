public class Question_One
{
    public static void Soma()
    {
        int Indice = 13;
        int Soma = 0;
        int K = 0;

        while (K < Indice)
        {
            K += 1;
            Soma += K;
        }

        Console.WriteLine(Soma);
    }
}