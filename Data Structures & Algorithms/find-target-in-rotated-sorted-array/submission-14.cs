public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;
        while(left <= right)
        {
            int mid = left + (right - left)/2;
            int valueMid = nums[mid];
            if(target == valueMid)
            {
                return mid;
            }
            if(nums[left] <= valueMid)
            {
                if(valueMid > target && nums[left] <= target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            else
            {
                if(nums[right] >= target && valueMid < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }
        return -1;
    }
}