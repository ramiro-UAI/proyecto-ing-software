using SRV_5283_MB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV5283_MB
{
    public class DALBitacora5283_MB : DALAbstract5283_MB<Evento5283_MB>
    {
        public DALBitacora5283_MB()
        {
            TableName = "Bitacora5283_MB";
        }

        public override void Insert(Evento5283_MB entity)
        {
            string Query = $"INSERT INTO {TableName} ([ID], [Date] [NombreUsuario], [Descripcion])" +
                "VALUES (@ID,@Date, @NombreUsuario, @Descripcion)";
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


        public override void Update(Evento5283_MB entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Evento5283_MB entity)
        {
            throw new NotImplementedException();
        }

        public override IList<Evento5283_MB> GetAll()
        {
            List<Evento5283_MB> events = new List<Evento5283_MB>();
            string Query = $"SELECT * FROM {TableName}";
            Open();
            SqlCommand cmd = new SqlCommand(Query, conn);
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    events.Add(MapFromReader(dr));
                }
                return events;
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
        public override Evento5283_MB GetByData(string dato, string tipodato)
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

        public override Evento5283_MB MapFromReader(SqlDataReader reader)
        {
            Evento5283_MB events = new Evento5283_MB();
            events.ID = reader.GetInt32(reader.GetOrdinal("ID"));
            events.Date = reader.GetDateTime(reader.GetOrdinal("FechaHora"));
            events.NombreUsuario = reader.GetString(reader.GetOrdinal("NombreUsuario"));
            events.Descripcion = reader.GetString(reader.GetOrdinal("Descripcion"));
            return events;
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

        public void AddParameters(SqlCommand cmd, Evento5283_MB entity)
        {
            cmd.Parameters.AddWithValue("@ID", entity.ID);
            cmd.Parameters.AddWithValue("@Date", entity.Date);
            cmd.Parameters.AddWithValue("@NombreUsuario", entity.NombreUsuario);
            cmd.Parameters.AddWithValue("@Descripcion", entity.Descripcion);
        }

    }
}
