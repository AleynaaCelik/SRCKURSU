# SRCKURSU
Sürücü Kursu Uygulaması Projesi
Proje Tanımı
Bu proje, Bilecik Şeyh Edebali Üniversitesi 2021-2022 Eğitim-Öğretim Yılı Bilgisayar Mühendisliği Tasarım-2 dersi kapsamında geliştirilmiş bir sürücü kursu yönetim sistemidir. Proje, sürücü kurslarındaki öğrenci kayıtları, ders programları, sınav sonuçları gibi bilgilerin dijital ortamda yönetilmesini ve takip edilmesini sağlar. Bu proje, C# programlama dili kullanılarak Windows Form uygulaması şeklinde geliştirilmiş ve veritabanı işlemleri için Microsoft SQL Server (MSSQL) kullanılmıştır.

Proje İçeriği ve Kullanılan Teknolojiler
Programlama Dili: C#
Geliştirme Ortamı: Microsoft Visual Studio
Veritabanı Yönetim Sistemi: Microsoft SQL Server (MSSQL)
Arayüz: Windows Forms

Uygulama Fonksiyonları
Uygulama, sürücü kursu yönetimi için gerekli olan temel fonksiyonları sağlamaktadır. Bu fonksiyonlar arasında şunlar bulunmaktadır:

Öğrenci Kayıtları: Yeni öğrencilerin sisteme kaydedilmesi, mevcut öğrenci bilgilerini güncelleme ve silme işlemleri.
Eğitmen Yönetimi: Eğitmenlerin kaydedilmesi, güncellenmesi ve silinmesi işlemleri.
Ders Programları: Derslerin oluşturulması, ders programlarının görüntülenmesi ve güncellenmesi.
Sınav Sonuçları: Öğrencilerin sınav sonuçlarının kaydedilmesi ve görüntülenmesi.
Uygulama Arayüzü
Uygulamanın arayüzü, kullanıcı dostu ve işlevsel olacak şekilde tasarlanmıştır. Windows Forms kullanılarak geliştirilmiş olan arayüz, kullanıcıların kolayca veri girişi yapmasını ve gerekli bilgilere hızlıca erişmesini sağlar.

Ana Menü: Ana menü, öğrenci kayıtları, eğitmen yönetimi, ders programları ve sınav sonuçlarına erişim sağlar.
Öğrenci Kayıt Formu: Öğrencilerin bilgilerini girmek için kullanılır.
Eğitmen Yönetim Formu: Eğitmen bilgilerini yönetmek için kullanılır.

Veritabanı Bağlantısı
C# ile MSSQL veritabanı arasında bağlantı kurmak için SqlConnection sınıfı kullanılmıştır. Veritabanı bağlantı bilgileri uygulama içerisinde aşağıdaki gibi tanımlanmıştır:

string connectionString = "Server=your_server_name;Database=your_database_name;User Id=tester;Password=Tester_74;";
using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();
    // Veritabanı işlemleri burada gerçekleştirilir.
}
