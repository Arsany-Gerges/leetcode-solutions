public class Solution {
    public bool IsAnagram(string s, string t) {
        bool result = false;
        char[] chars_s = s.ToCharArray();
        char[] chars_t = t.ToCharArray();

        Array.Sort(chars_s);
        Array.Sort(chars_t);

        if (string.Join(\\,chars_s).Equals(string.Join(\\, chars_t))) 
        { 
            result = true;
        }

        return result;
    }
}