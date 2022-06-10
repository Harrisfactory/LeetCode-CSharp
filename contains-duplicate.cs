public class Solution {
    public bool ContainsDuplicate(int[] nums) {

        //create dictionary to store unique numbers
        Dictionary<int, int> unique_nums = new Dictionary<int, int>();

        //check if a number exists already in dictionary
        foreach(int number in nums)
        {
            if(unique_nums.ContainsKey(number)){
                return true;
            } else {
                unique_nums.Add(number, 1);
            }
        }
        //all numbers are unique
        return false;
    }
}
