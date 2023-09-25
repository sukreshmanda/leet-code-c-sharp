// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

// 1. Two Sum
var solution = new Solution();
Debug.Assert(solution.TwoSum([2,7,11,15], 9).SequenceEqual([0, 1]));
Debug.Assert(solution.TwoSum([3,2,4], 6).SequenceEqual([1, 2]));
Debug.Assert(solution.TwoSum([3,3], 6).SequenceEqual([0, 1]));
