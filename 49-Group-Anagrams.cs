public class Solution {
public IList<IList<string>> GroupAnagrams(string[] strs)
{
    IList<IList<string>> result = [];
    var setOfAnagrams= new Dictionary<string, IList<string>>();

    
    foreach (string s in strs)
    {
        int[] alphabetCount = new int[26];
        foreach (char c in s) {
            alphabetCount[c - 'a']++;
        }
        string keyOfInsert = string.Join(\,\, alphabetCount);
        if (!setOfAnagrams.ContainsKey(keyOfInsert))
        {
            setOfAnagrams[keyOfInsert] = new List<string>();
        }
        setOfAnagrams[keyOfInsert].Add(s);
    }
    result = setOfAnagrams.Values.ToList<IList<string>>();
    return result;
}
}