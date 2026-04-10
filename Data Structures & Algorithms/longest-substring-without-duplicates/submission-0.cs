public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> storeDup = new HashSet<char>();
        int maxLength = 0;
        int left = 0;
        for(int right = 0; right < s.Length; right++)
        {
            if(storeDup.Contains(s[right]))
            {
                while(storeDup.Contains(s[right]))
                {
                    storeDup.Remove(s[left]);
                    left++;
                }
            }
            storeDup.Add(s[right]);
            maxLength = storeDup.Count > maxLength ? storeDup.Count : maxLength;
        }

        return maxLength;
    }
}