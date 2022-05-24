## Longest Increasing Subsequence explain
Check the problem in [here](https://leetcode.com/problems/longest-increasing-subsequence/)

**1. Realizing this is a dynamic programming problem.**

This problem has **two important factors** that let us know it should be solved by dynamic programming. First, the question is asking for the **maximum or minimum** of something. Second, we have to **make decisions** that may depend on previously made decisions, which is very typical of a problem involving subsequences.

**2. Framework to solve dynamic programming problem.**

Typically, dynamic programming problems can be solved with **three main components**.
**First**, a **function or array** is required to represent the answer to the problem from a given state. Let's say that we have an array called f where **f[i] represents the length of the longest increasing subsequence ending with the ith element**.

**Second**, a way to transition between states, such as f[5] and f[7], is required. This transition is sometimes tricky to figure out. Let's say that if we know f[0], f[1], f[2], how can we find out f[3]? Since f[2] represents the length of the longest increasing subsequence ending at i = 2 of nums and if we compare that **f[3] is greater than f[2]**, we can simply take the subsequence ending at i = 2 and append nums[3] to it. This means the length is increased by 1 unit. The same can be said for nums[0], nums[1] if nums[3] is larger. To assure the longest increasing subsequence can be committed, f[3] needs to be maximized while checking comparison between f[3] and the range from f[0] to f[2]. So the recurrence relation will be `f[i] = max(f[j]+1) for all j where nums[j] < nums[i] and j < i`.

**Finally**, a base case is required but simple to achieve. In this case, every element of f can be initialized to 1 because every element on its own is technically an increasing subsequence.

**3. Algorithm.**

1. Initialize an array called f with the length of nums and fill all elements of f to 1. f[i] represents the length of the longest increasing subsequence ending with the element at index i.
2. Iterate from i = 1 to nums.length - 1. At each iteration, use a second iteration to iterate from j = 0 to i - 1 (consider all the elements before i). If any of elements before i is smaller than nums[i], set `f[i]=max(f[i],f[j]+1)`.  
3. Return the **max value** from f.

**4. Implementation using C#.**

```
public class Solution {
    public int LengthOfLIS(int[] nums) {
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
```