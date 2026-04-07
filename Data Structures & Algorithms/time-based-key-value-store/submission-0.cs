public class TimeMap {
    public Dictionary<string, List<(string, int)>> dictTimeBase = new Dictionary<string, List<(string, int)>>();

    public TimeMap()
    {

    }

    public void Set(string key, string value, int timestamp)
    {
        if (!dictTimeBase.ContainsKey(key))
        {
            dictTimeBase[key] = new List<(string, int)>();
        }

        dictTimeBase[key].Add((value, timestamp));
    }
    
    public string Get(string key, int timestamp) {
        if(!dictTimeBase.ContainsKey(key))
        {
            return "";
        }
        else
        {
            var item = dictTimeBase[key].Where(item => item.Item2 <= timestamp).LastOrDefault();
            return item.Item1 ?? "";
        }
    }
}
