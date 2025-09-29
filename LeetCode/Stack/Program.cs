//Question: Valid Parentheses

//You are given a string s containing just the characters '(', ')', '{', '}', '[', and ']'.

//Return true if the input string is valid.

//An input string is valid if:

//Open brackets must be closed by the same type of brackets.

//Open brackets must be closed in the correct order.

//Every close bracket has a corresponding open bracket of the same type.

//Example 1:
//Input: s = "()"
//Output: true

//Example 2:
//Input: s = "()[]{}"
//Output: true

//Example 3:
//Input: s = "(]"
//Output: false
Console.WriteLine("Enter a string of brackets:");
string? input = Console.ReadLine();

bool result = IsValid(input ?? "");
Console.WriteLine(result ? "true" : "false");

static bool IsValid(string s)
{
    var pairs = new Dictionary<char, char>
    {
        { '(', ')' },
        { '{', '}' },
        { '[', ']' }
    };

    var stack = new Stack<char>();

    foreach (var ch in s)
    {
        if (pairs.ContainsKey(ch)) // opening
        {
            stack.Push(pairs[ch]); // push expected closer
        }
        else if (pairs.ContainsValue(ch)) // closing
        {
            if (stack.Count == 0 || stack.Peek() != ch) return false;
            stack.Pop();
        }
    }

    return stack.Count == 0;
}