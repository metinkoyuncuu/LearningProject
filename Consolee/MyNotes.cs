
namespace Consolee;

public class MyNotes
{

    string myNotesForValueType =
        "integer,double,decimal,enum,bool(sayısal) bir değer tiptir" +
        "değer tip stack de tanımlanır ve stack de değeri atanır" +
        "Değer tip üzerinde değişiklik yaparsak direkt olarak stack de değiştirilir ve sadece o tanımı etkiler" +
        "";
    string myNotesForReferenceTypes = "" +
        "arraylerin hertürlüsü referans tiptir integer da olsa dizi de olsa" +
        "interfaceler classlar abstract classlar referans tiptir" +
        "string referans tiptir fakat değer tip gibi çalışır" +
        "sehirler1 gibi bir string arrayim olursa string[] sehirler1 kısmı stack'de oluşur" +
        "Referans tipte stack'de tutulan değere bir kod atanır ve new string[] {'istanbul','izmir'} " +
        "kısımları stackde tutulan kod ile heap'de tutulur(koda 101 diyelim)" +
        "sehirler2'de olsun o da 102 koduyla oluşsun" +
        "sehirler2=sehirler1 deseydik stack'de tutulan sehirler2 nin kodu 101 olacaktı fakat heap'de " +
        "bir değişiklik olmayacak" +
        "sehirler2[0]='rize' dersek heap'de değişiklik yapılır ve 101 kodlu string array değişerek rize izmir olur" +
        "sehirler1[0] elemanını yazdırırsak yani 101 kodlu heap'de tutulan arraydeki 0'ıncı eleman okunacak" +
        "yani rize" +
        "102 kodunu tutacak bir referans kalmadığı için yani stack'de o yüzden garbagecollector ile atılır";

    string myNotesForInterfaces = "" +
        "Yazılımsal olarak classlara arayüz görevi görür" +
        "Classların o operasyonları imzalamasını zorunlu hale getirir" +
        "Sürdürülebilir yazılımın üyelerinden bir tanesidir" +
        "" +
        "";

    string myNotesForFrameworkAndLibraryDiffrence = "" +
        "Framework uygulama çatısıdır" +
        "Yani uygulamamızı o çatıya göre geliştiririz(Örneğin AspNet Mvc)" +
        "JQuery ise bir library dir. Mvc içerisinde jquery kullanırız" +
        "Kütüphanelerin ortak özelliği işleri kolaylaştırmasıdır" +
        "Methodlar topluluğudur kütüphaneler." +
        "Library basitleştirilmiş kodlar methodlar fonksiyonlar topluğudur";

    string myNotesForSOLID = "" +
        "Yazılımda sürdürülebilirliği desteklemek adına kullanılan prensiplerdir" +
        "Yazılımda sürdürülebilirlik = Yazılımı ihtiyaca göre şekillenmesi" +

        "Single Responsibility Principle(tek sorumluluk prensibi)" +
        "bir method bir class bir katman sadece bir iş yapmak zorundadır" +
        "Method için =aynı işlemin farklı versiyonları aynı method içersinde olmamalı" +
        "yani kısacası 3 le 5 i topluyosan heryerde yapmak yerine method haline getir" +
        "Class için = manager da manager bulunsun entity gibi kullanılmasın" +
        "Katmanlarda bussiness kodu bussiness da olmalı vs vs" +

        "Ooen Closed Principle(Uygulamalar geliştirmeye açık değişime kapalı olmalıdır)" +
        "Uygulamalar yeni özellikler eklemeye açık olmalıdır." +
        "Fakat bu değişikleri mevcut kodları değiştirerek yapmamalıyız." +
        "Yeni kurallar geldiğine varolan kod değişmemeli sadece ekleme yapılabilmemi" +

