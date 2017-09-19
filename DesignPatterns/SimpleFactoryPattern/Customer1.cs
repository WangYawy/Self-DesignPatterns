using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    /// <summary>
    /// 自己做饭的情况
    /// 没有简单工厂之前，想吃什么自己做
    /// </summary>
    public class Customer1
    {
        /// <summary>
        /// 做菜
        /// </summary>
        /// <param name="type">菜名</param>
        /// <returns></returns>
        public static Food Cook(FoodType type)
        {
            Food food = null;
            // 根据要什么菜就去做什么菜
            if (type == FoodType.xihongsichaojidan)
            {
                food = new xihongshishaojidan();
            }
            else if (type == FoodType.tudourousi)
            {
                food = new tudourousi();
            }
            return food;
        }
    }

    

}
