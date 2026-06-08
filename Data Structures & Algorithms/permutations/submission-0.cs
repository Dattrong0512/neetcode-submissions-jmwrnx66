public class Solution {
    public List<List<int>> _listReturn = new List<List<int>>();
    public List<int> _current = new List<int>();
    private bool[] _used;

    public List<List<int>> Permute(int[] nums)
    {
        _used = new bool[nums.Length];
        BackTracking(nums);
        return _listReturn;
    }
    public void BackTracking(int[] nums)
    {
        if(_current.Count == nums.Length)
        {
            _listReturn.Add(new List<int>(_current));
            return;
        }
        for(int i = 0; i < nums.Length; i++)
        {
            if(_used[i])
            {
                continue;
            }
            _current.Add(nums[i]);
            _used[i] = true;
            BackTracking(nums);
            _current.RemoveAt(_current.Count - 1);
            _used[i] = false;
        }
        return;
    }
}
