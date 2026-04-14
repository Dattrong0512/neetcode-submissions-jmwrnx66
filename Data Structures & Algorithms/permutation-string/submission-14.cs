public class Solution {
    public bool CheckInclusion(string s1, string s2) 
    {
        int[] rightArray = new int[26];
        int[] windows = new int[26];
        if (s1.Length > s2.Length) return false;
        for(int i = 0; i < s1.Length; i++)
        {
            rightArray[s1[i] - 'a']++;
            windows[s2[i] - 'a']++;
        }

        int matches = 0;
        for(int i = 0; i < 26; i++)
        {
            if(rightArray[i] == windows[i])
            {
                matches++;
            }
        }
        int left = 0;
        for(int right = s1.Length; right < s2.Length; right++)
        {
            if(matches == 26)
                return true;
            int index = s2[right] - 'a';
            windows[index]++;
            if(windows[index] == rightArray[index])
            {
                matches++;
            }
            else if(windows[index] == rightArray[index] + 1)
            {
                matches--;
            }

            int indexL = s2[left] - 'a';
            windows[indexL]--;
            if(windows[indexL] == rightArray[indexL])
            {
                matches++;
            }
            else if(windows[indexL] == rightArray[indexL] - 1)
            {
                matches--;
            }

            left++;
        }

        return matches == 26;
    }
}