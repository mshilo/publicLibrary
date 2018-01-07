using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace publicLibrary
{
    class DbAuthors : DbMain
    {
        public override void Insert<Titem> (Titem a)
        {
            string sql = string.Format("INSERT INTO Authors(authorId, authorName) VALUES ('{0}', '{1}')", a.Id, a.Name);
            base.Update(sql);
        }

        public override void Update<Titem> (Titem a)
        {
            string sql = string.Format("UPDATE Authors SET authorName='{0}' WHERE authorId={1}", a.Name, a.Id);
            base.Update(sql);
        }

        public override void Delete (int id)
        {
            string sql = string.Format("DELETE FROM Authors WHERE authorId={0}", id);
            base.Update(sql);
        }

        public override bool Found(int id)
        {
            return (0 != GetInfo(id).Tables[0].Rows.Count);
        }

        public override bool Found(string name)
        {
            return (0 != GetInfo(name).Tables[0].Rows.Count);
        }

        public override DataSet GetInfo(int id)
        {
            DataSet ds = new DataSet();
            string sql = string.Format("SELECT * FROM AUTHORS WHERE authorId={0}", id);
            ds = GetQuery(sql);
            return ds;
        }

        public override DataSet GetInfo(string name)
        {
            DataSet ds = new DataSet();
            string sql = string.Format("SELECT * FROM Authors WHERE authorName='{0}'", name);
            ds = GetQuery(sql);
            return ds;
        }
    }
}
