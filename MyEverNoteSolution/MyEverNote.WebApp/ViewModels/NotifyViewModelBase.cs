using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEverNote.WebApp.ViewModels
{
    public class NotifyViewModelBase<T>
    {
        //Hata, Uyarı, Bilgi ve Ok içeren sayfalar için temel bir yapı dizayn ediyorum.
        public List<T> Items { get; set; }
        public string Header { get; set; }
        public string Title { get; set; }
        public bool IsRedirecting { get; set; }
        public string RedirectingUrl { get; set; }
        public int RedirectingTimeOut { get; set; }
        public NotifyViewModelBase()
        {
            Header = "Yönlendiriliyorsunuz...";
            Title = "Geçersiz İşlem";
            IsRedirecting = true;
            RedirectingUrl = "/Home/Index";
            RedirectingTimeOut = 10000; //10 sn sonra
            Items = new List<T>();
        }
    }
}