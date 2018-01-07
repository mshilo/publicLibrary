using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace publicLibrary 
{
    class DbItems : DbMain
    {
        public override void Insert<Titem>(Titem t) 
        {
            Item i = (Item)(object)t;
            string sql = string.Format("INSERT INTO Items (itemId, itemName, itemCount, itemAllowedLendDays, publisherId, authorId, itemGenre, itemLanguage) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", i.Id, i.Name, i.Count, i.AllowedLendDays, i.PublisherId, i.AuthorId, i.Genre, i.Language);
            base.Update(sql);
        }

        public override void Update<Titem>(Titem a)
        {
            Item i = (Item)(object)a;
            string sql = string.Format("UPDATE Items SET itemName='{0}', itemCount={1}, itemAllowedLendDays={2}, publisherId={3}, authorId={4}, itemGenre='{5}', itemLanguage='{6}' WHERE itemId={7}", i.Name, i.Count, i.AllowedLendDays, i.PublisherId, i.AuthorId, i.Genre, i.Language, i.Id);
            base.Update(sql);
        }

        public override void Delete(int id)
        {
            string sql = string.Format("DELETE FROM Items WHERE itemId={0}", id);
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
            string sql = string.Format("SELECT * FROM Items WHERE itemId={0}", id);
            ds = GetQuery(sql);
            return ds;
        }

        public DataSet GetInfoByAuthor(int id)
        {
            DataSet ds = new DataSet();
            string sql = string.Format("SELECT * FROM Items WHERE authorId={0}", id);
            ds = GetQuery(sql);
            return ds;
        }

        public DataSet GetInfoByPublisher(int id)
        {
            DataSet ds = new DataSet();
            string sql = string.Format("SELECT * FROM Items WHERE publisherId={0}", id);
            ds = GetQuery(sql);
            return ds;
        }

        public DataSet GetInfoByGenre(string s)
        {
            DataSet ds = new DataSet();
            string sql = string.Format("SELECT * FROM Items WHERE itemGenre='{0}'", s);
            ds = GetQuery(sql);
            return ds;
        }

        public DataSet GetInfoByLanguage(string s)
        {
            DataSet ds = new DataSet();
            string sql = string.Format("SELECT * FROM Items WHERE itemLanguage='{0}'", s);
            ds = GetQuery(sql);
            return ds;
        }

        public override DataSet GetInfo(string name)
        {
            DataSet ds = new DataSet();
            string sql = string.Format("SELECT * FROM Items WHERE itemName LIKE '%{0}%'", name);
            ds = GetQuery(sql);
            return ds;
        }



        public void UpdateStock (int id, int quantity)
        {
            quantity = (int)this.GetInfo(id).Tables[0].Rows[0].ItemArray[2] + quantity;
            string sql = string.Format("UPDATE Items SET itemCount={0} WHERE itemId={1}", quantity, id);
            base.Update(sql);
        }
    }
}
