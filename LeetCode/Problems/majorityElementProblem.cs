using System;

public static class majorityElementProblem
{
  // Given an array nums of size n, return the majority element.
  // The majority element is the element that appears more than ⌊n / 2⌋ times.
  // You may assume that the majority element always exists in the array
  public static int implementation(int[] nums)
  {
    Array.Sort(nums);
    int middle = (nums.Length / 2);
    return nums[middle]; 
  }
}

