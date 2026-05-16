using Microsoft.Win32;
using SRV_5283_MB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV5283_MB
{
    public class BLLUsuario5283_MB
    {
        DALUsuario5283_MB DAL = new DALUsuario5283_MB();

        public void LogIn(string NombreUsuario, string Contraseña)
        {
            if (SessionManager5283_MB.Instance.IsLoggedIn()) throw new Exception("Ya hay una sesión iniciada");

            Usuario5283_MB user = DAL.GetByData(NombreUsuario, "NombreUsuario");

            if (user == null || user.Perfil == "Baja") throw new Exception("Usuario invalido"); 

            if (user.Bloqueo == 1) throw new Exception("Usuario Bloqueado, contacte al Administrador para Desbloquear");

            if (!Encriptador5283_MB.EncriptarMD5(Contraseña).Equals(user.Contraseña))
            {
                //Esta version usa un contador temporal en Usuario5283_MB para contabilizar los intentos
                user.ContBloqueo++;
                if (user.ContBloqueo == 3)
                {
                    user.Bloqueo = 1;
                    DAL.Update(user);
                    throw new Exception("Demasiados intentos de ingreso, Usuario Bloqueado, contacte al Administrador para Desbloquear");
                }
                throw new Exception("Contraseña incorrecta");
            }
            else
            {
                SessionManager5283_MB.Instance.Login(user);
            }
        }

        public void LogOut()
        {
            if (!SessionManager5283_MB.Instance.IsLoggedIn())
            {
                throw new Exception("No hay sesion iniciada");
            }
            SessionManager5283_MB.Instance.LogOut();
        }

        public List<Usuario5283_MB> GetUsuarios() 
        {
            List<Usuario5283_MB> users = (List<Usuario5283_MB>)DAL.GetAll();

            var userView = users.Select(u => new Usuario5283_MB
            {

                Nombre = u.Nombre,
                Apellido = u.Apellido,
                DNI = u.DNI,
                Perfil = u.Perfil,
                Bloqueo = u.Bloqueo
            }).ToList();

            //Hay que crear un modelo de visualizacion que cambie el atributo Bloqueo a String
            /*foreach (var user in userView)
            {
                if (user.Bloqueo == 0) user.Bloqueo = "Activo";
                else user.Bloqueo = "Bloqueado";

            }*/

            return userView;
        }

        public void AgregarUsuario(Usuario5283_MB user)
        { 
            if (DAL.GetByData((user.DNI).ToString(), "DNI") != null) throw new Exception("Usuario Ya Existente");
            user.ID = DAL.Last("ID");
            //Esto es una linea que no deberia ocurri siempre y cuando tenga acceso a la base de datos
            if (user.ID == 0) { throw new Exception("Error al obterner ID"); }
            else { user.ID++; }
            user.Bloqueo = 0;
            user.NombreUsuario = user.Apellido + user.DNI.ToString();
            user.Contraseña = Encriptador5283_MB.EncriptarMD5(user.Nombre + user.DNI.ToString());
            DAL.Insert(user);
        }

        public void EliminarUsuario(Usuario5283_MB user)
        {
            Usuario5283_MB userDel = DAL.GetByData(user.DNI.ToString(), "DNI");
            DAL.Delete(userDel);
        }

        public void CambiarClave(string Actual, string Nueva, string Repetida)
        {
            Usuario5283_MB user = SessionManager5283_MB.Instance.usuario;
            if (Encriptador5283_MB.EncriptarMD5(Actual) != user.Contraseña) throw new Exception("Contraseña Incorrecta");
            else
            {
                user.Contraseña = Encriptador5283_MB.EncriptarMD5(Nueva);
                DAL.Update(user);
            }
        }

        public bool VerificarClaveBlanqueada()
        {
            Usuario5283_MB user = SessionManager5283_MB.Instance.usuario;
            if(user.Contraseña == Encriptador5283_MB.EncriptarMD5(user.Nombre + user.DNI.ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
