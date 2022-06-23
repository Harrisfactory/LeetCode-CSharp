using  System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {

        //strip string into requirements
        s = s.Replace(" ", "");
        s = Regex.Replace(s, "[^A-Za-z0-9]", "");
        s = s.ToUpper();

        int L = 0;
        int R = s.Length - 1;

        while(L < R) {
            if (s[L] == s[R]) {
                L++;
                R--;
            } else {
                return false;
            }
        }

        return true;
    }
}
