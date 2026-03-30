public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hashset = new HashSet<int>(nums.Length);
        foreach(var i in nums)
        {
            if(hashset.Contains(i))
            {
                return true;
            }
            hashset.Add(i);
        }
        return false;
    }
}