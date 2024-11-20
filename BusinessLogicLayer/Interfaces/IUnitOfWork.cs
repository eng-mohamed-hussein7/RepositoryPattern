namespace BusinessLogicLayer.Interfaces;

public interface IUnitOfWork : IDisposable
{
    Task<int> CompleteAsync();
    int Complete();
}
