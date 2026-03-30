public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, List<string>>();

        foreach (string s in strs) {
            char[] charArray = s.ToCharArray();

            Array.Sort(charArray);
            
            string sortedKey = new string(charArray);

            if (!groups.ContainsKey(sortedKey)) {
                groups[sortedKey] = new List<string>();
            }

            groups[sortedKey].Add(s);
        }

        List<List<string>> listReturn = new List<List<string>>();

        foreach(var item in groups)
        {
            listReturn.Add(item.Value);
        }

        return listReturn;
    }
}
