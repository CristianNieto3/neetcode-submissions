class Solution:
    def characterReplacement(self, s: str, k: int) -> int:
        count = {} # keep count
        res = 0  # returning the result

        l = 0 # l ptr
        maxf = 0 # is our max frequency of letter in the window
        for r in range(len(s)): # r is looping through
            count[s[r]] = 1 + count.get(s[r], 0)   # we add to frequency while looping, or return 0 for other values as default
            maxf = max(maxf, count[s[r]]) # maxf is == to itself or the current letter its on frequency

            while (r - l + 1) - maxf > k: # while window is invalid (more inversions than allowed)
                count[s[l]] -= 1 #decrement the count of the l ptr
                l += 1 # move l ptr to right to create new window
            res = max(res, r - l + 1)   # res is equal to itself or the length of valid window

        return res
   

        

        
       

            



        