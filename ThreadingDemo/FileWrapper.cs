namespace ThreadDemo
{
    public class FileWrapper : IFileWrapper
    {
        public void Init(string? filePath, String content)
        {
            if (filePath != null)
            {
                string? directory = Path.GetDirectoryName(filePath);

                if (directory!=null && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                File.WriteAllText(filePath, content);
            }


        }

        public void Write(String filePath, String content)
        {
            File.AppendAllText(filePath, content);
        }
    }
}
