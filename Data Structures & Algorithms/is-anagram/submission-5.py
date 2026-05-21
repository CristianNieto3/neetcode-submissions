class Solution:
    def isAnagram(self, s: str, t: str) -> bool:

        if len(s) != len(t):
            return False

        sorted_s = sorted(s)
        sorted_t = sorted(t)

        for i in sorted_s:
            for j in sorted_t:
                if sorted_s == sorted_t:

                    return True
        return False
        