public class MemoryDiagnostic : IDiagnostic
{
    static long beforeMemory;
    static long afterMemory;
    static long result;
    public static string Result => result.ToString("0,000");

    public static void Start()
    {
        beforeMemory = GC.GetTotalMemory(true);
    }

    public static void End()
    {
        afterMemory = GC.GetTotalMemory(true);
        result = afterMemory - beforeMemory;
        Console.WriteLine("Memory: " + Result + " bytes");
    }
}
