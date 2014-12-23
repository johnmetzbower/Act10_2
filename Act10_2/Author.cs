using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; 


namespace Act10_2
{
    public class Author
    {
        SqlConnection _pubConnection;
        string _connString;
        SqlDataAdapter _pubDataAdapter;
        DataSet authorDataSet;
        public Author()
        {
            _connString =
                @"Data Source=(localdb)\ProjectsV12;Initial Catalog=Pubs;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            _pubConnection = new SqlConnection();
            _pubConnection.ConnectionString = _connString;
            SqlCommand selectCommand =
                new SqlCommand("Select au_id, au_lname,au_fname from authors", _pubConnection);
            _pubDataAdapter = new SqlDataAdapter();
            _pubDataAdapter.SelectCommand = selectCommand;
        }
        public DataSet GetData()
        {
            try
            {
                authorDataSet = new DataSet();
                _pubDataAdapter.Fill(authorDataSet, "Author");
                return authorDataSet;
            }
            catch (Exception ex)
            { 
                throw ex;
            }
        }
    }
 }

