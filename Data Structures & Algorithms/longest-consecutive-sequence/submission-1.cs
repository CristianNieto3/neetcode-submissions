public class Solution {
    public int LongestConsecutive(int[] nums) {
        // turn the array into a set
        HashSet<int> numSet = new HashSet<int>(nums);
        // initialize longest variable
        int longest = 0;

        foreach(int num in numSet){
            // if current num has no left neighbor, it is start of a sequence. Length = 1
            if(!numSet.Contains(num - 1)) {
                int length = 1;
                // while set contains the next number higher increase the length
                while(numSet.Contains(num + length)){
                    length++;
                }
                // longest is == to the max # between longest and length.
                longest = Math.Max(longest, length);
            }
        }
        return longest;
    }
}
