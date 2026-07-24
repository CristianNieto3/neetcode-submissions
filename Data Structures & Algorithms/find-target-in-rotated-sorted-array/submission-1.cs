public class Solution {
    public int Search(int[] nums, int target) {

        int l = 0;
        int r = nums.Length - 1;

        // find middle (check if mid is target)
        while(l <= r) {
            int mid = (l + r) / 2;
            if(target == nums[mid]){
                return mid;
            }

            // if left half is sorted...
            if(nums[l] <= nums[mid]) {
                //Check if target is outside the range. 
                if(target > nums[mid] || target < nums[l]) {
                    //Target isn't here. Search right half. 
                    l = mid + 1;
                } else {
                    //Target is in the left half. Eliminate the right half. 
                    r = mid - 1;
                }
                //Right half must be sorted. Check right half. 
            } else {
                //Check if target is outside the right half range. 
                if(target < nums[mid] || target > nums[r]){
                    //Not here. Search left half. 
                    r = mid - 1;
                } else {
                    //Target is in the right half, so eliminate the left half. 
                    l = mid + 1;
                }
            }
                

            }   
            return -1;
        }
        
    }

