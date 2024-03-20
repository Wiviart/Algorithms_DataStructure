public interface IStructure
{
    void Create(int size);
    void Delete(string v);
    void DeleteAt(int v);
    void InsertAt(int v, string v2);
    void Read();
    bool Search(string v);
    void Update(string v1, string v2);
    void UpdateAt(int v1, string v2);
}
