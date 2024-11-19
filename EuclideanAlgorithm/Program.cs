var firstNumber = 4851;
var secondNumber = 3003;

var result = gcd(firstNumber, secondNumber);

Console.WriteLine($"НОД({firstNumber}, {secondNumber}) = {result}");

int gcd(int a, int b)
{
    while (b != 0)
    {
        var remainder = a % b;
        // НОД(A, B) = НОД(B, остаток)
        a = b;
        b = remainder;
    }

    return a;
}
