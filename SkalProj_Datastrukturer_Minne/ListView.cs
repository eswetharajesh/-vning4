
public class ListView
{
    internal static void ExamineList()
    {

        List<string> theList = new List<string>();

        while (true)
        {
            Console.WriteLine("\nPlease choose action for the list:"
            + "\ni) Enter '+' Name to ADD"
            + "\nii) Enter '-' Name to REMOVE"
            + "\niii) Enter 'X' to EXIT");

            string? input = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("\nInput cannot be null or empty. please enter '+' or '-' with a Name!");
                continue;
            }

            char nav = input[0];

            if (input.Length > 1)
            {
                string value = input.Substring(1).Trim();

                switch (nav)
                {
                    case '+':
                        AddItem(theList, value);
                        break;
                    case '-':
                        RemoveItem(theList, value);
                        break;
                    default:
                        Console.WriteLine("\nPlease use only '+', '-' or 'X'.");
                        break;
                }
            }
            else
            {
                switch (nav)
                {
                    case 'X':
                        Console.WriteLine("\nExiting the Examine List method");
                        return;
                }
            }
        }
    }


    private static void AddItem(List<string> theList, string value)// Add method
    {
        theList.Add(value);
        Console.WriteLine($"\nAdded {value} to the list.");
        Console.WriteLine($"\nCount: {theList.Count}, Capacity: {theList.Capacity}");
    }

    private static void RemoveItem(List<string> theList, string value)// Remove method
    {
        if (theList.Remove(value))
        {
            Console.WriteLine($"\nRemoved {value} from the list.");
        }
        else
        {
            Console.WriteLine($"\n{value} not found in the list.");
        }
        Console.WriteLine($"\nCount: {theList.Count}, Capacity: {theList.Capacity}");
    }
}

/* 
Answer:

2. The list's capacity increases when it reaches its current capacity limit. 
It automatically reallocates memory to increase capacity as needed.

3. The amount by which capacity increases may vary based on the List implementation and memory management policies.

4. It would be inefficient to reallocate memory for every single element added to list.
Instead, the list increases its capacity in larger chunks to reduce memory reallocation overhead.

5. The capacity doesn't decreases when elements are removed. Because List maintains some capacity even after removing elements
to minimize the need for frequent reallocations.

6. It's advantageous to use self-defined array instead of list  when we need fixed-size collection with known number of elements
as array is more memory efficient.

*/