using System;
namespace GoingTo_Library.Singleton
{
    public class Singleton<T> : ISingleton<T>
    {
        private static Singleton<T> instance;
        private Singleton()
        {
            instance = null;
        }

        public Singleton<T> GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton<T>();
                return instance;
            }
            return instance;
        }
    }
}
