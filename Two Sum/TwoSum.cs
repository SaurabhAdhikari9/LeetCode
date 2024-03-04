/**
Two Sum

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 

Constraints:

2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.

**/


// problem url" https://leetcode.com/problems/two-sum/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        // iteration upto length of nums array with index value 
        for(int i = 0; i<nums.Length; i++){
            // second iteration (j) for second number of sum (i.e. b of a + b) and 
            // first iteration (i) will be the first number of the sum (i.e. a of a + b)
            for(int j =0; j<i; j++){
                if((nums[i] + nums[j]) == target){ // checking the sums of the two term with target value
                     return new int[]{i,j} ; // return index of two term
                }
            }
        }
        return null; // return null if sums not matched with target value
    }
}