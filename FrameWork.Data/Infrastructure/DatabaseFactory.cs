
using FrameWork.Data;
      
namespace FrameWork.Data
{
public class DatabaseFactory : Disposable, IDatabaseFactory
{
    private FrameWorkEntities dataContext;
    public FrameWorkEntities Get()
    {
        return dataContext ?? (dataContext = new FrameWorkEntities());
    }
    protected override void DisposeCore()
    {
        if (dataContext != null)
            dataContext.Dispose();
    }
}
}