        "Liskov's Subsitution Principle(Liskov'un yerine koyma prensibi)" +
        "Örneğin bir işletmeyle ilgili 2 tip müşterisi var. Şahıslar ve Şirketler" +
        "Şirketin ünvanı var şahsın ise ismi var" +
        "Bunları aynı tabloda tutup firmanın ismini de şahısın ismini de aynı tabloda tutmamalıyız" +
        "Dezavantajı aynı tabloda tuttuğumuzda şahsın soyadı zorunlu tuttuğumuz senaryoda" +
        "şirketin bir soyadı olmayacağı için nullable yapamayız ve programda halledebilirsek de" +
        "sistemine güvenme hata her zaman olur" +
        "Bunu Engellemek için Müşteri ana tablosu gerçek müşteri ve şahıs müşteri tablosu yapılmalı" +
        "Hepsi Müşteri Tablosuna bağlı" +
        "Sırf birbirine benziyo diye bunları aynı çatıda toplamıyoruz" +

        "Interface Seggregeation Principle(interface implemente edildiğinde gerekli operasyonların hepsi yoksa ayrıştırılmalı )" +
        "Varsayalım ki 3 bankayla çalışıyoruz. Bir interface oluşturduk" +
        "interface içersinde 2 adet operasyon olsun " +
        "1.ve 2. banka kodlarında 2 adat operasyonun ikisi de kullanılıyor methodların içersi dolu" +
        "Fakat 3. banka yalnızca ilk operasyonu kullanacak 2. operasyonla işi yok " +
        "Bunun çözümü gruplaştırmak yani ana bir interface olmalı varsayalım IBankConnector" +
        "Ayrıştırma yaparak önceki senaryodakileri de 2 interface e bölmeliyiz." +
        "varsayalım IxConnector ve IyConnector" +
        "IxConnector 1.ve 2. Operasyonu taşımalı fakat Iy Connector yalnızca 1. operasyonu taşımalı" +
        "Bu Yüzeden IBankConnector'ın içine 1. Operasyonu koyuyoruz ve IxCOnnector içersine" +
        "2. operasyonu koyuyoruz ve IyConector u boş bırakıyoruz" +
        "İki interface i de :IBankConnector " +
        "Olay interface leri de doğru parçalara ayırmak." +

        "Dependency Inversion Principle" +
        "Yüksek seviyeli sınıfların düşük seviyeli sınıfları somut değil de soyut halleriyle kullanmasıdır" +
        "Bu da bağımlılığı düşürür" +
        "Temel olarak bir tasarım modeli kullanılır (dependency injection)" +
        "constroctur da bağımlılık sınıfın implementasyonu olan interface çağırılır(private readonly)" +
        "Katmanlı mimarilerdeki katmanların geçişini kullanmak için çok kullanılır (depinj)" +

        "IOC Container(Inversion Of Control)" +
        "Ninject,Unity,CastleWindsor,StructureMap" +
        "Autofac" +
        "Biri Senden x isterse ona y ver" +

        "Katmanlı Mimariler" +
        "Nedir" +
        "Yazılımda belirli katmanların oluşturulması ve kodların buna göre yazılmasıdır" +
        "Başlangıç 3 katmanlı mimamiridir" +
        "DataAccess(Database ile etkileşim kuran katman denilebilir)" +
        "Burada sadece select,insert,update,delete,truncate,drop" +
        "Business(İş Katmanı Burada İş Kodları yazılır)" +
        "İş Kuralları, dataaccess ile ciddi ilişki içersindedir." +
        "Karar mekanizması Business'dır" +
        "UI(Uygulama Arayüzü)" +
        "ASPNET MVC" +
        "Sadece Arayüzü ilgilendiren koddur." +
        "Service Katmanı(Restful yapılar)(Anguların görüşmesini sağlayan yapı(WEBAPI))" +

