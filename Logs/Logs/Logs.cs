namespace Logs
{
    public class ConsoleLog : ILog
    {
        public void Print(string s)
        {
            Console.WriteLine(DateTime.Now.ToString() + "\t" + s);
        }
    }

    public class FileLog : ILog
    {
        public void Print(string s)
        {
            using (StreamWriter writer = new StreamWriter("Logs.txt", true)) 
            {
                writer.WriteLine(DateTime.Now.ToString());
                writer.Write($"\t{s}\n");
            }
        }
    }
}
