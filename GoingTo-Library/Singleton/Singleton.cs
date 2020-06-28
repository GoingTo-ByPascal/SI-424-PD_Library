using System;
namespace GoingTo_Library.Singleton
{
    public class Singleton<T>
    {
        private static Singleton<T> instance;
        private Singleton()
        {
            instance = null;
        }
        public static Singleton<T> getInstance()
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
