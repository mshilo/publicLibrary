using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace publicLibrary
{
    class DbSubscribers : DbMain
    {
        public override void Insert<Titem>(Titem a)
        {
            Subscriber s = (Subscriber)(object)a;
            string sql = string.Format("INSERT INTO Subscribers (subscriberId, subscriberName, subscriberAddress, subscriberPhone, subscriberEmail) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", s.Id, s.Name, s.Address, s.PhoneNumber, s.Email);
            base.Update(sql);
        }

        public override void Update<Titem>(Titem a)
        {
            Subscriber s = (Subscriber)(object)a;
            string sql = string.Format("UPDATE Subscribers SET subscriberName='{0}', subscriberAddress='{1}', subscriberPhone='{2}', subscriberEmail='{3}' WHERE subscriberId={4}", s.Name, s.Address, s.PhoneNumber, s.Email, s.Id);
            base.Update(sql);
        }

        public override void Delete(int id)
        {
            string sql = string.Format("DELETE FROM Subscribers WHERE subscriberId={0}", id);
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
            string sql = string.Format("SELECT * FROM Subscribers WHERE subscriberId={0}", id);
            ds = GetQuery(sql);
            return ds;
        }

        public override DataSet GetInfo(string name)
        {
            DataSet ds = new DataSet();
            string sql = string.Format("SELECT * FROM Subscribers WHERE subscriberName='{0}'", name);
            ds = GetQuery(sql);
            return ds;
        }
    }
}
