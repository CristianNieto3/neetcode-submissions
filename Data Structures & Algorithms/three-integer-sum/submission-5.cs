public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums); // sort the array 
        List<List<int>> res = new List<List<int>>(); // result array we are gonna return

        for(int i = 0; i < nums.Length; i++) {
            // if the current first num is +, the break cuz it cant == 0
            if(nums[i] > 0) break;
            // skip duplicates
            if(i > 0 && nums[i] == nums[i - 1]) continue;
            // left pointer right after i
            int l = i + 1;
            //right pointer at the end 
            int r = nums.Length - 1;

            // search for the other two numbers
            while(l < r){
                // calculate the sum of the numbers
                int threeSum = nums[i] + nums[l] + nums[r];
                // sum to large, move right ptr left
                if(threeSum > 0){
                    r--;
                } else if (threeSum < 0){ // sum to small, move left ptr right
                    l++;
                } else { // found 3 numbers that == 0
                    // add triplets to the results
                    res.Add(new List<int> {nums[i], nums[l], nums[r]});
                    // move ptrs inwards
                    l++;
                    r--;
                    // skip duplicate left values
                    while(l < r && nums[l] == nums[l - 1]){
                        l++;
                    }
                }
            }
        }
        return res;
        
    }
}
