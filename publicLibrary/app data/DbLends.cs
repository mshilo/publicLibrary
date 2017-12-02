using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace publicLibrary 
{
    class DbLends : DbMain
    {
        public override void Insert<Titem>(Titem a)
        {
            Lend l = (Lend)(object)a;
            string sql = string.Format("INSERT INTO Lends (lendId, subscriberId, workerId, itemId, itemQuantity, lendStartDate, lendFinishDate) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", l.Id, l.SUbscriberId, l.WorkerId, l.ItemId, l.ItemQuantity, l.StartDate, l.EndDate);
            base.Update(sql);
        }

        public override void Update<Titem>(Titem a)
        {
            Lend l = (Lend)(object)a;
            string sql = string.Format("UPDATE Lends SET subscriberId={0}, workerId={1}, itemId={2}, itemQuantity={3}, lendStartDate='{4}', lendFinishDate='{5}' WHERE lendId={6}", l.SUbscriberId, l.WorkerId, l.ItemId, l.ItemQuantity, l.StartDate, l.EndDate, l.Id);
            base.Update(sql);
        }

        public override void Delete(int id)
        {
            string sql = string.Format("DELETE FROM Lends WHERE lendId={0}", id);
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
            string sql = string.Format("SELECT * FROM Lends WHERE lendId={0}", id);
            ds = GetQuery(sql);
            return ds;
        }

        public override DataSet GetInfo(string name)
        {
            return new DataSet();
        }
    }
}
