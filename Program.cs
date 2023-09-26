// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using Nodes;

// 1. Two Sum
var solution1 = new TwoSum.Solution();
Debug.Assert(solution1.TwoSum([2, 7, 11, 15], 9).SequenceEqual([0, 1]));
Debug.Assert(solution1.TwoSum([3, 2, 4], 6).SequenceEqual([1, 2]));
Debug.Assert(solution1.TwoSum([3, 3], 6).SequenceEqual([0, 1]));


//2. Add two number
var solution2 = new AddTwoNumbers.AddTwoNumbersSolution();
ListNode listNode1 = solution2.AddTwoNumbers(new ListNode(2, new ListNode(4, new ListNode(3))),
                        new ListNode(5, new ListNode(6, new ListNode(4))));
ListNode result1 = new ListNode(7, new ListNode(0, new ListNode(8)));
Debug.Assert(listNode1.Equals(result1));

ListNode listNode2 = solution2.AddTwoNumbers(new ListNode(0), new ListNode(0));
ListNode result2 = new ListNode(0);
Debug.Assert(listNode2.Equals(result2));

ListNode listNode3 = solution2.AddTwoNumbers(new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))))))),
                                            new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))));
ListNode result3 = new ListNode(8, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(1))))))));
Debug.Assert(listNode3.Equals(result3));