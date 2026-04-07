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
            List<(string, int)> valueStore = dictTimeBase[key];
            return BinarySearch(timestamp, valueStore);
        }
    }
    public string BinarySearch(int targetTimeStamp, List<(string, int)> valueStore)
    {
        int left = 0;
        int right = valueStore.Count - 1;
        string valueReturn = "";
        while(left <= right)
        {
            int mid = left + (right - left)/2;
            (string, int) itemValue = valueStore[mid];
            if(targetTimeStamp >= itemValue.Item2)
            {
                left = mid + 1;
                valueReturn = itemValue.Item1;
            }
            else{
                right = mid - 1;
            }
        }
        return valueReturn;
    }
}