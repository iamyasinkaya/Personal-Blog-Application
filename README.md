# Personal Blog Uygulaması

Bu projede, kişisel bir blog uygulaması oluşturmak için kullanılan bir projeyi paylaşıyorum. Bu uygulama, kullanıcıların blog yazıları oluşturmasına, düzenlemesine ve yayınlamasına olanak tanır.

## Özellikler

- Kullanıcılar, kayıt oluşturarak hesap oluşturabilir ve giriş yapabilir.
- Oturum açmış kullanıcılar yeni blog yazıları oluşturabilir, mevcut yazıları düzenleyebilir ve yayınlayabilir.
- Kullanıcılar, yazılarına başlık, içerik ve kategori ekleyebilir.
- Tüm blog yazıları ana sayfada listelenir ve kullanıcılar tarafından okunabilir.
- Kullanıcılar, blog yazılarını kategoriye göre filtreleyebilir.
- Blog yazılarına yorum yapılabilir ve yorumlar görüntülenebilir.
- Kullanıcılar, kendi hesaplarını düzenleyebilir ve profil bilgilerini güncelleyebilir.
- Kullanıcılar, hesaplarını silebilir ve tüm verileriyle birlikte blog yazılarını da kaldırabilir.

## Kurulum

1. Bu projeyi klonlayın: `git clone https://github.com/iamyasinkaya/Personal-Blog-Application.git`
2. Proje dizinine gidin: `cd Personal-Blog-Application`
3. Gerekli bağımlılıkları yükleyin: `npm install`
4. Veritabanını yapılandırın:
   - `config/default.json` dosyasını açın ve veritabanı bağlantı ayarlarınızı yapın.
   - Örneğin, MongoDB kullanıyorsanız, `mongoURI` alanını güncelleyin.
5. Uygulamayı çalıştırın: `npm start`

## Kullanım

- Uygulama başlatıldığında, tarayıcınızda `http://localhost:3000` adresini açın.
- Ana sayfada, kayıt olun veya mevcut bir hesapla giriş yapın.
- Giriş yaptıktan sonra, yeni bir blog yazısı oluşturabilir veya mevcut yazıları düzenleyebilirsiniz.
- Yazıları kategoriye göre filtrelemek için sağ üst köşedeki menüyü kullanabilirsiniz.
- Yazılara yorum yapmak için yazının altındaki yorum bölümünü kullanabilirsiniz.
- Kullanıcı profili için sağ üst köşedeki avatarınıza tıklayabilirsiniz.
- Profil sayfasında hesap ayarlarınızı düzenleyebilir veya hesabınızı silebilirsiniz.

## Katkıda Bulunma
Kat contributions yapmak için lütfen CONTRIBUTING.md dosyasını inceleyin.
