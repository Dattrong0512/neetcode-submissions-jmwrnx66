public class Solution {
    public List<List<int>> _listReturn = new List<List<int>>();
    public List<int> _current = new List<int>();

    public List<List<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);
        BackTracking(candidates, target, 0);
        return _listReturn;
    }
    public void BackTracking(int[] nums, int target, int index)
    {
        if(target == 0)
        {
            _listReturn.Add(new List<int>(_current));
            return;
        }
        if(target < 0)
        {
            return;
        }
        for(int i = index; i < nums.Length; i++)
        {
            if(i > index && nums[i] == nums[i-1])
            {
                continue;
            }
            if(nums[i] > target)
            {
                break;
            }
            _current.Add(nums[i]);
            BackTracking(nums, target - nums[i], i + 1);
            _current.RemoveAt(_current.Count - 1);
        }
    }
}
