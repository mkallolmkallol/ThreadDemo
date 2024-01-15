namespace ThreadDemo
{
    internal class ThreadDemo
    {
        public void Start()
        {
            FileWriter fileWriter = new ();
            fileWriter.Initialize ();
            Thread[] threads = new Thread[10]; 

            // Launch 10 threads
            for (int i = 0; i < threads.Length; i++)
            {
                int threadId = i;
                threads[i] = new Thread(() => fileWriter.WriteToFile(threadId));
            }

            // Start threads
            foreach (Thread thread in threads)
            {
                thread.Start ();
            }

            // Wait for all threads to terminate
            foreach (Thread thread in threads)
            {
                thread.Join();
            }

        }
    }
}
