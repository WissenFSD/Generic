using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Interface_
{


    // Generic interfaceler, generic olan metotların imzaları taşır.

    // Interface'de generic tasarlanan bu metotlar generic olarak sınıflara metotları aktaracaklardır.



    //Bu örnekte interface generic değil, sadece taşıdığı metotlar generic.
    public interface IWissen
    {
        public T GetAllProduct<T,M>(M value);
        public T GetUserById<T>(int id);

        public TResult GetAll<TResult, MParam>(MParam value);

        public Besiktas GetIds<Besiktas, Kadikoy>(Kadikoy value);

    }
    public class MyClass : IWissen
    {
        public TResult GetAll<TResult, MParam>(MParam value)
        {
            throw new NotImplementedException();
        }

        public T GetAllProduct<T, M>(M value)
        {
            throw new NotImplementedException();
        }

        public Besiktas GetIds<Besiktas, Kadikoy>(Kadikoy value)
        {
            throw new NotImplementedException();
        }

        public T GetUserById<T>(int id)
        {
            throw new NotImplementedException();
        }
    }
}
