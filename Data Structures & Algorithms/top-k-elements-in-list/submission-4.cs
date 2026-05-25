public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        Dictionary<int,int> count = new Dictionary<int,int>();

        List<int> [] freq = new List<int>[nums.Length + 1];

        for(int i = 0; i < freq.Length;i++){
            freq[i] = new List<int>();
        }

        foreach(int n in nums) {
            if(count.ContainsKey(n)){
                count[n]++;
            } else {
                count[n] = 1;
            }
        }

        // so now its freq[3] = 3
        foreach(var entry in count){
            freq[entry.Value].Add(entry.Key);
        }

        // array that is == to size of k
        int [] res = new int[k];
        // index tracker
        int index = 0;


        for(int i = freq.Length - 1; i > 0 && index < k; i--){
            foreach(int n in freq[i]){
                res[index] = n;
                index++;
            }
            if(index == k){
                return res;
            }
            
        }
        return res;
    }
}
