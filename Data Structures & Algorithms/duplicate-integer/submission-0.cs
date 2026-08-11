public class Solution {
    public bool hasDuplicate(int[] nums) {
        if(nums.Length<=1)
        return false;
        HashSet<int> hashSet = new();
        foreach(var item in nums)
        {
        if(hashSet.Contains(item)) return true;
        else hashSet.Add(item);
        }
        return false;
       
    }
}