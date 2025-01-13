public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        int[] mostFrequency = new int[k];
        Dictionary<int, int> countNums = new Dictionary<int, int>();
        List<int>[] ints = new List<int>[nums.Length + 1];
        for (int i = 0; i < ints.Length; i++)
        {
            ints[i] = new List<int>();
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if(countNums.ContainsKey(nums[i])) 
            { countNums[nums[i]]++; }
            else { countNums[nums[i]]=1; }
        }

        foreach(var element in countNums)
        {
            ints[element.Value].Add(element.Key);
        }

        int m = 0;
        for(int i = nums.Length; i > 0 && m<k ; i--)
        {
            foreach (int n in ints[i])
            {
                mostFrequency[m++] = n;
                if(m==k){
                    return mostFrequency; 
                }
            }
        }
        return mostFrequency;
    }
}