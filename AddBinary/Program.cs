internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Solution.AddBinary("100", "110010"));
    }

}
public class Solution
{
    public static string AddBinary(string a, string b)
    {
        string result = "";
        int diffA = 0;
        int diffB = 0;
        int carry = 0;

        if (a.Length >= b.Length) diffA = a.Length - b.Length;
        else diffB = b.Length - a.Length; 

        if (diffA > 0)
        {
            for (int k = diffA; k > 0; k--)
            {
                b = "0" + b ;
            }
        }
        if (diffB > 0)
        {
            for (int k = diffB; k > 0; k--)
            {
                a = "0" + a;
            }
        }

        int i = a.Length - 1, j = b.Length - 1;


        while (i >= 0 && j >= 0)
        {
            if (b[j] == '1' && a[i] == '1')
            {
                if (carry == 0)
                {
                    result += "0";
                    carry = 1;
                }
                else result += "1";

            }
            else if ((b[j] == '0' && a[i] == '1') || (b[j] == '1' && a[i] == '0'))
            {
                if (carry == 0)
                {
                    result += "1";
                }
                else
                {
                    result += "0";
                    carry = 1;
                }
            }
            else
            {
                if (carry == 0) result += "0";
                else
                {
                    result += "1";
                    carry = 0;
                }
            }
            i--;
            j--;
        }


        if (carry == 1)
        {
            result += "1";
            return new string(result.Reverse().ToArray());
        }
        else return new string(result.Reverse().ToArray());
    }
}