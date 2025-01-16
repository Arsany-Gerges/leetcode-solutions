public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        List<int> zeros = new List<int>();
        int productOfNums = 1;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0)
            {
                zeros.Add(i);
            }
        }
        if (zeros.Count > 1) { 
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
        else if (zeros.Count == 1) {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0){
                    productOfNums = productOfNums * nums[i];
                }
            }
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] == 0) { 
    result[i] = productOfNums;
}
else
{
    result[i] = 0;
}
            }
        }
        else
        {
            for (int i = 0; i < nums.Length; i++)
            {
                productOfNums = productOfNums * nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = productOfNums / nums[i];
            }
        }
        return result;
    }
}