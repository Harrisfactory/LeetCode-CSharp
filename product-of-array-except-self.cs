public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int array_length = nums.Length;
        
        int[] left_products = new int[array_length];
        int[] right_products = new int[array_length];
        
        int[] output = new int[array_length];
        
        left_products[0] = 1;
        right_products[array_length - 1] = 1;
        
        for(int i = 1; i < array_length; i++) {
            left_products[i] = nums[i - 1] * left_products[i - 1];
        }
        
        for(int i = array_length -2; i >= 0; i--) {
            right_products[i] = nums[i + 1] * right_products[i + 1];
        }
        
        for(int i = 0; i < array_length; i++) {
            output[i] = left_products[i] * right_products[i];
        }
        
        return output;
    }
}