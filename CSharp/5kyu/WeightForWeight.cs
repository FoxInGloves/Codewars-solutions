using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharp._5kyu;

public class WeightForWeight
{
    public static string orderWeight(string strng) {
        var nums = strng.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
        var weightNums = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
        {
            weightNums[i] = nums[i].ToString().Sum(c => c - '0');
        }

        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (weightNums[i] > weightNums[i + 1] || 
                weightNums[i] == weightNums[i + 1] & string.CompareOrdinal(nums[i].ToString(), nums[i + 1].ToString()) > 0)
            {
                (weightNums[i], weightNums[i + 1]) = (weightNums[i + 1], weightNums[i]);
                (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
                i = -1;
            }
        }

        return string.Join(" ", nums);
    }
}