public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i = 0; i< nums.Length; i++)
        {
            if(!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i],1);
            } 
            else
            {
                dict[nums[i]]++;
            }
        }   

        return dict.OrderByDescending(item => item.Value)
                    .Select(item => item.Key)
                    .Take(k)
                    .ToArray();
    }
}
