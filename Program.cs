int counter = 0;
Thread t1 = new Thread(IncrementCounter);
t1.Start();
t1.Join();

Thread t2 = new Thread(IncrementCounter);
t2.Start();
t2.Join();
Console.WriteLine($"Final counter value is:{counter}");

void IncrementCounter()
{
    for (int i = 0; i < 100000; i++)
    {
        counter++;
    }   
}