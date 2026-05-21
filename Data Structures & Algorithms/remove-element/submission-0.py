class Solution:
    def removeElement(self, nums: List[int], val: int) -> int:
        k = 0

        for i in range(len(nums)): # LOOP through the array 
            if nums[i] != val:   # if nums is not == to VAL
                nums[k] = nums[i]   #then nums[k] is now the number that isnt == VAL
                k += 1   # increment k to the next number and repeat
        return k






        
