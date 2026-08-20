public class Solution {
    public bool hasDuplicate(int[] nums) {
        // set , for each # in the array, check to see if in the set, if it is, then we return T else return F

        HashSet<int> seen = new();

        foreach (int num in nums){
            if(seen.Contains(num)){
                return true;
            } else {
                seen.Add(num);
            }
        }
        
        return false;
    }
}