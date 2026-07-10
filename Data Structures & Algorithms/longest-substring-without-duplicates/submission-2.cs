public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet <char> seen = new(); // needs to be char since it is letter by letter
        int l = 0;
        int res = 0;

        for(int r = 0; r < s.Length; r++) {
            while(seen.Contains(s[r])){ // while seen contains the most right letter
                seen.Remove(s[l]); // remove the letter at 'l' until you hit a clean letter
                l++; // move l up
            }
            seen.Add(s[r]); // else lets add r to the set
            res = Math.Max(res, r - l + 1); // take either the current res, or if the current length is bigger take that
        }
        return res;

    }
}
