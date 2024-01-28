using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Interface_
{
    public interface IGenericInterface<T, K, M>
    {
        public T Generic1<T, K>(K value);
        public T Generic2<T, K, M>(K kValue, M mValue);


    }
    public class ClassInterface : IGenericInterface<Random, string, decimal>
    {
        public T Generic1<T, K>(K value)
        {
            throw new NotImplementedException();
        }

        public T Generic2<T, K, M>(K kValue, M mValue)
        {
            throw new NotImplementedException();
        }
    }

}
