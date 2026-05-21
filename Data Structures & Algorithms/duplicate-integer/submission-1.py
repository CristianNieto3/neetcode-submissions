class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
            seen = set()

            for num in nums: #loop thru the array
                if num in seen: #if the number is in the array
                    return True
                seen.add(num)
            return False