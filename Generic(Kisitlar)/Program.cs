namespace Generic_Kisitlar_
{

    interface IGeneric
    {

    }
    class Wissen : IGeneric
    {
        public Wissen(string a)
        {

        }
    }
    class SubWissen : Wissen
    {
        public SubWissen(string a) : base(a)
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Generic kavramında, generic olarak belirlenmiş metotlara gelebilecek olan parametrelere sınır getirebiliriz.


            // Aşağıda getirebileceğimiz 5 adet farklı kısıt mekanizması incelenmiştir.



            // Class kısıtı olan bir metoda struct parametre gönderilemez.
            // Generic1<int>(10);


            // Generic2 metodu struct kısıtı olduğu için int tipini sorunsuz parametre olarak aldı
            //Generic2<int>(10);


            // class kısıtı olan generic metoda Random sınıfını gönderelim
            //Random bir class olduğu için class kısıtı olan metoda parametre olarak gönderildi.
            //Generic1<Random>(new Random());


            //Default ctor kısıtı
            //Generic3<Wissen>(new Wissen());


            // Kalıtım kısıtı
            //Generic4<SubWissen>(new SubWissen(""));



            // Interface kısıtı
            Generic5<Wissen>(new Wissen(""));
        }

        // Generic kısıtlar, temel olarak generic olarak kullanılacak olan tüm tiplere kısıtlar koymaya denir

        // M sadece class olabilir(Referans type olabilir)
        static void Generic1<M>(M value) where M : class
        {

            Console.WriteLine(value);
        }

        // M sadece struct olabilir(Value type olabilir)
        static void Generic2<M>(M value) where M : struct
        {

            Console.WriteLine(value);
        }
        // M yerine gelecek olan tiplerin default ctor'u olması lazım
        // Her sınıfta eğer siz bir ctor yazmazsanız derleyici bir default ctor yazar
        // bu örnekte wissen class'ını kullandık.
        // Wissen class'ınına bir ctor yazmadığınızda bu metoda parametre olarak gönderilebilir.
        // ancak bir parametreli ctor yazdığınızda bu metoda parametre olarak gönderilirse derleme zamanı hatası alacaktır
        static void Generic3<M>(M value) where M : new()
        {
            Console.WriteLine(value);
        }

        // Bu metoda ya wissen sınıfı gelebilir, yada wissen sınıfından kalıtılan sınıflar gelebilir
        // Bu örnek için wissen sınıfından kalıtılan SubWissen sınıfı kullanıldı
        static void Generic4<M>(M value) where M : Wissen
        {

            Console.WriteLine(value);
        }

        // M yerine gelecek tüm değerler, kesinlikle IGeneric interfacesini implement etmek zorundadır.
        static void Generic5<M>(M value) where M : IGeneric
        {


        }
        // çoklu kısıt

        // M yerine gelecek olan değer IGeneric interfacesini implement etmiş olacak ve default ctor'u olacak
        static void Generic6<M>(M value) where M : IGeneric, new()
        {


        }




        // Çoklu

        // M hem wissen sınıfından katılılmalı hemde IGeneric interfacesini implement etmeli
        static void Generic7<M>(M value)where M :Wissen, IGeneric
        {


        }

        // M referans type olmalı ve IGeneric interfacesini implement etmiş olmalıdır.
        static void Generic8<M>(M value)where M:class,IGeneric
        {

        }



        // bu generic interfacelerden sonra konuşulacak
        static void Generic9<M>(M value)where M:class,ICollection<M>
        {



        }
    }
}