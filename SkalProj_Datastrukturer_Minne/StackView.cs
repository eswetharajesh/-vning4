public class StackView
{
    internal static void ExamineStack()
    {
        Stack<string> userStack = new Stack<string>();
        while (true)
        {
            Console.WriteLine("\nPlease choose a step for the User stack:"
            + "\n1. Push"
            + "\n2. Pop"
            + "\n3. Reverse Text"
            + "\n4. Exit");

            char step = ' ';
            try
            {
                step = Console.ReadLine()![0];
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nPlease enter a valid Step!");
            }
            switch (step)
            {
                case '1':
                    PushUser(userStack);
                    break;

                case '2':
                    PopUser(userStack);
                    break;

                case '3':
                    Reversetext();
                    break;

                case '4':
                    Console.WriteLine("\nExiting the examinestack Method.");
                    return;

                default:
                    Console.WriteLine("\nPlease enter '1', '2', '3' or '4' as valid Step !");
                    break;
            }
        }
    }


    private static void PushUser(Stack<string> userStack)//Push method
    {
        Console.WriteLine("\nEnter a User Name to push into the stack :");
        string? pushName = Console.ReadLine();
        if (pushName != null)
        {
            userStack.Push(pushName);
            Console.WriteLine($"\n{pushName} has been pushed into the User Stack.");

        }
        else
        {
            Console.WriteLine("\nGive a Name , not an empty space !");
        }
    }

    private static void PopUser(Stack<string> userStack)//Pop method
    {
        if (userStack.Count > 0)
        {
            string popName = userStack.Pop();
            Console.WriteLine($"\n{popName} has been popped out of the User Stack.");
        }
        else
        {
            Console.WriteLine("\nThe stack is empty !");
        }

    }
    static void Reversetext()// Reverse Text method
    {
        Stack<char> charStack = new Stack<char>();// Empty stack to store the input char

        Console.WriteLine("\nEnter a word to reverse .");
        var inputWord = Console.ReadLine();

        if (inputWord is not null)
        {
            foreach (char c in inputWord)
            {
                charStack.Push(c);// push the char of the user's input to stack
            }

            Console.Write("\nReversed Word: ");
            while (charStack.Count > 0)
            {
                char reversedChar = charStack.Pop();// pop the char to reverse the input(FILO)
                Console.Write(reversedChar);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("\nInput should not be null!");
        }
    }

}