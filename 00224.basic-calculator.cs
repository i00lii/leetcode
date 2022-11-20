// https://leetcode.com/problems/basic-calculator/description/
public class Solution 
{
    private static readonly Dictionary<char, Token> _lookup = new ()
    {
        ['+'] = Token.Plus,
        ['-'] = Token.Minus,
        ['('] = Token.OpenBracket,
        [')'] = Token.CloseBracket
    };

    public int Calculate(string s) 
    {
        Stack<int> buffer = new Stack<int>();
        HandleReccursive(Yield(s).GetEnumerator(), buffer);
        return buffer.Pop();
    }
    
    private static void HandleReccursive(IEnumerator<(Token Token, int Number)> enumerator, Stack<int> buffer)
    {
        while(enumerator.MoveNext())
        {
            switch(enumerator.Current.Token)
            {
                case Token.OpenBracket:
                    HandleReccursive(enumerator, buffer);
                    break;
                    
                case Token.CloseBracket:
                    return;

                case Token.Number:
                    buffer.Push(enumerator.Current.Number);
                    break;
                
                case Token.UnaryMinus:
                    enumerator.MoveNext();
                    
                    if (enumerator.Current.Token == Token.OpenBracket)
                    {
                        HandleReccursive(enumerator, buffer);
                        buffer.Push(-buffer.Pop());
                    }
                    else
                    {
                        buffer.Push(-enumerator.Current.Number);
                    }
                    
                    break;
                    
                case Token.Plus:
                    enumerator.MoveNext();
                    
                    if (enumerator.Current.Token == Token.OpenBracket)
                    {
                        HandleReccursive(enumerator, buffer);
                        buffer.Push(buffer.Pop() + buffer.Pop());
                    }
                    else
                    {
                        buffer.Push(buffer.Pop() + enumerator.Current.Number);
                    }
                    
                    break;
                    
                case Token.Minus:
                    
                    enumerator.MoveNext();
                    
                    if (enumerator.Current.Token == Token.OpenBracket)
                    {
                        HandleReccursive(enumerator, buffer);
                        int y = buffer.Pop();
                        int x = buffer.Pop();
                        buffer.Push(x - y);
                    }
                    else
                    {
                        buffer.Push(buffer.Pop() - enumerator.Current.Number);
                    }
                    break;
            }
        }
    }

    private static IEnumerable<(Token Token, int Number)> Yield(string s)
    {
        int number = 0;
        bool isJustYieldNumberOrGroupEnd = false;
        bool numberNotEmpty = false;
        
        for(int idx = 0; idx < s.Length; idx++)
        {
            char c = s[idx];

            if (char.IsDigit(c))
            {
                number = number * 10 + (c - '0');
                numberNotEmpty = true;
                continue;
            }

            if (numberNotEmpty)
            {
                isJustYieldNumberOrGroupEnd = true;
                numberNotEmpty = false;
                yield return (Token.Number, number);
                number = 0;
            }

            if (char.IsWhiteSpace(c))
                continue;

            if (_lookup.TryGetValue(c, out Token token))
            {
                token = token == Token.Minus && !isJustYieldNumberOrGroupEnd ? Token.UnaryMinus : token;
                isJustYieldNumberOrGroupEnd = token == Token.CloseBracket;
                yield return (token, default);
            }
        }

        if (numberNotEmpty)
        {
            yield return (Token.Number, number);
        }
    }

    private enum Token
    {
        Number,
        Plus,
        Minus,
        UnaryMinus,
        OpenBracket,
        CloseBracket
    }
}
