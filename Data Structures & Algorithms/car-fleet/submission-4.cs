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
        dictTime = dictTime.OrderByDescending(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
        foreach(var item in dictTime)
        {
            if(index == 0)
            {
                fleetFinal++;
                maxTimeCurrent = item.Value;
            }
            else
            {
                if(item.Value > maxTimeCurrent)
                {
                    fleetFinal++;
                    maxTimeCurrent = item.Value;
                }
            }
            index++;
        }

        return fleetFinal;
    }
}
