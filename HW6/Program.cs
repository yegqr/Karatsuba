class Program
{
    private static void Main(string[] args)
    {
        var num1 = "";
        var num2 = "";
        var operatorr = '0';
        foreach (var character in string.Join("", args))
        {
            if (character == '+' ||character == '-' ||character == '*')
            {
                operatorr = character;
            }
            else if ( operatorr == '0' && (char.IsDigit(character)))
            {
                num1 += character;
            }
            else if ( char.IsDigit(character))
            {
                num2 += character;
            }
        }

        switch (operatorr == '+')
        {
            case true :
                Console.WriteLine(new BigInteger(num1) + new BigInteger(num2));
                break;
            case false:
                switch (operatorr == '-')
                {
                    case true:
                        Console.WriteLine((new BigInteger(num1).Sub(new BigInteger(num2)).ToString()));
                        break;
                    case false :
                        var x  = new BigInteger(num1).Multiply(new BigInteger(num2)).ToString() ;
                        Console.WriteLine($"=> {x}");
                        break;
                }
                break;
        }
    }
}