public class Question_Three
{
    public static int NextNumber(int[] numbers)
    {
        if (numbers[1] - numbers[0] == numbers[2] - numbers[1])
        {
            var Position = numbers.Length + 1;
            int razao = numbers[1] - numbers[0];
            return numbers[0] + (Position - 1) * razao;
        }
        else if (VerificaPG(numbers))
        {
            var Position = numbers.Length;
            int razao = numbers[1] / numbers[0];

            return numbers[0] * (int)Math.Pow(razao, Position);
        }
        else if (VerificaRaizQuadrada(numbers))
            return (int)Math.Pow((Math.Sqrt(numbers.Last()) + 1), 2);


        else if (VerificaFibbo(numbers))
            return numbers.Last() + numbers[numbers.Count() - 2];

        else return 200;

    }

    public static bool VerificaPG(int[] numbers)
    {
        if (numbers[0] == 0)
            return false;
        else return numbers[1] / numbers[0] == numbers[2] / numbers[1];
    }

    public static bool VerificaRaizQuadrada(int[] numbers)
    {
        bool NumberInCondition = true;
        foreach (var x in numbers)
        {
            if (x == 0)
                continue;
            var a = Math.Sqrt(x) % 1;
            bool teste = a == 0;
            if (!teste)
                NumberInCondition = false;
        }

        return NumberInCondition;
    }

    public static bool VerificaFibbo(int[] numbers)
    {
        bool AllPassFiboCondition = true;
        foreach (var number in numbers)
        {
            int IndexNumber = Array.IndexOf(numbers, number);
            if (IndexNumber > 2)
            {
                bool FiboCondition = numbers[IndexNumber] == numbers[IndexNumber - 1] + numbers[IndexNumber - 2];
                if (!FiboCondition)
                    AllPassFiboCondition = false;

            }
        }

        return AllPassFiboCondition;
    }


}

