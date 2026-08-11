public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    if(nums.Length<=1) return null;
    Dictionary<int, int> indices = new();
    for(int i = 0 ; i<nums.Length; i++)
    {
        int diff = target - nums[i];
        if(indices.ContainsKey(diff))
            return new int[] { indices[diff], i };
        indices[nums[i]]=i;
    }
    return null;
    }
}