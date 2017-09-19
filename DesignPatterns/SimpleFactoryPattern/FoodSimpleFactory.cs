using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public class FoodSimpleFactory
    {
        /// <summary>
        /// 简单工厂，类比厨师，负责做菜
        /// </summary>
        /// <param name="type">菜名</param>
        /// <returns></returns>
        public static Food CreateFood(FoodType type)
        {
            Food food = null;
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
