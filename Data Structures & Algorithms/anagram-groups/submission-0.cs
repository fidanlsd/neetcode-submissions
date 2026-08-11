public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if(strs.Length==0) return new List<List<string>>();
        if(strs.Length == 1) return new List<List<string>>(){strs.ToList()};
        var res = new Dictionary<string, List<string>>();
        foreach(var s in strs)
        {
            int[] count = new int[26];
            foreach(char c in s)
        {
            count[c-'a']++;
        }
        string key = string.Join(",", count);
        if(!res.ContainsKey(key))
        res[key] = new List<string>();
        
        res[key].Add(s);
        }
        return res.Values.ToList<List<string>>();
    }
}

