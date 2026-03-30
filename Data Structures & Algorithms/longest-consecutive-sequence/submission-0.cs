public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums is null || nums.Length == 0)
        {
            return 0;
        }
        int longestConsecutive = 0;
        HashSet<int> hashNumber= new HashSet<int>(nums);
        foreach(int num in nums)
        {
            if(!hashNumber.Contains(num - 1))
            {
                int streak = 1;
                int numberCurrent = num;
                while(hashNumber.Contains(numberCurrent+1))
                {
                    streak++;
                    numberCurrent++;
                }
                longestConsecutive = Math.Max(streak, longestConsecutive);
            }
        }
        return longestConsecutive;
    }
}