public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        int [] res = new int[k];
        var count = new Dictionary<int,int>();

        foreach(var num in nums){
            if(count.ContainsKey(num)){
                count[num]++;
            } else {
                count[num] = 1;
            }
        }

        var heap = new PriorityQueue<int,int>();
        foreach(var entry in count){
            heap.Enqueue(entry.Key, entry.Value);
            if(heap.Count > k) {
                heap.Dequeue();
            }
        }
        for(int i = 0; i < k; i++) {
            res[i] = heap.Dequeue();
        }

        return res;

        
    }
}
