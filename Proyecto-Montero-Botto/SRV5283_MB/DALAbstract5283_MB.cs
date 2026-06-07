using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV5283_MB
{
    public abstract class DALAbstract5283_MB<T> where T : Entity5283_MB
    {
        protected IList<T> dataContext;
        public SqlConnection conn = new SqlConnection();
        private readonly string connectionString = @"Data Source=.";
        protected string TableName { get; set; }

        public DALAbstract5283_MB()
        {
            dataContext = new List<T>();
        }
        public void Open()
        {
            conn.ConnectionString = connectionString;
            conn.Open();
        }

        public void Close()
        {
            conn.Close();
        }
        public abstract void Delete(T entity);

        public abstract IList<T> GetAll();

        public abstract T GetByData(string dato, string tipodato);

        public abstract void Insert(T entity);

        public abstract void Update(T entity);

        public abstract T MapFromReader(SqlDataReader reader);

        public abstract int Last(string tipodato);
    }
}
