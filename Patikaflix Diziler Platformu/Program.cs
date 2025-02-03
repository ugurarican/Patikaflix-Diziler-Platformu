using Patikaflix_Diziler_Platformu;
using System.Threading.Channels;
using System.Xml;

List<TVShow> tvShows = new List<TVShow>();

Console.WriteLine("Lütfen dizi bilgilerini girin:");
while (true)
{
    Console.WriteLine("Dizi adı:");
    string diziAdi = Console.ReadLine();

    Console.WriteLine("Yapım Yılı:");
    int yapimYili;
    while (!int.TryParse(Console.ReadLine(), out yapimYili))
    {
        Console.WriteLine("Lütfen geçerli bir yıl girin:");
    }

    Console.WriteLine("Dizi Türü:");
    string diziTuru = Console.ReadLine();

    Console.WriteLine("Yayımlanmaya Başlama Yılı:");
    int yayimlanmaYılı;
    while (!int.TryParse(Console.ReadLine(), out yayimlanmaYılı))
    {
        Console.WriteLine("Lütfen geçerli bir yıl girin:");
    }
    Console.WriteLine("Yönetmen:");
    string yonetmen = Console.ReadLine();

    Console.WriteLine("Yayımlandığı İlk Platform:");
    string ilkPlatform = Console.ReadLine();

    TVShow show = new TVShow(diziAdi, yapimYili, diziTuru, yayimlanmaYılı, yonetmen, ilkPlatform);
    tvShows.Add(show);
    Console.WriteLine("Dizi eklemeye devam etmek istiyor musunuz?(h)");
    string devam = Console.ReadLine();
    if (devam.ToLower() == "h")
    {
        break;
    }
    }
    var comedyShows = tvShows.Where(x=>x.DiziTuru.ToLower()=="komedi")
                             .Select(x=> new ComedyShow(x.DiziAdi, x.DiziTuru, x.Yonetmen))
                             .OrderBy(x=>x.DiziAdi)
                             .ThenBy(x=>x.Yonetmen)
                             .ToList();
    Console.WriteLine("\n Sıralanmış Komedi Filmleri:");
    foreach(var comedyShow in comedyShows)
    {
        Console.WriteLine($"Dizi Adı: {comedyShow.DiziAdi}, Türü: {comedyShow.DiziTuru}, Yönetmen: {comedyShow.Yonetmen}" );
    }

