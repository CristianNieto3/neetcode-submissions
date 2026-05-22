public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {


        // dictionary stores each number and times it appears
        // number -> frequency
        Dictionary<int, int> count = new Dictionary<int, int>();
        //This array stores lists of numbers by their frequency
        // Index = frequency
        // freq[3] stores numbers that appear 3 times
        List<int>[] freq = new List<int>[nums.Length + 1];
        // create the buckets with empty list so we can insert later
        for (int i = 0; i < freq.Length; i++) {
            freq[i] = new List<int>();
        }

        // count how many times n appears in nums
        foreach(int n in nums){
            // if it exists, increase the count
            if(count.ContainsKey(n)){
                count[n]++;
                //else, add it and set value to 1
            }else{
                count[n] = 1;
            }
        }


        // move the numbers from count into freq
        // entry.Value = frequency
        // entry.Key = actual number
        // freq[frequency] = [number that matches the frequency]
        foreach(var entry in count){
            freq[entry.Value].Add(entry.Key);
        }

        //create result array size k
        int[] res = new int[k];
        // keep track of current index in res array
        int index = 0;

        // starting from the back of array. As long as i > 0 and less than K, work backwards
        for(int i = freq.Length - 1; i > 0 && index < k; i--) {
            // for each n in freq[i]
            // add to result array starting from the back
            foreach(int n in freq[i]){
                res[index] = n;
                index++;
                // if we hit the k limit then return the res array
                if(index == k){
                    return res;
                }
            }
        }

        // return the array
        return res;



        
        
    }
}
