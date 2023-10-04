namespace Proof_of_Concept_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var proc = System.Diagnostics.Process.Start("notepad.exe");
            proc.WaitForExit();
            Console.WriteLine("Proc exited.");
        }
    }
}