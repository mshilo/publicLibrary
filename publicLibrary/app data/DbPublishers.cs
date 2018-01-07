using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace publicLibrary
{
    class DbPublishers : DbMain
    {
        public override void Insert<Titem>(Titem a)
        {
            Publisher p = (Publisher)(object)a;
            string sql = string.Format("INSERT INTO Publishers (publisherId, publisherName, publisherAddress, publisherContact) VALUES ('{0}','{1}','{2}','{3}')", p.Id, p.Name, p.Address, p.Contact);
            base.Update(sql);
        }

        public override void Update<Titem>(Titem a)
        {
            Publisher p = (Publisher)(object)a;
            string sql = string.Format("UPDATE Publishers SET publisherName='{0}', publisherAddress='{1}', publisherContact='{2}' WHERE publisherId={3}", p.Name, p.Address, p.Contact, p.Id);
            base.Update(sql);
        }

        public override void Delete(int id)                                  
        {
            string sql = string.Format("DELETE FROM Publishers WHERE publisherId={0}", id);
            base.Update(sql);
        }                                                                    
                                                                             
        public override bool Found(int id)                                   
        {                                                                    
            return (0 != this.GetInfo(id).Tables[0].Rows.Count);             
        }

        public override bool Found(string name)
        {
            return (0 != this.GetInfo(name).Tables[0].Rows.Count);
        }

        public override DataSet GetInfo(int id)
        {
            DataSet ds = new DataSet();
            string sql = string.Format("SELECT * FROM Publishers WHERE publisherId={0}", id);
            ds = GetQuery(sql);
            return ds;
        }

        public override DataSet GetInfo(string name)
        {
            DataSet ds = new DataSet();
            string sql = string.Format("SELECT * FROM Publishers WHERE publisherName='{0}'", name);
            ds = GetQuery(sql);
            return ds;
        }
    }
}
