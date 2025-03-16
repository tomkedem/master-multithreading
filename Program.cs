Queue<string> reqestQueue = new Queue<string>();
Thread monitorThread = new Thread(MonitorQueue);
monitorThread.Start();

Console.WriteLine("Server is running. Type 'exit' to stop.");
while (true)
{
    string? input = Console.ReadLine();
    if (input?.ToLower() == "exit")
    {
        break;
    }
    reqestQueue.Enqueue(input);
}

void MonitorQueue()
{
    while (true)
    {
        if (reqestQueue.Count > 0)
        {
            string? input = reqestQueue.Dequeue();
            Thread processingThread = new Thread(() => ProcessInput(input));
            processingThread.Start();
        }
        Thread.Sleep(100);
    }
}   

static void ProcessInput(string? input)
{
    // Simulate processing time
    Thread.Sleep(2000);
    Console.WriteLine($"Processed input: {input}");
}