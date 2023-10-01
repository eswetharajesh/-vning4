public class QueueView
{
    internal static void ExamineQueue()
    {
        Queue<string> icaQueue = new Queue<string>();
        while (true)
        {
            Console.WriteLine("\nPlease choose a input for the ICA queue:"
            + "\n1. Enqueue"
            + "\n2. Dequeue"
            + "\n3. Exit");

            char input = ' ';
            try
            {
                input = Console.ReadLine()![0];
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nPlease enter a valid Input!");
            }

            switch (input)
            {
                case '1':
                    Enqueue(icaQueue);
                    break;

                case '2':
                    Dequeue(icaQueue);
                    break;

                case '3':
                    Console.WriteLine("\nExiting the ExamineQueue method.");
                    return;

                default:
                    Console.WriteLine("\nPlease enter '1', '2' or '3' as valid Input !");
                    break;
            }
        }
    }

    private static void Enqueue(Queue<string> icaQueue)//Enqueue method
    {
        Console.WriteLine("\nEnter a Person Name to enqueue :");
        string? personJoined = Console.ReadLine();
        if (personJoined != null)
        {
            icaQueue.Enqueue(personJoined);
            Console.WriteLine($"\n{personJoined} has joined the ICA Queue.");

        }
        else
        {
            Console.WriteLine("\nGive a Name , not an empty space !");
        }
        DisplayQueueNames(icaQueue);
    }

    private static void Dequeue(Queue<string> icaQueue)//Dequeue method
    {
        if (icaQueue.Count > 0)
        {
            string personLeft = icaQueue.Dequeue();
            Console.WriteLine($"\n{personLeft} has been processed and left the ICA Queue.");
        }
        else
        {
            Console.WriteLine("\nThe queue is empty !");
        }
        DisplayQueueNames(icaQueue);
    }

    private static void DisplayQueueNames(Queue<string> icaQueue)//Display Item in queue method
    {
        Console.WriteLine("\nNames in the ICA Queue: ");
        foreach (string name in icaQueue)
        {
            Console.WriteLine(name);
        }
    }

}