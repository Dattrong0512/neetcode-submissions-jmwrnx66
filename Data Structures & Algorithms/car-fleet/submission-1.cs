public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        
        Dictionary<int, double> dictTime = new Dictionary<int, double>();

        for(int i = 0; i < position.Length; i++)
        {
            double finalTime = (double)(target - position[i]) / speed[i];
            dictTime.Add(position[i], finalTime);
        }

        int fleetFinal = 0;
        int index = 0;
        double maxTimeCurrent = 0;

        dictTime = dictTime
            .OrderByDescending(x => x.Key) // ✅ FIX
            .ToDictionary(x => x.Key, x => x.Value);

        foreach(var item in dictTime)
        {
            if(index == 0)
            {
                maxTimeCurrent = item.Value;
                fleetFinal++; // ✅ FIX
            }
            else
            {
                if(item.Value > maxTimeCurrent)
                {
                    fleetFinal++;
                    maxTimeCurrent = item.Value;
                }
            }
            index++; // ✅ FIX
        }

        return fleetFinal;
    }
}