int counter = 0;
object lockObject = new object();
Thread t1 = new Thread(IncrementCounter);
Thread t2 = new Thread(IncrementCounter);
t2.Start();
t1.Start();
t2.Join();
t1.Join();
Console.WriteLine($"Final counter value is:{counter}");

void IncrementCounter()
{
    for (int i = 0; i < 100000; i++)
    {
        lock (lockObject)
        {
            counter++;
        }
    }   
}