public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        //list of anagrams we will add to
        List<IList<string>> anagrams = new List<IList<string>>();
        //map will contain sorted keys to decide which bucket of anagrams to add to
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        
        //go through each word in array and sort to compare to dict keys
        foreach(string word in strs) {
            char[] characters = word.ToArray();
            Array.Sort(characters);
            string sorted_word = new string(characters);
            
            if(map.ContainsKey(sorted_word)) {
                map[sorted_word].Add(word);
                } else {
                    map.Add(sorted_word, new List<string>());
                    map[sorted_word].Add(word);
                }
            
        }
        
        //extract anagram groups and place them into list
        foreach(var item in map){
            anagrams.Add(item.Value);
        }
        
        return anagrams;
    }
}