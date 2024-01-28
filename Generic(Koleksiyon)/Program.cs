using System.Collections;

namespace Generic_Koleksiyon_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            // Generic koleksiyonlar, çalışacağınız tipe göre tanımlama yapabileceğiniz koleksiyonlardır

            // Genericten önce bildiğimiz popüler koleksiyonlar object koleksiyonlardır.3
            

            // Object koleksiyonlar kolay olmasına karşın bazı sorunlar oluşturabilir.

            ArrayList arrayList = new ArrayList();
            arrayList.Add(100);
            arrayList.Add("Test");
            arrayList.Add(new Random());



            // Genericten sonra

            // List generic bir koleksiyondur

            List<int> list = new List<int>();
            list.Add(100);
            list.Add(20);
            list.Add(30);


            // string tanımlayalım

            List<string> listString = new List<string>();
            listString.Add("ali");
            listString.Add("kamil");
            listString.Add("oğuz");

            //Random koleksiyonu tanımlayalım

            List<Random> listRandom = new List<Random>();
            listRandom.Add(new Random());
            listRandom.Add(new Random());
            listRandom.Add(new Random());

            List<Guid> listGuid = new List<Guid>();
            listGuid.Add(Guid.NewGuid());
            listGuid.Add(Guid.NewGuid());

            // koleksiyonlar konusunu daha önce gördük.

            // Bizim gördüğümüz koleksiyonların tamamı object tipi ile çalışıyordu.



            // generic ile birlikte gördüğümüz koleksiyonların, generic olanlarıda mevcut.

            // Örnek Queue,HashSet,Stack etc.
               




            // List generic kullanarak bir diziyi ters çevirme uygulaması yapalım

           
        }
        static List<int> TersCevir(List<int> collection)
        {
            List<int> ints = new List<int>();
            int k = 0;

            for (int i = collection.Count - 1; i >= 0; i--)
            {

                ints[k] = collection[i];
                k++; 
            }
            return ints;
        }
    }
}