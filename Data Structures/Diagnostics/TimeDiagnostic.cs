using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

public class TimeDiagnostic : IDiagnostic
{
    static readonly Stopwatch sw = new Stopwatch();
    static long result;
    public static string Result => result.ToString("0,000");

    public static void Start()
    {
        sw.Start();
    }

    public static void End()
    {
        sw.Stop();
        result = sw.ElapsedMilliseconds;
        Console.WriteLine("Time: " + Result + "ms");
    }
}
