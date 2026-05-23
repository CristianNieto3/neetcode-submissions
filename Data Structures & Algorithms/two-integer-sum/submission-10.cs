public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var prevMap = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++){
            var difference = target - nums[i];
            if(prevMap.ContainsKey(difference)){
                return new int []{prevMap[difference],i};
            }

            prevMap[nums[i]] = i;
        }

        return null;

    }
}
