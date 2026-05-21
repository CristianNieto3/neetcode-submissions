class Solution {
    public int[] twoSum(int[] nums, int target) {
       HashMap<Integer,Integer> seen = new HashMap<>();

       for(int i = 0; i < nums.length; i++) {
        int num = nums[i];
        int diff = target - num; 

        if(seen.containsKey(diff)) {
            return new int[] {seen.get(diff), i};
        }
        seen.put(num, i);
       }
        return new int[]{};

    }
}

//Hashmap to store the differences
//for loop : num is == to current iteration at i
//diff is target number - the current index at i

//if the hashmap contains the key we are looking for: return it in a new arrayy: return new int[] {seen.get(diff), i};
//} otherwise put these combos into the hashmap

