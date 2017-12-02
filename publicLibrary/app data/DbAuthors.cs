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
        public override void Insert<Author> (Author a)
        {
            string sql = string.Format("INSERT INTO Authors(authorId, authorName) VALUES ('{0}', '{1}')", a.Id, a.Name);
            base.Update(sql);
        }

        public override void Update<Author> (Author a)
        {

        }

        public override void Delete (int id)
        {

        }

        public override bool Found(int id)
        {
            return (0 != GetInfo(id).Tables[0].Rows.Count);
        }

        public override bool Found(string name)
        {
            return false;
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
            return new DataSet();
        }
    }
}
