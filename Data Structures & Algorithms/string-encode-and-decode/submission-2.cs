public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder strBuilder  = new StringBuilder();
        
        for(int i = 0; i < strs.Count; i++)
        {
            strBuilder.Append(strs[i].Length.ToString());
            strBuilder.Append("#");
            strBuilder.Append(strs[i]);
        }
        return strBuilder.ToString();
    }

    public List<string> Decode(string s) {
        List<string> listReturn = new List<string>();
        int i = 0;
        while (i < s.Length)
        {
            int positionIndex = s.IndexOf("#", i);

            int numberCharacter = Int32.Parse(s.Substring(i, positionIndex - i));

            listReturn.Add(s.Substring(positionIndex + 1, numberCharacter));

            i = 1 + positionIndex + numberCharacter;
        }
        return listReturn;
   }
}