        "Abstract Sınıflar" +
        "Abstract Classlar newlenemez" +
        "ctor içerebilir kendi başına çalışmaz fakat inherit olduğu sınıf newlendiğinde çalışabilir" +
        "ctor public değil protected olmalı bunun sebebi aşağıdaki" +
        "Abstract class'ın iç durumlarını koruma,mirasa açıklık gibi sebeplerden kullanılır" +
        "Class'dır class yapısına sahiptir." +
        "Hem tamamlanmış hem tamamlanmamış operasyon içerebilir" +
        "tanımlaması abstrack class x{}" +
        "içerisine public abstract void y(); ile tamamlanmamış bir operasyon yazabiliriz." +
        "Görsel 1 e bak(yarım operasyonlar için) " +
        "Görseldeki gibi override mevzusu ezilebilir olması anlamına geliyor ve sınıf" +
        "istediği gibi içersinde farklı operasyonları yazabilir" +
        "tam bir operasyon method yazdığımızda implemente olduğu bütün sınıflar abstractaki" +
        "methodu kullanabilir. Görsel 2 deki gibi" +

        "Virtual Keyword" +
        "Abstract class'lardan gidersek" +
        "public virtual void Kaydet(){} dersek" +
        "İsteyen onu ezebilir demek" +
        "kullanımı. Görsel 1 " +
        "Görseldeki methodda eğer ki kaydetin içersinde base.Kaydet() deseydik " +
        "basedeki kaydet çalışırdı" +
        "normal sınıflarda'da aynı şekilde geçerlidir" +

        "AccessModifiers(Erişim Bildirgeçleri)" +
        "Başka nesneler başka ortamlar bizim nesnelerimize ulaşabilirmi ulaşabilirse ne kadar ulaşabilir" +
        "Bir Class Yalnızca public veya internal olabilir private ve protected olamaz" +
        "Bir CLass private 'ın yapılmasının tek yolu aşşağıdaki dir.(nestedClass denir)" +
        "Erişim Sıralaması Private-Protected-internal-public" +

        "Internal" +
        "Diğer Uygulamalar katmanlar gibi düşünürsek bunu kullanamazlar." +
        "Yani Bussiness içinde bir internal classın varsa bussiness içinde heryerde kullanabilirsin" +
        "fakat dataaccess ve ui bunu newleyemez çağıramaz referans verse bile" +
        "Aynı namespace içersinden erişilebilir" +

        "Public" +
        "Solution İçersindeki heryerden erişilebilir" +
        "Farklı assembly lerde erişebilir" +

        "Private" +
        "Herhangi bir şey private sa üzerindeki {} scope arasında geçerlidir." +
        "süslü parantez içersindeki alanlarda kullanılabilir yalnızca" +
        "değişken tanımlandığında default'u private'dır" +

        "Protected" +
        "private dan farklı olarak inherit verdiği sınıfta da geçerlidir" +
        "İki Alttaki kod bloğu" +

        "C# nedir" +
        "C# bir dildir." +
        "İki kişinin anlaşması için kullanılan dildir C# veya visualBasic" +
        "İkiside arka planda .netdir ikiside aslında arka planda .net diline çevrilir" +
        ".net deki operasyonlar ve daha sonra o operasyonların makine diline çevrilmesidir" +
        "Hangi uygulama türleri geliştirilebilir" +
        "WTF,Windows form,console,library,asp.met uygulamaları,wcf,unit test" +

          "MVC" +
          "Arayüz İçin Bir Tasarım Desenidir" +
          "Katmanlı Mimari Değildir." +


          "Polymorphism" +
          "Interfacelerin veya base classların implemente veya inherit edildikleri sınıfın" +
          "referansını tutma özelliğinden dolayı o interface üzerinden farklı implementasyonları " +
          "geçebiliyoruz" +
          "Soyutlamanın en temel olayıdır" +
          "manager m = new manager(new x()) bir polymorphism dir";
    internal class x
    {
        private int PrivateSayi = 1;
        protected int ProtectedSayi = 2;
        private class y
        {

        }
    }
    ;
    class u : x
    {
        public u()
        {
            ProtectedSayi.ToString();
            //PrivateSayi//Bulunamıyo
    }
    }


}
