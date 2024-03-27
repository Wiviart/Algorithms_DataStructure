﻿int[] array = [0, 10, 12, 15, 23, 34, 55, 56, 77, 98, 99];
int target = 15;

ISearch search = new BinarySearch();

IDiagnostic memoryDiag = new MemoryDiagnostic();
IDiagnostic timeDiag = new TimeDiagnostic();
memoryDiag.Start();
timeDiag.Start();

int i = search.Search(array, target);

switch (i)
{
    case -1:
        Console.WriteLine($"Element {target} not found");
        break;
    default:
        Console.WriteLine($"Element {target} found at index: " + i);
        break;
}

timeDiag.End();
memoryDiag.End();