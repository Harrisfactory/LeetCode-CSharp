public class Solution {
    public int[] TwoSum(int[] numbers, int target) {

        int[] answer = new int[2];

        int i = 0;

        int j = numbers.Length - 1;

        while(i < j) {
            if(numbers[i] + numbers[j] == target) {
                answer[0] = i + 1;
                answer[1] = j + 1;
                return answer;
            } else if(numbers[i] + numbers[j] > target) {
                j--;
            } else {
                i++;
            }
        }

        return answer;
    }
}
