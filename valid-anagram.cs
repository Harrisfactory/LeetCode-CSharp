public class Solution {
    public bool IsAnagram(string s, string t) {
        
        if(s.Length != t.Length) {
            return false;
        }
        
        //count the times each element appears
        Dictionary<char, int> map1 = new Dictionary<char, int>();
        
        //increment each element as it appears
        foreach(char letter in s) {
            if (map1.ContainsKey(letter)) {
                map1[letter] += 1;
            } else {
                map1.Add(letter, 1);
            }
        }
        
        //decrement each element as it appears
        foreach(char letter in t) {
            if (map1.ContainsKey(letter)) {
                map1[letter] -= 1;
            }
        }
        
        //check if any non 0 elements exits
        foreach(KeyValuePair<char, int> element in map1){
            if(element.Value != 0){
                return false;
            }
        }
        
        // is anagram
        return true;
    }
}