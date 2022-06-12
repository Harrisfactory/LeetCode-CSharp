public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        //set up return value
        List<int> frequent_elements = new List<int>();
        
        //Create dictionary to count each elements frequency
        Dictionary<int, int> map = new Dictionary<int, int>();
        
        //initial current_max_key
        int max_key = 0;
        int max_value = 0;
        
        //add new and repeated counts foreach element
        foreach(int number in nums) {
            if(map.ContainsKey(number)) {
                map[number] += 1;
            } else {
                map.Add(number, 1);
            }
        }
        
        //build top k array and remove from map as you move
        while(k > 0) {
            foreach(var item in map){
                if(item.Value > max_value) {
                    max_key = item.Key;
                    max_value = item.Value;
                }
            }
            frequent_elements.Add(max_key);
            map.Remove(max_key);
            max_key = 0;
            max_value = 0;
            k--;
        }
        
        //convert list to array
        return frequent_elements.ToArray();
    }
}