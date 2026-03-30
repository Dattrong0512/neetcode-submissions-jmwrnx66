public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        int length = nums.Length;
        int[] leftArray = new int[length];
        int[] rightArray = new int[length];
        length -= 1;
        leftArray[0] = rightArray[length] = 1;
        int productArray1, productArray2;
        productArray1 = productArray2 = 1;
        int loop = length;
        for(int i = 0; i < loop; i++)
        {
            if(i == 0 && length == nums.Length - 1)
            {
                productArray1 = nums[i];
                productArray2 = nums[length];
                leftArray[i+1] = nums[i];
                rightArray[length-1] = nums[length];
            }
            else
            {
                productArray1 *= nums[i];
                productArray2 *= nums[length];
                leftArray[i+1] = productArray1;
                rightArray[length-1] = productArray2;
            }
            if(length > 0)
            {
                length--;
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = leftArray[i] * rightArray[i];
        }
        return nums;
    }
}
