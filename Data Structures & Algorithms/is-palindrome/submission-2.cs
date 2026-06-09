// built in function solutions , extra memory by building new string
public class Solution {
    public bool IsPalindrome(string s) {
        // only consider alphanumeric characters, ignore cases
        string newStr = "";
        // for each letter in S
        foreach(char c in s){
            // if it is valid then turn it lower case and append to newStr
            if (char.IsLetterOrDigit(c)){
                newStr += char.ToLower(c);
            }
          
        }
        // compare new string vs reverse string , will return T or F
        return newStr == new string(newStr.Reverse().ToArray());
        
        
    }
}
