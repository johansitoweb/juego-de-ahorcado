using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;

namespace Core.ORM
{
    public class ORM : IDisposable
    {
        private string _connstring = "Server=ERAOL\\SQLEXPRESS;Database=sql_curso_YT;Integrated Security=True;";
        private SqlConnection _con;
        public ORM()
        {
            SqlMapperExtensions.TableNameMapper = (type) =>
            {
                //use exact name
                return type.Name;
            };
            this._con = new SqlConnection(this._connstring);

        }
        public ORM(string customConnstring)
        {
            SqlMapperExtensions.TableNameMapper = (type) =>
            {
                //use exact name
                return type.Name;
            };
            this._connstring = customConnstring;
            this._con = new SqlConnection(this._connstring);

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  Gets all elements of the entity
        /// </summary>
        /// <typeparam name="T">Entity type</typeparam>
        /// <returns></returns>
        public IEnumerable<T> GetAll<T>() where T : class, IEntity
        {
            return this._con.GetAll<T>(commandTimeout: 99999);
        }

        /// <summary>
        /// Gets entity identified by id
        /// </summary>
        /// <typeparam name="T">Entity type</typeparam>
        /// <param name="id">integer Id</param>
        /// <returns></returns>
        public T GetbyId<T>(int id) where T : class, IEntity
        {

            return this._con.Get<T>(id);
        }
        public string getPalabra() {
            return this._con.QueryFirst<string>("SELECT top (1) [palabra] FROM [sql_curso_YT].[dbo].[Palabras]  order by NEWID();");
        }
    }
}