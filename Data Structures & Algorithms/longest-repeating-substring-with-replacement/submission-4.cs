public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int[] storeCharacter = new int[26];
        int maxLength = 0;
        int maxCount = 0;
        int left = 0;
        for(int right = 0; right < s.Length; right++)
        {
            storeCharacter[s[right] - 'A']++;
            maxCount = maxCount > storeCharacter[s[right] - 'A'] ? maxCount : storeCharacter[s[right] - 'A'];
            while((right - left + 1) - maxCount > k)
            {
                storeCharacter[s[left] - 'A']--;
                left++;
            }
            maxLength =  Math.Max(right - left + 1, maxLength);
        }
        return maxLength;
    }
}