public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // 1. Pre-allocate capacity: 
        // By passing nums.Length, the dictionary reserves the exact amount of memory needed upfront.
        var map = new Dictionary<int, int>(nums.Length);

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];

            // 2. TryGetValue: 
            // This method is highly optimized. It checks if the key exists AND retrieves the value in a single operation.
            if (map.TryGetValue(complement, out int index)) {
                return new int[] { index, i };
            }

            // 3. Store the value:
            // We save the current number as the Key, and its array index as the Value.
            map[nums[i]] = i;
        }

        // 4. Array.Empty<int>():
        // Returns a globally shared empty array instead of allocating a brand new one in memory.
        return Array.Empty<int>();
    }
}

// Ive optimised this code with ai 
