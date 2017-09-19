using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_PrototypePattern
{
    /// <summary>
    /// 孙悟空原型
    /// </summary>
    abstract public class MonkeyKingPrototype
    {
        public string Id { get; set; }
        public MonkeyKingPrototype(string id)
        {
            this.Id = id;
        }

        /// <summary>
        /// 克隆方法，变身
        /// </summary>
        /// <returns></returns>
        abstract public MonkeyKingPrototype Clone();
    }

    public class ConcretePrototype : MonkeyKingPrototype
    {
        public ConcretePrototype(string id):base(id)
        {

        }

        /// <summary>
        /// 浅拷贝
        /// </summary>
        /// <returns></returns>
        public override MonkeyKingPrototype Clone()
        {
            return (MonkeyKingPrototype)this.MemberwiseClone();
        }

        //浅拷贝是指当对象的字段值被拷贝时，字段引用的对象不会被拷贝。
        //例如，如果一个对象有一个指向字符串的字段，并且我们对该对象做了一个浅拷贝，
        //那么这两个对象将引用同一个字符串，而深拷贝是对对象实例中字段引用的对象也进行拷贝，
        //如果一个对象有一个指向字符串的字段，并且我们对该对象进行了深拷贝的话，
        //那么我们将创建一个对象和一个新的字符串，新的对象将引用新的字符串。
        //也就是说，执行深拷贝创建的新对象和原来对象不会共享任何东西，改变一个对象对另外一个对象没有任何影响，
        //而执行浅拷贝创建的新对象与原来对象共享成员，改变一个对象，另外一个对象的成员也会改变。
    }
}
