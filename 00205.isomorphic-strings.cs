public class Solution 
{
    public bool IsIsomorphic(string s, string t) 
    {
        char[] mapST = new char[128];
        char[] mapTS = new char[128];

        for (int i = 0; i < s.Length; i++)
        {
            char valueS = s[i];
            char valueT = t[i];

            if (mapST[valueS] == 0 && mapTS[valueT] == 0)
            {
                mapST[valueS] = valueT;
                mapTS[valueT] = valueS;
            }
            else
            {
                if (mapST[valueS] != valueT || mapTS[valueT] != valueS)
                {
                    return false;
                }
            }
        }

        return true; 
    }
}
