public class ParenthesisCheck
{
    internal static void CheckParanthesis()
    {
        Console.WriteLine("\nEnter a string to check for the correct parenthesis.");
        string? input = Console.ReadLine();

        if (input != null)
        {
            Stack<char> parenStack = new Stack<char>();
            bool isWellFormed = true;

            foreach (char c in input)
            {
                if (c == '(' || c == '{' || c == '[' || c == '<')
                {
                    //push opening parenthesis into stack.
                    parenStack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']' || c == '>')
                {
                    //check for matching parenthesis on stack.
                    if (parenStack.Count == 0)
                    {
                        isWellFormed = false;
                        break;
                    }
                    char top = parenStack.Pop();

                    //check the popped parenthesis(open) with the closing parenthesis.
                    if ((c == ')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '[') || (c == '>' && top != '<'))
                    {
                        isWellFormed = false;
                        break;
                    }
                }

            }
            //check if there are any unmatched opening parenthesis left.
            if (parenStack.Count != 0)
            {
                isWellFormed = false;
            }
            if (isWellFormed)
            {
                Console.WriteLine("\nThe string has correct parenthesis.");
            }
            else
            {
                Console.WriteLine("\nThe string has incorrect parenthesis.");
            }
        }

    }
}
/* Stack is used to track and match opening parentheses with their corresponding closing parentheses in a well-formed string.
A stack naturally supports the concept of nested parentheses.(push & pop)*/

