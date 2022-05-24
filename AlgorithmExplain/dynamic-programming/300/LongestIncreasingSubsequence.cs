namespace LeetCodeSolutions
{
    public class LongestIncreasingSubsequence
    {
        public int LengthOfLIS(int[] nums)
        {
            int res = 0;
            List<int> f = new List<int>();
            f.Add(1);
            for (int i = 1; i < nums.Length; i++)
            {
                f.Add(1);
                for(int j = 0; j < i; j++)
                {
                    if(nums[i]>nums[j])
                        f[i] = Math.Max(f[j] + 1, f[i]);
                }
            }
            res = f[0];
            for(int i = 1; i < nums.Length; i++)
            {
                res = Math.Max(res, f[i]);
            }
            return res;
        }
    }
}
