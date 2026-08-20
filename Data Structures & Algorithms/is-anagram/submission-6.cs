public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length) {
            return false;
        }

        Dictionary<char,int> sTable = new Dictionary<char, int> ();
        Dictionary<char,int> tTable = new Dictionary<char, int> ();

        foreach(char c in s){
            if(sTable.ContainsKey(c)){
                sTable[c]++;
            } else {
                sTable[c] = 1;
            }

        }

        foreach(char c in t){
            if(tTable.ContainsKey(c)){
                tTable[c]++;
            } else {
                tTable[c] = 1;
            }
        }

        foreach(KeyValuePair<char,int> kvp in sTable) {
            if(!tTable.ContainsKey(kvp.Key) || tTable[kvp.Key] != kvp.Value) {
                return false;
            }
        }

        return true;



    }
}
