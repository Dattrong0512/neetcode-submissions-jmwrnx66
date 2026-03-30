public class Solution {
    public int Search(int[] nums, int target) {
        return BinarySearch(0, nums.Length - 1, nums, target);
    }
    public int BinarySearch(int leftIndex, int rightIndex, int[] nums, int target)
    {
        if(leftIndex > rightIndex)
        {
            return -1;
        }

        int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;

        if(nums[middleIndex] == target)
        {
            return middleIndex;
        }
        else if(nums[middleIndex] < target)
        {
            return BinarySearch(middleIndex + 1, rightIndex, nums, target);
        }
        else
        {
            return BinarySearch(leftIndex, middleIndex - 1, nums, target);
        }
    }
}
