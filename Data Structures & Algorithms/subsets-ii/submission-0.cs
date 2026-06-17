public class Solution {
    public List<List<int>> _listReturn = new List<List<int>>();
    public List<int> _current = new List<int>();

    public List<List<int>> SubsetsWithDup(int[] nums)
    {
        Array.Sort(nums);
        BackTracking(nums, 0);
        return _listReturn;
    }

    public void BackTracking(int[] nums, int index)
    {
        if(index >= nums.Length)
        {
            _listReturn.Add(new List<int>(_current));
            return;
        }
        _current.Add(nums[index]);
        BackTracking(nums, index + 1);
        _current.RemoveAt(_current.Count - 1);

        while(index + 1 < nums.Length && nums[index] == nums[index + 1])
        {
            index++;
        }
        BackTracking(nums, index + 1);
    }
}
