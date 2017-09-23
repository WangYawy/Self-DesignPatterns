using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_IteratorPattern
{
    /// <summary>
    /// 迭代器抽象类
    /// </summary>
    public interface Iterator
    {
        bool MoveNext();
        Object GetCurrent();
        void Next();
        void Reset();
    }

    /// <summary>
    /// 具体迭代器类
    /// </summary>
    public class ConcreteIteraor : Iterator
    {
        private ConcreteList _list;
        private int _index;
        public ConcreteIteraor(ConcreteList list)
        {
            this._list = list;
            _index = 0;
        }

        public object GetCurrent()
        {
            return _list.GetElement(_index);
        }

        public bool MoveNext()
        {
            if (_index < _list.Length)
            {
                return true;
            }
            return false;
        }

        public void Next()
        {
            if (_index < _list.Length)
            {
                _index++;
            }
        }

        public void Reset()
        {
            _index = 0;
        }
    }
}
