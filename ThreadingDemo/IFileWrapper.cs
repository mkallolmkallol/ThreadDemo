namespace ThreadDemo
{
    interface IFileWrapper
    {
        void Init(String filePath, String content);
        void Write(String filePath, String content);
    }
}
