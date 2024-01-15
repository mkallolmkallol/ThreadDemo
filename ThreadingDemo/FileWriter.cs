namespace ThreadDemo
{
    class FileWriter
    {
        private const string DateTimeFormat = "HH:mm:ss.fff";
        private const string LogFilePath = "log/out.txt";
        private static int lineCount = 0;
        private static object lockObject = new object();
        private readonly IFileWrapper fileWrapper = new FileWrapper();

        public void Initialize()
        {
           fileWrapper.Init(LogFilePath, GetLineContent(0));
        }

        public void WriteToFile(int threadId)
        {
            for (int i = 0; i < 10; i++)
            {
                lock (lockObject)
                {
                    lineCount++;
                    fileWrapper.Write(LogFilePath, GetLineContent(threadId));
                }
            }
        }


        private static string GetLineContent(int threadId)
        {
            return $"{lineCount}, {threadId}, {DateTime.Now.ToString(DateTimeFormat)}\n";
        }
    }

}
