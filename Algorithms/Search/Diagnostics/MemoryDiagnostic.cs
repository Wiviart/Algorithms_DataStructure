using System.Collections;
using System.Collections.Generic;

public class MemoryDiagnostic : IDiagnostic
{
    long beforeMemory;
    long afterMemory;
    long result;

    public void Start()
    {
        beforeMemory = GC.GetTotalMemory(true);
    }

    public void End()
    {
        afterMemory = System.GC.GetTotalMemory(true);
        result = afterMemory - beforeMemory;
        Console.WriteLine("Memory: " + result.ToString("0,000") + " bytes");
    }

    public string GetResult()
    {
        return result.ToString("0,000");
    }
}
