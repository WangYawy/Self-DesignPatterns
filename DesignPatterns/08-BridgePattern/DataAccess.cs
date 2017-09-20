using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_BridgePattern
{
    /// <summary>
    /// 数据访问层
    /// </summary>
    abstract public class DataAccess
    {
        abstract public void Add(string name);
        abstract public void Delete(string name);
        abstract public void Update(int index,string name);
        abstract public string Get(int index);
        abstract public void List();

    }

    public class CustomerDataAccess : DataAccess
    {
        private List<string> customers = new List<string>();

        public override void Add(string name)
        {
            customers.Add(name);
        }

        public override void Delete(string name)
        {
            customers.Remove(name);
        }

        public override string Get(int index)
        {
            return customers[index];
        }

        public override void List()
        {
            foreach (var item in customers)
            {
                Console.WriteLine(" " + item);
            }
        }

        public override void Update(int index ,string name)
        {
            customers[index] = name;
        }
    }
}
