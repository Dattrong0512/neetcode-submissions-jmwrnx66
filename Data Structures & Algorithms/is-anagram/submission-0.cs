public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> dic1 = new Dictionary<char, int>();
        Dictionary<char, int> dic2 = new Dictionary<char, int>();
        for(int i = 0; i< s.Length; i++)
        {
            dic1[s[i]] = dic1.GetValueOrDefault(s[i], 0) + 1;
            dic2[t[i]] = dic2.GetValueOrDefault(t[i], 0) + 1;
        }

        foreach(var item in dic1)
        {
            if((!dic2.ContainsKey(item.Key) || (dic2[item.Key] != item.Value)))
            {
                return false;
            }
        }
        return true;
    }
}
