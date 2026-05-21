class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:

        n = len(numbers) # just a variable to put R at end of numbers list
        l = 0  # starts left pointer off at the first value
        r = n - 1 # starts right pointer off at the last value
      


        while l < r:    #while left is smaller than right (bc it is sorted)
            summ = numbers[l] + numbers[r]  # the summ is the pointers added
            if summ == target:          # if the sum is the target then return l and r +1 since it is 1 indexed array.
                return [l+1, r+1]
            elif summ < target:    # else if the summ is smaller than the target , move the left pointer up one to increase sum
                l +=1
            else:  # else if the summ is larger, move the right pointer down to a smaller number to decrease the sum
                r -=1
        