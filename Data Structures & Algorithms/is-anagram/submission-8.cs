public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length){
            return false;
        }


        Dictionary<char,int> countS = new Dictionary<char,int>();
        Dictionary<char,int> countT = new Dictionary<char,int>();

        foreach(char c in s){
            if(countS.ContainsKey(c)){
                countS[c]++;
            } else {
                countS[c] = 1;
            }
        }

        foreach(char c in t){
            if(countT.ContainsKey(c)){
                countT[c]++;
            } else {
                countT[c] = 1;
            }
        }

        foreach(KeyValuePair<char,int> kvp in countS) {
            // if countT does not have the letter or has a different count they dont match up
            if(!countT.ContainsKey(kvp.Key) || countT[kvp.Key] != kvp.Value){
                return false;
            }
        }
        return true;


    }
}
