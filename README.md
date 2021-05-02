## <b>ASP.NET CORE (.NET 5) AUTHENTİCATİON & AUTHORİZATİON İŞLEMLERİNİ IDENTITY KÜPÜTHANESİNİ MVC VE RAZOR PAGES İLE DENEMEK</b> 

## 1️⃣ Gereksinimler



![ASD](https://img.shields.io/badge/VS%202019-Visual%20Studio-blueviolet) ![ASD](https://img.shields.io/badge/ASP.NET%20CORE-.NET%205-blue) ![](https://img.shields.io/badge/SQL%20SERVER%202019-Express-yellow) 



##  2️⃣ Authentication Nedir? 

Doğrulama anlamına gelir ve bilgilerinizi kontrol edilip doğrulandığı zaman authenticate olmuş olursunuz.
Login 'Giriş' sırasında yapılan işlemler denilebilir.



## 3️⃣ Authorization Nedir ? 

Yetki anlamına gelir ve kullanıcının örneğin o sayfaya erişiminin olup olmadığının kontrolü yapılır
Eğer authorized 'yetkili' iseniz o sayfaya erişebilir veya işlem yapabilirsiniz. Admin - User kullanıcı rolleri bunun en basit örneğidir.



##  🅰️ Authentication Çeşitleri

- Cookie Base Authentication
- Token Base Authentication 

####  🟠 **Cookie Base Authentication =>**

1. Kullanıcı giriş bilgilerini girer
2. Server tarafında bu bilgiler doğrulanır ve bu bilgilerin tutulduğu Session oluşturulur.
3. Cookie sesion ID yi kullanıcının browserında tutar ve belirli bir oturum sona erme süresi belirler
4. Daha sonra oturum talep edildiğinde, veri tabanına göre doğrulanır ve istek işlendiğinde, 
   bir kullanıcı uygulamadan çıkış yaptığında, oturum hem istemci tarafından yok edilir. 

####  🟠 **Token Base Authentication =>**

1. Kullanıcı önce oturum açma kimlik bilgilerini girer ve ardından sunucu kimlik bilgilerinin doğru olduğunu doğrular.

2. Doğruysa, signed token döndürür. 

3. Bu token client-side tarafında saklanır.

4. Ve en yaygın olarak yerel depolamanın (local storage) içinde, ancak oturum deposunda veya bir tanımlama bilgisinde de depolanabilir.

5. Sunucuya yapılan sonraki istekler, bu tokenı ek bir authorization header olarak veya 
   yukarıda belirtilen diğer yöntemlerden biri aracılığıyla barındırır.

6. Sunucu daha sonra JWT belirtecinin kodunu çözer ve Token geçerliyse isteği işler. Kullanıcı oturum kapattığında token yok olur

7. İstemci tarafında gerçekleşen bu işlemler sırasında sunucu etkileşimi gerekli değildir. 
   Bu nedenle, Stateless olduğu için, jeton tabanlı kimlik doğrulama, mobil uygulamalarda ve tek sayfalı uygulamalarda daha yaygındır. 

   

*Ancak cookie based authentication, sunucudan sunucuya (server to server) kimlik doğrulamasında daha yaygındır.*
*Cookie based authentication kullandığınızda, kullanıcı rolleriyle ilgili verileri depolamak için bir yere ihtiyacınız var.*



<p align="center"> <b> Asp.Net Core Identity yapısı ve Mimarisi </b> </p>


![ASP.NET Core Identity Mimarisi](https://www.linkpicture.com/q/ezgif.com-gif-maker-1_4.png)



 🟠 **Roles**

​	Kullanıcıların belli başlı sayfalara erişimini belirlememizi sağlayan ve bunun için roller tanımlayarak yetkilendirme yapmamıza imkan tanıyan bir stratejidir.

 🟠 **Claims**
	Doğrulanmış kullanıcıya açılmış oturum üzerinde kullanıcı kendisine has bilgileri Claims yapısı aracılığıyla tutabilmektedir. Örneğin; kullanıcı adı ve şifre ile doğrulanmış kullanıcının köpeğinin adını claim ile o oturumda taşıyabilmekteyiz.

​	*Claims Role-based'a göre daha esnek bir yapıdır. Belli bir konuda yasal yas siniri 18 diyelim. sadece 18 yaşından büyük kullanıcılar bu işlemi yapabiliyorlar, bir kullanıcı düşünün Admin yetkisinde ve 19 yaşında. Normalde bu işlemi yapabiliyor Admin yetkisinde ve hatta 19 yaşında. Ancak bir düzenleme geldi ve yas 20'ye çekildi. Simdi Role-based'a gore hala bu kişi yaş sınırına takılmadan bu işlemi yapabilecek eğer metodun içinde bir İF yoksa <strong>Claims</strong> der ki kullanıcı giriş yaptığında bir claims objesi oluştur ve ona ver, her geldiğinde bu talep objesi ile gelsin. Ben de bakayım içindeki değerlere gore bir mekanizma kurayım.* 

