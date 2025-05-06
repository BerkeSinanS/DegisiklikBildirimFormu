# DegisiklikBildirimFormu / MailBildirimUygulamasi
Açıklama
Bu proje, kullanıcıların değişiklik bildirim formları oluşturmasını ve bu formların belirli e-posta adreslerine gönderilmesini sağlar. İki ayrı uygulamadan oluşur:
  DegisiklikBildirimFormu: Kullanıcıların form oluşturmasını sağlayan uygulama.
  MailBildirimUygulamasi: Oluşturulan formları düzenli aralıklarla kontrol ederek, formda seçilen e-posta adreslerine gönderen uygulama.
Her iki uygulama da PostgreSQL veritabanı ile çalışır ve Docker container'ları içinde barındırılır.

Özellikler
  CRUD işlemleri
  Form oluşturma ve gönderme
  E-posta bildirimleri
  Docker ile containerizasyon
  PostgreSQL veritabanı entegrasyonu

Gereksinimler
  .NET 6 SDK
   Docker
   PostgreSQL

   Adımlar
  1- Projeyi klonlayın:
    git clone https://github.com/BerkeSinanS/DegisiklikBildirimFormu.git
    git clone https://github.com/BerkeSinanS/MailBildirimUygulamasi.git 
       
  2- Docker container'larını başlatın:
     docker-compose up -d 
       
  3- Uygulamaları başlatın:
    cd DegisiklikBildirimFormu
      dotnet run
    cd ../MailBildirimUygulamasi
     dotnet run
    
