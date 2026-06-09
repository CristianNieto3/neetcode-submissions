public class Solution {
    public bool IsPalindrome(string s) {
        // only consider alphanumeric characters, ignore cases
        string newStr = "";

        foreach(char c in s){
            if (char.IsLetterOrDigit(c)){
                newStr += char.ToLower(c);
            }
          
        }

        return newStr == new string(newStr.Reverse().ToArray());
        
        
    }
}
