public class LRUCache {

    public List<(int, int)> listLRU = new List<(int, int)>();
    public int capacity;

    public LRUCache(int _capacity) {
        capacity = _capacity;
    }
    
    public int Get(int key) {
        for(int i = 0; i < listLRU.Count; i++)
        {
            if(listLRU[i].Item1 == key)
            {
                var temp = (key, listLRU[i].Item2);
                listLRU.RemoveAt(i);
                listLRU.Add(temp);
                return temp.Item2;
            }
        }        
        return -1;
    }
    
    public void Put(int key, int value) 
    {
        for(int i = 0; i < listLRU.Count; i++)
        {
            if(listLRU[i].Item1 == key)
            {
                listLRU.RemoveAt(i);
                listLRU.Add((key, value));
                return;
            }
        }

        if(listLRU.Count == capacity)
        {
            listLRU.RemoveAt(0);
        }

        listLRU.Add((key, value));
    }
}
