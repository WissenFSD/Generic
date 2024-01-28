using System.Collections;

namespace Generic
{
    public class Generic
    {
        public string MYProp { get; set; }
        public Guid Guid { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Generic konusu c# 3.0 ile birlikte hayatımıza giren bir konudur.
            // Genericê  temel olarak şablon oluşturma  diyebiliriz.

            //Genericler tasarladığımız interface,class,method,koleksiyon'ların yada bunların parametrelerinin belirli bir tip için değil
            // şablon yapısına uyan tüm tipler için çalışmasını sağlayan bir teknolojidir.


            // Generic'in faydaları

            // Generic ile her tipte metot yapabildiğimiz için fazla kod yazmaya gerek kalmaz
            // her tipi tek metotta karşılayabildiğimiz için ekonoik kod yazmış oluruz.



            int veri = Method("veri");

            // Tek parametreli ve denüş değeri olan generic method
            int value = GenericMethod<int, string>("Value");
            string stringValue = GenericMethod<string, int>(10);


            // iki parametreli generic method

            float floatValue = GenericMethodWithParameters<float, byte, char>(200, 'A');



            // Kendi yazdığım Generic parametre alan metot sayesinde aşağıda görünebileceği üzere farklı tipteki parametreleri generic metot'uma gönderebildim.
            ReturnAllProperty<Generic>(new Generic());
            //ReturnAllProperty<Random>(new Random());
            //ReturnAllProperty<ArrayList>(new ArrayList());
            //ReturnAllProperty<Decimal>(10);
            //ReturnAllProperty<Queue>(new Queue());


        }
        public static void ReturnAllProperty<M>(M value)
        {
            // bu bir reflection örneğidir.

            var props = value.GetType().GetProperties();
            foreach (var item in props)
            {
                Console.WriteLine(item);
            }
        }
        public static int Method(string value)
        {
            return 0;
        }
        public static K GenericMethod<K, M>(M value)
        {
            return default(K);
        }
        static K GenericMethodWithParameters<K, M, L>(M mvalue, L lvalue)
        {
            return default(K);
        }

        // Generic parametre alan ve geriye değer döndürmeyen metot
        static void Method1<M>(M value)
        {

        }
        // Generic parametre alan geriye int döndüren metot
        static int Method2<M>(M value)
        {
            return 0;
        }
        // Generic alan ve generic döndüren metot(Parametre ile geri dönüş değeri aynı)
        static M Method3<M>(M value)
        {
            return value;
        }
    }
}