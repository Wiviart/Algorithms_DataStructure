using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

public class TimeDiagnostic : IDiagnostic
{
    readonly Stopwatch sw = new Stopwatch();
    long result;

    public void Start()
    {
        sw.Start();
    }

    public void End()
    {
        sw.Stop();
        result = sw.ElapsedMilliseconds;
        Console.WriteLine("Time: " + sw.ElapsedMilliseconds.ToString("0,000") + "ms");
    }

    public string GetResult()
    {
        return result.ToString("0,000");
    }
}
