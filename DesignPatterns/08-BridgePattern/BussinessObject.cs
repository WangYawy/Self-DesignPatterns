using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_BridgePattern
{
    public class BussinessObject
    {
        private DataAccess dataaccess;
        private string city;

        public BussinessObject(string city)
        {
            this.city = city;
        }
        public DataAccess Dataacces
        {
            get { return dataaccess; }
            set { dataaccess = value; }
        }

        public virtual void Add(string name)
        {
            dataaccess.Add(name);
        }

        public virtual void Delete(string name)
        {
            dataaccess.Delete(name);
        }

        public virtual void Update(int index,string name)
        {
            dataaccess.Update(index, name);
        }
        public virtual string Get(int index)
        {
            return dataaccess.Get(index);
        }

        public virtual void Show()
        {
            Console.WriteLine();
            Console.WriteLine("{0} 的顾客有", city);
            dataaccess.List();
        }
    }
}
