// two pointer solution , no extra memory is used!
public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0, r = s.Length - 1;
        //while in bounds...
        while(l < r){
            // if L is on a space keep going
            while(l < r && !AlphaNum(s[l])){
                l++;
            }
            // if R is on a space keep going
            while(l < r && !AlphaNum(s[r])){
                r--;
            }

            // if they are both on a letter and it is not the same return false
            if(char.ToLower(s[l]) != char.ToLower(s[r])){
                return false;
            }
            // otherwise keep comparing and check again
            l++;
            r--;
        }
        //made it through checks , it is true!
        return true;
        
    }



    //alphanum check!
    public bool AlphaNum(char c){
        return (c >= 'A' && c <= 'Z' ||
                c >= 'a' && c <= 'z' ||
                c >= '0' && c <= '9');
    }
}
