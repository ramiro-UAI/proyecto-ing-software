using System;
using System.Collections.Generic;
using System.Text;

namespace SRV_5283_MB
{
    public class Sesion5283_MT
    {
        public Usuario5283_MB _user {  get; set; }
        public Usuario5283_MB usuario
        {
            get
            {
                return _user;
            }
        }
        public void Login(Usuario5283_MB user)
        {
            _user = user;
        }
        public void LogOut() 
        {
            _user = null;
        }
        public bool IsLoggedIn()
        {
            return _user != null;
        }

    }
}
