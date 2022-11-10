// https://leetcode.com/problems/reverse-bits/description/
public class Solution 
{
    public uint reverseBits(uint n) 
    {
        const uint pt16_l = 0b_1111_1111_1111_1111_0000_0000_0000_0000;
        const uint pt16_r = pt16_l >> 16;
        
        const uint pt08_l = 0b_1111_1111_0000_0000_1111_1111_0000_0000;
        const uint pt08_r = pt08_l >> 8;
        
        const uint pt04_l = 0b_1111_0000_1111_0000_1111_0000_1111_0000;
        const uint pt04_r = pt04_l >> 4;
        
        const uint pt02_l = 0b_1100_1100_1100_1100_1100_1100_1100_1100;
        const uint pt02_r = pt02_l >> 2;
        
        const uint pt01_l = 0b_1010_1010_1010_1010_1010_1010_1010_1010;
        const uint pt01_r = pt01_l >> 1;
        
        n = ((n & pt16_l) >> 16) | ((n & pt16_r) << 16);
        n = ((n & pt08_l) >> 08) | ((n & pt08_r) << 08);
        n = ((n & pt04_l) >> 04) | ((n & pt04_r) << 04);
        n = ((n & pt02_l) >> 02) | ((n & pt02_r) << 02);
        n = ((n & pt01_l) >> 01) | ((n & pt01_r) << 01);
        
        return n;
    }
}
