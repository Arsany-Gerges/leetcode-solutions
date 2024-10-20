public class Solution {
    public int RomanToInt(string s)
    {
        Dictionary<char,int> RomanNumbers = new Dictionary<char,int>{
            {'I', 1},
            { 'V',5 },
            { 'X',10 },
            { 'L',50 },
            { 'C',100 },
            { 'D',500 },
            { 'M',1000 }
        };

        int result= RomanNumbers[s[s.Length - 1]];

        for (int i= s.Length-1; i>0; i--)
        {
            if (RomanNumbers[s[i-1]] >= RomanNumbers[s[i]])
            {
                result += RomanNumbers[s[i-1]];
            }
            else
            {
                result -= RomanNumbers[s[i - 1]];
            }
        }
        return result;
    }
}