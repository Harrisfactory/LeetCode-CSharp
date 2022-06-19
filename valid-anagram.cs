public class Solution {
    public bool IsAnagram(string s, string t) {
        
        Dictionary<char, int> map = new Dictionary<char, int>();
        
        foreach(char letter in s) {
            if(map.ContainsKey(letter)) {
                map[letter] += 1;
            } else {
                map.Add(letter, 1);
            }
        }
        
        
        foreach(char letter in t) {
            if(map.ContainsKey(letter)) {
                map[letter] -= 1;
                if(map[letter] == 0) {
                    map.Remove(letter);
                }
            } else {
                return false;
            }
        }
        
        
        if(map.Count == 0) {
            return true;
        } else {
            return false;
        }
    }
}