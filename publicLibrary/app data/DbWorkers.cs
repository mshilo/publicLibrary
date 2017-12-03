using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace publicLibrary
{
    class DbWorkers : DbMain
    {
        public override void Insert<Titem>(Titem a)
        {
            Worker w = (Worker)(object)a;
            string sql = string.Format("INSERT INTO WORKERS (workerId, workerName, workerPassword, workerRank, workerAddress, workerEmail,workerPhone, workerStartDate) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", w.Id, w.Name, w.Password, w.Rank, w.Address, w.Email, w.PhoneNumber, w.StartDate);
            base.Update(sql);
        }

        public override void Update<Titem>(Titem a)
        {
            Worker w = (Worker)(object)a;
            string sql = string.Format("UPDATE WORKERS SET workerName='{0}', workerPassword='{1}', workerRank={2}, workerAddress='{3}', workerEmail='{4}',workerPhone='{5}', workerStartDate='{6}' WHERE workerId={7}", w.Name, w.Password, w.Rank, w.Address, w.Email, w.PhoneNumber, w.StartDate, w.Id);
            base.Update(sql);
        }

        public override void Delete(int id)
        {
            string sql = string.Format("DELETE FROM WORKERS WHERE workerId={0}", id);
            base.Update(sql);
        }

        public override bool Found(int id)
        {
            return (0 != this.GetInfo(id).Tables[0].Rows.Count);
        }

        public override bool Found(string name)
        {
            return false;
        }

        public override DataSet GetInfo(int id)
        {
            DataSet ds = new DataSet();
            string sql = string.Format("SELECT * FROM Workers WHERE workerId={0}", id);
            ds = GetQuery(sql);
            return ds;
        }

        public override DataSet GetInfo(string name)
        {
            return new DataSet();
        }

        public string LogIn(string password)
        {
            DataSet ds = new DataSet();
            string sql = string.Format("SELECT * FROM Workers WHERE workerPassword='{0}'", password);
            ds = base.GetQuery(sql);
            if (0 != ds.Tables[0].Rows.Count)
                return ds.Tables[0].Rows[0][1].ToString();
            else
                return "invalid password";
        }
    }
}
