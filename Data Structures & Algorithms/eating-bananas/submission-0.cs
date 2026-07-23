public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {

        int l = 1;
        int r = piles.Max();
        int res = r;

        while(l <= r){
            int k = (l + r) / 2;

            long totalTime = 0;
            // loop through the piles
            foreach(int p in piles) {
                
            //total time == p (current pile) / (current m ptr)
                totalTime += (int)Math.Ceiling((double) p / k);
            }
            if(totalTime <= h) { // potential answer! Store it, search under it
                res = k;
                r = k - 1;
            } else {
                l = k + 1;
            }

        }

        return res;
        
    }
}
