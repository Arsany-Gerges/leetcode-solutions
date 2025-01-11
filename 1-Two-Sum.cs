public class Solution {
    public int[] TwoSum(int[] nums, int target) {
         Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
        int[] result;
        for(int i=0; i < nums.Length; i++)
        {
            int differenceBetweenPairs = target - nums[i];
            if (keyValuePairs.ContainsKey(differenceBetweenPairs)) 
            {
                result = [keyValuePairs[differenceBetweenPairs],i];
                return result;
            }
            keyValuePairs[nums[i]] = i;

        }
        return null;
    }
}