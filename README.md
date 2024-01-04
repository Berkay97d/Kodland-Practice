# Kodland-Practice

OYUN KIRAN HATALAR

Enemy1 Enemy tagine sahip 2 ve 3 untagged durumda bırakılmış.
Enemy'de sadece disabled character controller var, Enemy1'de sadece rigidbody var, Enemy2'de disabled character controller ve rigidbody var, enemy prefabı oluşturuldu ve gereksiz komponentler çıkartıldı.

Player character Controller disabled bırakılmış.
Player Look scriptindeki mouse sense 0 bırakılmış, 1'e çekildi.
Player Controller scriptinde bullet referansı yok, atama yapıldı.
Player Controller Scriptinde Start içinde Destroy(this) olduğu için komponent kendini yok ediyor, kod kaldırıldı.
Player Controller Scriptinde Start içinde ChangeHealth(0) olduğu için lost fonksiyonu triggerlanıyor ve Lost Ekranı açılıyor, kod ChangeHealt(100) olarak değiştirildi.
Player look scriptinde player'ı döndürme işlemi yanlış uygulanmış, player'a uygulanması gereken axislerden bir tanesi playerArms adındaki boş game objeye uygulandığı için player y axis'inde hareket edemiyor yalnıca x axisinde hareket edebiliyor, gereksiz playerarms referansı kaldırıldı.
Player Look scriptinde clampleme işlemi doğru yapılmamış, önce 0-360 arasında hesaplanan x rotasyonu 180 ve -180 aralığına çevirildi sonra math classının clamp fonksiyonu ile clamplendi.
Mouse sağ click ile etraftaki düşmanları algılayıp destroy eden kod silindi, böyle bir şey istendiği yazmıyor, düşmanlar mermiler tarafından yok edilmeli, bu nedenle gereksiz kod bloğu silindi.
Oyun assetleri içerisnde "heal" ya da "finish" taginde herhangi bir asset bulunmadığı ve bizden de buna yönelik bir şey istenmediği için gereksiz kodlar silindi, kod yakınımızda enemy varsa öleceğimiz şekilde revize edildi, bu durumun yaşanabilmesi ve bunu tam bir oyun olabilmesi için enemylere oyun başlayınca bize doğru yürümeleri için EnemyController scripti eklendi.
Bullet classına bulletlar enemyleri algıladıklarında önce enemyleri sonra kendilerini destroy eden kodlar eklendi.
3 düşmanı da öldürdüğümüzde kazanmamız için bullet classına statik öldürülen düşman sayacı eklendi ve player controller classında 3 olduğu zaman win fonksiyonu çağırıldı.


HATALI KULLANIMLAR

Enemy prefab'ı yok, çok sayıda kullanacağımız ve aynı ya da benzer davranışları istediğimiz objeler için prefab kullanmak her zaman önemlidir.
Player controller bullet prefabın referansı gameobject olarak verilmiş bullet içindeki fonksiyonu çağırmadan önce getComponent kullanılmak zorunda kalınıyor,referans bullet olarak verilseydi fazladan zahmete girmemize gerek kalmazdı.
PlayerLook scriptinde Cursor.lockstate locked mode'a update içersinde alınmış, eğer bunu yapmak istiyorsak da startın içerisinde 1 kere yapmamız yeterlidir. 
Dış classlarda çağırılmayan win-lost fonksiyonları public yapılmış, minimum erişim maksimum güvenlik demektir, dışarıdan ve ya alt classlardan erişilmeyen fonskiyonlar ve değişkenler private olmalıdır.
Bullet scriptinde setDirection fonksiyonu camelCase Case Type'ında yazılmış C# standarları PascalCase ile yazılır, standartlar uygun bir kod herkes tarafından daha rahat okunur.
Bullet scriptinde speed ve direction değişkenlerinin ve Fixed update fonksiyonunun access modifierları yok, standartlar yine önemlidir, boş access modifier ve private key'i birebir aynı olsa da ne fieldlarımıza ne de fonksiyonlarımıza bir access modifier'ı çok görmeyelim :)
Dağınık hierarcy ve dosyalama sistemi dağınık bir oda gibidir, ne odamızı ne de projemizi dağınık tutmamlıyız ki kafamız karışmasın.
İyi bir oyunu tekrar oynayabilmek için kapatıp açmak zorunda kalmamalıyız.


