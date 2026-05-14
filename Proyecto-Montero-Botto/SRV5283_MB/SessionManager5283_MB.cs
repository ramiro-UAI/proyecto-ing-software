namespace SRV_5283_MB
{
    public class SessionManager5283_MB
    {
        private static Sesion5283_MT _instance;
        public static object _lock = new object();

        public static Sesion5283_MT Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Sesion5283_MT();
                    }
                    return _instance;
                }
            }
        }
    }
}
