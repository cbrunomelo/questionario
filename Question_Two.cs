public class Question_Two
{
    public static bool IsInFibo(int number)
    {
        List<int> fibo_numbers = new();
        fibo_numbers.Add(0);
        fibo_numbers.Add(1);

        while (fibo_numbers.Last() <= number)
        {
            fibo_numbers.Add(fibo_numbers.Last() + fibo_numbers[fibo_numbers.Count - 2]);
        }


        return fibo_numbers.Contains(number);
    }
}