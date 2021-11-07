namespace ActionFilterPoC.Repository;

public class Repository : IRepository
{
    public IEnumerable<string> GetAll()
    {
        return new[] { "Item1", "Item2" };
    }
}
