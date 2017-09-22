using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //在现实生活中，如果有同事出国或者朋友出国的情况下，我们经常会拖这位朋友帮忙带一些电子产品或化妆品等东西，
            //这个场景中，出国的朋友就是一个代理，他（她）是他（她）朋友的一个代理，由于他朋友不能去国外买东西，他却可以，
            //所以朋友们都托他帮忙带一些东西的。

            // 代理
            Person proxy = new Friend();
            proxy.BuyProduct();

        }
    }
}
