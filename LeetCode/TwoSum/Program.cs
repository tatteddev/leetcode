//Question:
//You are given an array of integers nums and an integer target. Return indices of the two numbers such that they add up to target.

//Assume that each input has exactly one solution.

//You may not use the same element twice.

//You can return the answer in any order.

//Example:
//Input: nums = [2, 7, 11, 15], target = 9
//Output: [0, 1]

var nums = new int[] { 1, 2, 3, 4, 5, 6 };
var target = 11;
var seen = new Dictionary<int, int>();

for (int i = 0; i < nums.Length; i++)
{
    var need = target - nums[i];
    if (seen.ContainsKey(need))
    {
        Console.WriteLine($"[{seen[need]}, {i}]");
        break;
    }
    else
    {
        Console.WriteLine($"Need {need} for {nums[i]} at index {i}");
    }
    seen[nums[i]] = i;
    foreach (var item in seen)
    {
        Console.WriteLine($"Seen {item.Key} at index {item.Value}");
    }
}