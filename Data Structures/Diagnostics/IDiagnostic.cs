public interface IDiagnostic
{
    void Start();
    void End();
    string GetResult();
}