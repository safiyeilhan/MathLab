MathLab
======

MathLab, matematiksel hesaplamalar, grafikler ve araçlar sunan ASP.NET Core MVC tabanlı bir web uygulamasıdır.

Özellikler
- Denklem çözücü (Views/Home/Denklem.cshtml)
- Fonksiyon işlemleri (Views/Home/Fonksiyonlar.cshtml)
- Grafik çizimleri (Views/Home/Grafik.cshtml)
- Hesaplama araçları (Views/Home/Hesaplama.cshtml)
- İntegral hesaplama (Views/Home/Integral.cshtml)
- Türev hesaplama (Views/Home/Turev.cshtml)
- İstatistiksel analiz (Views/Home/Istatistik.cshtml)
- Diğer matematik araçları (Views/Home/MatematikAraclari.cshtml)

Teknolojiler
- .NET 10 (ASP.NET Core MVC)
- Bootstrap (wwwroot/lib/bootstrap)
- jQuery (wwwroot/lib/jquery)
- jquery-validation (wwwroot/lib/jquery-validation)

Gereksinimler
- .NET 10 SDK
- Visual Studio 2022 veya daha yeni (kullanıcı ortamına göre Visual Studio 2026 uyumludur)
- Alternatif olarak dotnet CLI (dotnet build, dotnet run)

Çalıştırma
1. Depoyu klonlayın:
   git clone https://github.com/safiyeilhan/MathLab.git
2. Çözümü açın:
   - Visual Studio: MathLab.slnx dosyasını açın ve proje başlatma profilini seçip çalıştırın.
   - dotnet CLI: proje klasörüne gidip aşağıyı çalıştırın:
	 dotnet build
	 dotnet run --project MathLab.csproj
3. Uygulama başlatıldığında tarayıcıda belirtilen URL'yi açın (ör. https://localhost:5001).

Yapılandırma
- appsettings.json ve appsettings.Development.json uygulama ayarlarını içerir.
- launchSettings.json (Properties/launchSettings.json) farklı başlatma profilleri ve port ayarlarını yönetir.

Katkıda Bulunma
1. Fork oluşturun.
2. Yeni bir dal açın: git checkout -b feature/özellik-adi
3. Değişiklikleri işleyin ve commit edin.
4. Pull request oluşturun.

Lisans
Bu projede lisans bilgisi yok. Lisans eklemek için LICENSE dosyası ekleyin.

İletişim
- Repo: https://github.com/safiyeilhan/MathLab

Notlar
- Proje MVC yapısında Views ve Controllers içerir. Razor Pages değil.
- Test altyapısı yok; testler eklenmemiştir.
