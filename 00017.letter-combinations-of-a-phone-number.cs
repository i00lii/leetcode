private static readonly string[] _lookup = new string[]
{
    string.Empty,
    string.Empty,
    "abc",
    "def",
    "ghi",
    "jkl",
    "mno",
    "pqrs",
    "tuv",
    "wxyz"
};

public IList<string> LetterCombinations(string digits) 
{
    if (string.IsNullOrEmpty(digits))
        return Array.Empty<string>();

    List<string> result = new List<string>((int)Math.Pow(digits.Length, 4));
    Reccursion(0, digits, new char[digits.Length], result);
    return result;
}

private static void Reccursion(int idx, string digits, char[] buffer, List<string> result)
{
    string buttonValues = _lookup[digits[idx] - '0'];

    for(int jdx = 0; jdx < buttonValues.Length; jdx++)
    {
        buffer[idx] = buttonValues[jdx];
        if (idx < digits.Length - 1)
        {
            Reccursion(idx + 1, digits, buffer, result);
        }
        else 
        {
            result.Add(new string(buffer));
        }
    }
}
