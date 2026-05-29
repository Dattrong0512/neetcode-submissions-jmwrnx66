public class Solution {
    public List<List<int>> _listReturn = new();
    public List<int> _tracking = new();
    public List<List<int>> CombinationSum(int[] nums, int target)
    {
        BackTracking(nums, target, 0);
        return _listReturn;
    }

    public void BackTracking(int[] nums, int target, int index)
    {
        if(target == 0)
        {
            _listReturn.Add(new List<int>(_tracking));
            return;
        }
        if(target < 0 || index >= nums.Length)
        {
            return;
        }
        _tracking.Add(nums[index]);
        BackTracking(nums, target - nums[index], index);
        _tracking.RemoveAt(_tracking.Count - 1);
        BackTracking(nums, target, index + 1);
        return;
    }
}
