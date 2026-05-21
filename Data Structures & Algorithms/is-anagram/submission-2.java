

class Solution {
    public boolean isAnagram(String s, String t) {
        if(s.length() != t.length()){  //if they arent the same length then it is wrong
            return false;
        }

       char [] charArray = s.toCharArray(); //put s into an array
       char [] charArray2 = t.toCharArray(); //put t into an array

       Arrays.sort(charArray);  //sort both of them
       Arrays.sort(charArray2);

       return Arrays.equals(charArray, charArray2); //return and compare




    }
}
