/*
 Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
 */

int[] inputNumbers = [2, 7, 11, 15 ];
var targetNumber = 9;

nestedLoop();

void nestedLoop()
{
    for (var i = 0; i < inputNumbers.Length - 1; i++)
    {
        for (var j = 1; j < inputNumbers.Length; j++)
        {
            // perform skips
            if (j <= i)
            {
                continue;
            }

            // Compare sum and target
            if (inputNumbers[i] + inputNumbers[j] == targetNumber)
            {
                Console.WriteLine(new int[] { i, j });

                return;
            }
        }
    }

    Console.WriteLine("No macthes found.");
}


