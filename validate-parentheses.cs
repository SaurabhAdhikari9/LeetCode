public class Solution {
    public bool IsValid(string s) {
        // looping untill string s has valid parentheses.
        while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
        {
            s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
            // removing valid parentheses, remain invalid cases only.
        }
        return s.Length == 0;
    }
}