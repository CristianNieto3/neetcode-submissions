class Solution {
    public boolean isAnagram(String s, String t) {
        if(s.length() != t.length()) {
            return false;
        }

        char[] charArr = s.toCharArray();
        char[] charArr1 = t.toCharArray();

        Arrays.sort(charArr);
        Arrays.sort(charArr1);

        return Arrays.equals(charArr, charArr1);

    
    }
}
