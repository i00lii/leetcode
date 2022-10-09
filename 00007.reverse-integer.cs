// https://leetcode.com/problems/reverse-integer/description/
public int Reverse(int x) 
{
    const int _minValue = int.MinValue / 10;
    const int _maxValue = int.MaxValue / 10;
  
    int rev = 0;

    while (x != 0) 
    {
        int pop = x % 10;
        x /= 10;
        if (rev > _maxValue || (rev == _maxValue && pop > 7)) return 0;
        if (rev < _minValue || (rev == _minValue && pop < -8)) return 0;
        rev = rev * 10 + pop;
    }
    return rev;
}
