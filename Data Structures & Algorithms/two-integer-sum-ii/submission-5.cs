public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0, r = numbers.Length - 1;

        while(l < r){
            int currSum = numbers[l] + numbers[r];

            if(currSum < target){
                l++;
            }
            if(currSum > target){
                r--;
            }
            if(currSum == target){
                return new int[] {l + 1, r + 1};
            }
        }

        return new int [0];
        
    }
}
