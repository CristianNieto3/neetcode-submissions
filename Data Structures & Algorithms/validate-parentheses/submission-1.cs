public class Solution {
    public bool IsValid(string s) {
        // create the stack
        Stack<char> stack = new Stack<char>();
        // Key:Value, map the close to the open
        Dictionary<char, char> closeToOpen = new Dictionary<char, char> {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };
        // for each char in s loop through
        foreach(char c in s){
            // check if current character is a closing bracket
            if(closeToOpen.ContainsKey(c)){
                // There has to be an opening bracket to match. 
                // Peek looks at stack without removing it
                if(stack.Count > 0 && stack.Peek() == closeToOpen[c]){
                    // if there is a match remove the opening bracket and move on
                    stack.Pop();
                } else {
                    // string is invalid
                    return false;
                }
            } else {
                // push onto the stack and wait for closing bracket to match
                stack.Push(c);
            }
        }
        // checks if every bracket got matched
        return stack.Count == 0;
    }
}
