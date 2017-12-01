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
        public override void Insert<Subscriber>(Subscriber a)
        {

        }

        public override void Update<Subscriber>(Subscriber a)
        {

        }

        public override void Delete(int id)
        {

        }

        public override bool Found(int id)
        {
            return false;
        }

        public override bool Found(string name)
        {
            return false;
        }

        public override DataSet GetInfo(int id)
        {
            return new DataSet();
        }

        public override DataSet GetInfo(string name)
        {
            return new DataSet();
        }
    }
}
