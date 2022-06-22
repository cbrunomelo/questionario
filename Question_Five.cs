using System.Text;
public static class Question_Five
{
    public static string ReverString(string input)
    {
        var builder = new StringBuilder();
        foreach (char c in input)
        {
            builder.Insert(0, c);
        }
        return builder.ToString();
    }
}