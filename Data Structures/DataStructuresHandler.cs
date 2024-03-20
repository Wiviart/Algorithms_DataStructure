using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

public class DataStructuresHandler
{
    enum StructureType
    {
        Array,
        Dictionary,
        HashSet,
        LinkedList,
        List,
        Queue,
        Stack,
        BreadthTree,
        DepthTree,
    }

    int powerOfTen = 5;  // From 1 to 5
    string dict = "";

    IStructure GetStructureType(StructureType structureType)
    {
        switch (structureType)
        {
            case StructureType.Array:
                return new ArrayStructure();
            case StructureType.List:
                return new ListStructure();
            case StructureType.Dictionary:
                return new DictionaryStructure();
            case StructureType.Stack:
                return new StackStructure();
            case StructureType.Queue:
                return new QueueStructure();
            case StructureType.LinkedList:
                return new LinkedListStructure();
            case StructureType.HashSet:
                return new HashSetStructure();
            case StructureType.BreadthTree:
                return new BreadthTreeStructure();
            case StructureType.DepthTree:
                return new DepthTreeStructure();
            default:
                return new ArrayStructure();
        }
    }

    public void Start()
    {
        int size = (int)MathF.Pow(10, powerOfTen);

        // foreach (var i in Enum.GetValues(typeof(StructureType)))
        // {
        //     IStructure structure = GetStructureType((StructureType)i);
        //     TestCase(structure, size);

        //     Thread.Sleep(1000);
        // }

        IStructure structure = GetStructureType(StructureType.BreadthTree);
        TestCase(structure, size);

        Console.WriteLine(dict);
    }

    void TestCase(IStructure structure, int size)
    {
        Console.WriteLine($"Testing {structure.GetType().Name} with {size} elements");

        IDiagnostic memoDiag = new MemoryDiagnostic();
        IDiagnostic timeDiag = new TimeDiagnostic();

        memoDiag.Start();
        timeDiag.Start();

        structure.Create(size);
        structure.Read();

        bool x = structure.Search("15299");
        Console.WriteLine($"Search for 15299: {x}");

        structure.Update("2657", "XYZ");
        structure.UpdateAt(1000, "Hello");

        structure.Delete("2833");
        structure.DeleteAt(1000);

        structure.InsertAt(1333, "------------------");

        structure.Read();

        memoDiag.End();
        timeDiag.End();

        dict += structure.GetType().Name + " : " + memoDiag.GetResult() + " bytes " + timeDiag.GetResult() + " ms\n";
    }
}
