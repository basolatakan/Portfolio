using FluentValidation.AspNetCore;
using Portfolio.Models.ModelMatedataTypes;
using Portfolio.Models.Validators;
using System.Net;

var builder = WebApplication.CreateBuilder(args);   //Uygulama için bir yapılandırıcı (builder) nesnesi oluşturur.
                                                    //args → Komut satırından gelen argümanları alır (örneğin, ortam değişkenleri veya yapılandırmalar).
// Add services to the container. 
builder.Services.AddControllersWithViews();     //MVC (Model-View-Controller) yapısını kullanmak için controller ve view desteği
                                                //Servis konteynırına hizmetleri ekler.
var app = builder.Build();           //Yapılandırılan uygulama nesnesini oluşturur ve çalıştırılmaya hazır hale getirir.

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())       //app.Environment.IsDevelopment() → Uygulamanın şu an geliştirme ortamında olup olmadığını kontrol eder.
{
    app.UseExceptionHandler("/Home/Error");     //Eğer geliştirme ortamında değilsek; app.UseExceptionHandler("/Home/Error") → Hataları yönetmek için kullanıcıyı Home/Error sayfasına yönlendirir.
    app.UseHsts();                              //app.UseHsts() → HTTP Strict Transport Security (HSTS) mekanizmasını etkinleştirir. Bu, tarayıcıya yalnızca HTTPS üzerinden bağlanmasını söyler.
}

app.UseHttpsRedirection();  //HTTP isteklerini otomatik olarak HTTPS'ye yönlendirir.
app.UseStaticFiles();       // wwwroot klasöründeki CSS, JavaScript, resimler gibi statik dosyalara erişimi mümkün kılar.

app.UseRouting();           //Gelen isteklerin hangi controller ve action tarafından karşılanacağını belirler

app.UseAuthorization();     //Yetkilendirme(authorization) mekanizmasını devreye sokar. Kullanıcının belirli sayfalara erişim yetkisi olup olmadığını kontrol eder.

app.MapControllerRoute(     //MVC uygulamasında varsayılan rotayı tanımlar.
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
