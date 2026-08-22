public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // res array is [_,_]
        int [] res = new int[k];
        var count = new Dictionary<int,int>();
        // counting each value
        foreach(var num in nums){
            if(count.ContainsKey(num)){
                count[num]++;
            } else {
                count[num] = 1;
            }
        }

        //priority queue holds top 2 occurences
        var heap = new PriorityQueue<int,int>();
        foreach(var entry in count){
            heap.Enqueue(entry.Key, entry.Value);
            // if heap count is larger than k, then drop the less freq #
            if(heap.Count > k) {
                heap.Dequeue();
            }
        }

        // go through the heap and then add that to array
        for(int i = 0; i < k; i++) {
            res[i] = heap.Dequeue();
        }

        return res;

        
    }
}
