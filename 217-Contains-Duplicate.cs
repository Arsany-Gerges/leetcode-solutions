public class Solution {

    public bool ContainsDuplicate(int[] nums)
    {
        bool repeated = false;
        HashSet<int> set = new HashSet<int>(nums);
        if (set.Count != nums.Length)
        {
            repeated = true;
        }
        
        return repeated;
    }
    
}