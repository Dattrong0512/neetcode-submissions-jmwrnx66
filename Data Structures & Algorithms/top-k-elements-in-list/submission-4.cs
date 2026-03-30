public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        List<int> listReturn = new List<int>();
        for(int i = 0; i< nums.Length; i++)
        {
          if(!dict.TryGetValue(nums[i], out var _))
          {
            dict.Add(nums[i],1);
          }
          else
            {
                dict[nums[i]]++;
            }
        }   

        var sortedDict = dict.OrderByDescending(item => item.Value);

        foreach(var item in sortedDict)
        {
            if(item.Value!=0)
            {
                listReturn.Add(item.Key);
            }
        }
        
        return listReturn.Slice(0, k).ToArray();
    }
}
