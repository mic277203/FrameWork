using FrameWork.Data;
using System;

namespace FrameWork.Data
{
    public interface IDatabaseFactory : IDisposable
    {
        FrameWorkEntities Get();
    }
}
