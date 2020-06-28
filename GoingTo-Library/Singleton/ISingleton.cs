using System;
namespace GoingTo_Library.Singleton
{
    public interface ISingleton<T>
    {
        Singleton<T> GetInstance();
    }
}
