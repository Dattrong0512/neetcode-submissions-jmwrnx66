public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int[] value = new int[2];
        for(int i = 0; i < nums.Length; i++)
        {
            int valueExist = target - nums[i];
            if(!dict.TryGetValue(valueExist, out _))
            {
                dict.Add(nums[i],i);
            }
            if(dict.TryGetValue(valueExist, out var valueInDict))
            {
                if(dict[valueExist] != i)
                {
                    value[0] = dict[valueExist];
                    value[1] = i;
                    return value;
                }
            }
        }
        return value;
    }
}
