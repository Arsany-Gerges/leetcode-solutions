public class Solution {
    public bool IsPalindrome(int x) {
        string test = x.ToString();
        bool result = true;
        for (int i = 0; i < (test.Length/2); i++)
        {
            if (test[i] != test[test.Length-1-i])
            {
                result = false; break;
            }
        } 
        return result;
    }
}