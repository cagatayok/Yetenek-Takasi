# 🎯 Yetenek Takası

**Yetenek Takası**, kullanıcıların kendi beceri ve yeteneklerini ilan vererek *başkalarına öğretmelerini*,  
ve aynı şekilde başkalarından *yeni beceriler öğrenmelerini* sağlayan bir web uygulamasıdır.

Bu proje sayesinde kullanıcılar:
- Kendi yeteneklerini paylaşabilir
- Başkalarının yeteneklerini keşfedebilir
- Öğrenme ve öğretme fırsatlarını değerlendirebilir

---

## 📌 Proje Özeti

Bu web sitesi, kullanıcıların yeteneklerini karşılıklı olarak takas etmelerine olanak tanır.  
Kullanıcılar siteye becerilerini ilan olarak ekler ve diğer kullanıcıların ilanlarına göre yeni şeyler öğrenebilirler.

---

## 🧱 Özellikler

🔹 Kullanıcı kaydı & giriş  
🔹 İlan oluşturma  
🔹 Yetenek kategorileri  
🔹 İlan detay sayfası  
🔹 Kullanıcı profili & ilan yönetimi  

---

## 🛠️ Teknolojiler

Bu proje büyük olasılıkla şu teknolojileri kullanır (repo içeriğine göre güncellenebilir):

| Katman | Teknoloji |
|--------|-----------|
| Frontend | HTML, CSS,BootStrap JavaScript |
| Framework | (React) |
| Backend | (.NET C#) |
| Database | (SQL / FİREBASE) |

🚀 Kurulum & Çalıştırma

Bu proje .NET Backend, SQL veritabanı ve Firebase Authentication kullanılarak geliştirilmiştir.

📥 1. Projeyi Klonlayın
git clone https://github.com/cagatayok/Yetenek-Takasi.git
cd Yetenek-Takasi

🧠 2. Backend (.NET) Kurulumu
Gerekli Araçlar

.NET SDK (6.0 veya üzeri)

SQL Server (veya kullanılan SQL altyapısı)

Visual Studio / VS Code

Backend’i Çalıştırma
dotnet restore
dotnet build
dotnet run


Backend varsayılan olarak belirlenen port üzerinden çalışacaktır.

🗄️ 3. Veritabanı (SQL)

İlanlar ve uygulama verileri SQL veritabanında tutulmaktadır.

appsettings.json dosyası içindeki ConnectionString alanını kendi SQL yapılandırmanıza göre düzenleyin.

"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=YetenekTakasiDB;Trusted_Connection=True;"
}


Gerekli tablolar migration veya manuel script ile oluşturulmalıdır.

🔐 4. Firebase Authentication

Bu projede:

Üye olma

Giriş yapma

Kullanıcı doğrulama

işlemleri Firebase Authentication ile yapılmaktadır.

Firebase Ayarları

Firebase Console üzerinden bir proje oluşturun

Authentication → Email/Password yöntemini aktif edin

Firebase config bilgilerini frontend veya backend tarafına ekleyin

const firebaseConfig = {
  apiKey: "API_KEY",
  authDomain: "PROJECT_ID.firebaseapp.com",
  projectId: "PROJECT_ID",
};

🌐 5. Frontend Çalıştırma

Frontend ayrı bir klasördeyse:

npm install
npm start


Frontend, backend API ile haberleşecek şekilde yapılandırılmıştır.


🧪 Kullanım

Siteye kayıt olarak giriş yapın

Yetenek ilanı oluşturun

Başkalarının ilanlarını görüntüleyin

İlanlara göre kullanıcılarla etkileşime geçin

## 📸 Ekran Görüntüleri

<p align="center">

  <img src="Ekran%20görüntüsü_29-12-2025_21146_.jpeg" width="700">
  <br><br>
  <img src="Ekran%20görüntüsü_29-12-2025_21227_.jpeg" width="700">
  <br><br>
    <img src="Ekran%20görüntüsü_29-12-2025_21046_.jpeg" width="700">
  
</p>



