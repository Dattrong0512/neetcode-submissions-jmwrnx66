public class Solution {
    public int MinEatingSpeed(int[] piles, int h) 
    {
        int left = 1;
        int right = piles[0];
        for(int i = 1; i < piles.Length; i++)
        {
            right = piles[i] > right ? piles[i] : right;
        }

        while(left < right)
        {
            int mid = left + (right - left) / 2;
            if(IsEnoughHour(piles, h, mid))
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }
        return left;
    }

    public bool IsEnoughHour(int[] piles, int h, int k)
    {
        int hour = 0;
        for(int i = 0; i < piles.Length; i++)
        {
            hour += Convert.ToInt32(Math.Ceiling((double)piles[i]/k));
            if(hour > h)
            {
                return false;
            }
        }

        return hour <= h;
    }
}

