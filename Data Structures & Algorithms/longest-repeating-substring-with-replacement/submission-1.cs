//For each possible target character:
    //Expand the window with r.
   // Count how many target characters are inside.
    //If replacements needed > k, move l forward until valid.
    //Track the biggest valid window.


public class Solution {
    public int CharacterReplacement(string s, int k) {
        HashSet<char> charSet = new(s); // where we will keep the chars from the string

        int res = 0; // store the longest repeating char replacement

        foreach(char c in charSet) { //loop through each character
            int count = 0;
            int l = 0;

            for(int r = 0; r < s.Length; r++) { // loop through the string
                if(s[r] == c){ // if it is already in the set increase the count
                    count++;
                }

               while((r - l + 1) - count > k) { 
                //While the number of replacements needed is more than k, shrink the window from the left.
                if(s[l] == c) {
                    count--;   // if leaving window is a target char, reduce count
                }
                l++; // otherwise move on w no problem
               }
               res = Math.Max(res, r - l + 1);  // take the max of either current res or the curr window
            }
        }
       return res;

        
    }
}
