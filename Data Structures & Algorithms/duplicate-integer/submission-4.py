class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:


        seen = set()


        for x in range(len(nums)): # x is going to loop through to the end of nums
            if nums[x] in seen:    # if x is in the set
                return True  # return true
            else: 
                seen.add(nums[x]) # else add and keep going
    
        return False
        
        
                

          