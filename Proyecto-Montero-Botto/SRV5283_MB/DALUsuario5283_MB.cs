using SRV_5283_MB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV5283_MB
{
    public class DALUsuario5283_MB : DALAbstract5283_MB<Usuario5283_MB>
    {
        public DALUsuario5283_MB()
        {
            TableName = "Usuario5283_MB";
        }

        //Copiado del año pasado, hay que editar
        //Editado, hay que revisar que tenga sentido
        public override void Insert(Usuario5283_MB entity)
        {
            string Query = $"INSERT INTO {TableName}([ID], [Nombre], [Apellido], [DNI], " +
                $"[Perfil], [NombreUsuario], [Contraseña], [Bloqueo]) " +
                $"VALUES(@ID , @Nombre, @Apellido, @DNI, @Perfil, " +
                $"@NombreUsuario, @Contraseña, @Bloqueo)";
            Open();
            SqlCommand cmd = new SqlCommand(Query, conn);
            AddParameters(cmd, entity);
            SqlTransaction tran = conn.BeginTransaction();
            cmd.Transaction = tran;
            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch
            {
                tran.Rollback();
            }
            finally
            {
                Close();
            }
        }

        public override void Update(Usuario5283_MB entity)
        {
            string Query = $"UPDATE {TableName} " +
                $"SET [Nombre] = @Nombre , " +
                $"[Apellido] = @Apellido , " +
                $"[DNI] = @DNI , " +
                $"[Perfil] = @Perfil , " +
                $"[NombreUsuario] = @NombreUsuario , " +
                $"[Contraseña] = @Contraseña , " +
                $"[Bloqueo] = @Bloqueo , " +
                $"WHERE ID = @ID";

            Open();
            SqlCommand cmd = new SqlCommand(Query, conn);
            AddParameters(cmd, entity);

            SqlTransaction tran = conn.BeginTransaction();
            cmd.Transaction = tran;

            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch
            {
                tran.Rollback();
            }
            finally
            {
                Close();
            }
        }

        public void AddParameters(SqlCommand cmd, Usuario5283_MB entity)
        {
            cmd.Parameters.AddWithValue("@ID", entity.ID);
            cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", entity.Apellido);
            cmd.Parameters.AddWithValue("@DNI", entity.DNI);
            cmd.Parameters.AddWithValue("@Perfil", entity.Perfil);
            cmd.Parameters.AddWithValue("@NombreUsuario", entity.NombreUsuario);
            cmd.Parameters.AddWithValue("@Contraseña", entity.Contraseña);
            cmd.Parameters.AddWithValue("@Bloqueo", entity.Bloqueo);
        }
        public override void Delete(Usuario5283_MB entity)
        {
            string Query = $"UPDATE {TableName} SET [Perfil] = 'Baja' WHERE ID = @ID";
            Open();
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@ID", entity.ID);
            SqlTransaction tran = conn.BeginTransaction();
            cmd.Transaction = tran;
            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch
            {
                tran.Rollback();
            }
            finally
            {
                Close();
            }
        }

        public override Usuario5283_MB MapFromReader(SqlDataReader reader)
        {
            Usuario5283_MB user = new Usuario5283_MB();
            user.ID = reader.GetInt32(reader.GetOrdinal("ID"));
            user.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
            user.Apellido = reader.GetString(reader.GetOrdinal("Apellido"));
            user.DNI = reader.GetInt32(reader.GetOrdinal("DNI"));
            user.Perfil = reader.GetString(reader.GetOrdinal("Perfil"));
            user.NombreUsuario = reader.GetString(reader.GetOrdinal("NombreUsuario"));
            user.Contraseña = reader.GetString(reader.GetOrdinal("Contraseña"));
            user.Bloqueo = reader.GetInt32(reader.GetOrdinal("Bloqueo"));
            return user;
        }

        public override IList<Usuario5283_MB> GetAll()
        {
            List<Usuario5283_MB> users = new List<Usuario5283_MB>();
            string Query = $"SELECT * FROM {TableName}";
            Open();
            SqlCommand cmd = new SqlCommand(Query, conn);
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    users.Add(MapFromReader(dr));
                }
                return users;
            }
            catch
            {
                return null;
            }
            finally
            {
                Close();
            }
        }

        public override Usuario5283_MB GetByData(string dato, string tipodato)
        {
            string Query = $"SELECT * FROM {TableName} WHERE {tipodato} = @{tipodato}";
            Open();
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue($"@{tipodato}", dato);
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                return MapFromReader(reader);
            }
            catch
            {
                return null;
            }
            finally
            {
                Close();
            }
        }

        public override int Last(string tipodato)
        {
            string Query = $"SELECT MAX({tipodato}) FROM {TableName}";
            Open();
            SqlCommand cmd = new SqlCommand(Query, conn);
            try
            {
                int t = Int32.Parse(cmd.ExecuteScalar().ToString());
                return t;
            }
            catch
            {
                return 0;
            }
            finally
            {
                Close();
            }

        }
    }
}
