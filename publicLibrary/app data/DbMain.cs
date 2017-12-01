using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace publicLibrary
{
    abstract class DbMain
    {
        public abstract void    Insert<Titem>(Titem i) where Titem : BaseItem;
        public abstract void    Delete (int id);
        public abstract void    Update<Titem> (Titem i) where Titem : BaseItem;
        public abstract DataSet GetInfo (int id);
        public abstract DataSet GetInfo (string name);
        public abstract bool    Found (int id);
        public abstract bool    Found (string name);

        private OleDbConnection cnn = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private DataSet ds = new DataSet();

        public DbMain()
        {
            cnn.ConnectionString = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=..\\access\\LibraryDatabase.accdb ;Persist Security Info=False";
        }

        public DataSet GetAllRecord(string tableName)
        {
            ds = new DataSet();
            cmd = new OleDbCommand();

            try
            {
                cmd.CommandText = "SELECT * FROM " + tableName;
                cmd.Connection = cnn;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cnn.Close(); }

            return ds;
        }

        public DataSet GetQuery(string sql)
        {
            ds = new DataSet();
            cmd = new OleDbCommand();

            try
            {
                cmd.CommandText = sql;
                cmd.Connection = cnn;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cnn.Close(); }

            return ds;
        }

        public void Update(string sql)
        {
            /*          טענת כניסה: הפונקציה מקבלת מחרוזת פקודה
                   טענת יציאה : הפונקציה מעדכנת את בסיס הנתונים       
            */

            cmd = new OleDbCommand();

            try
            {
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cnn.Close(); }
        }
    }
}
