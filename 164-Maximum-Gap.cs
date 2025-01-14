public class Solution {
    public int MaximumGap(int[] nums) {
                    int maximumGap = 0;
            int lowestValue = nums[0], highestValue = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < lowestValue) { lowestValue = nums[i]; }
                if (nums[i] > highestValue) { highestValue = nums[i]; }
            }

            Bucket[] buckets = new Bucket[nums.Length+1];
            for(int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = new Bucket();
            }
            int totalLength = highestValue - lowestValue;
            double I = (double)nums.Length / totalLength;
            for (int i = 0; i < nums.Length; i++)
            {
                //double n = (nums[i] - lowestValue) % I;

                int bucketNumber = (int)((nums[i] - lowestValue) * I);
                if (buckets[bucketNumber].lowestInBucket == -1 && buckets[bucketNumber].highestInBucket == -1)
                {
                    buckets[bucketNumber].lowestInBucket = nums[i];
                    buckets[bucketNumber].highestInBucket = nums[i];

                }
                else
                {
                    if (nums[i] <= buckets[bucketNumber].lowestInBucket)
                    {
                        buckets[bucketNumber].lowestInBucket = nums[i];
                    }
                    if (nums[i] >= buckets[bucketNumber].highestInBucket)
                    {
                        buckets[bucketNumber].highestInBucket = nums[i];
                    }
                }
            }
            int prev = buckets[0].highestInBucket;
            for (int i = 1; i < buckets.Length; i++)
            {
                if (buckets[i].lowestInBucket != -1){
                    int gap = buckets[i].lowestInBucket - prev;
                    if (gap > maximumGap)
                    {
                        maximumGap = gap;
                    }
                    prev = buckets[i].highestInBucket;
                }
            }


            return maximumGap;
    }
}
public class Bucket
{
    public int lowestInBucket;
    public int highestInBucket;
    public Bucket() {
        lowestInBucket = -1;
        highestInBucket = -1;
    }
}