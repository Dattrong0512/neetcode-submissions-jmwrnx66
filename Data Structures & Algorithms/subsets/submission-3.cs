public class Solution {
    public List<List<int>> _listReturn;
    public List<int> _current;
    public Solution()
    {
        _listReturn = new List<List<int>>();
        _current = new List<int>();
    }

    public List<List<int>> Subsets(int[] nums)
    {
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
        BackTracking(nums, index + 1);
    }
}
