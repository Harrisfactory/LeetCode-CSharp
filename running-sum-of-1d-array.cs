public class Solution {
    public int[] RunningSum(int[] nums) {

        //running sum to be added onto numbers
        int running_sum = 0;

        //dynamic list for adding new nums
        List<int> summed_nums = new List<int>();

        //add running sum to each iteration
        foreach(int number in nums)
        {
            summed_nums.Add(number + running_sum);
            running_sum += number;
        }

        //convert list to array before returning
        int[] final_nums = summed_nums.ToArray();
        return final_nums;
    }
}
