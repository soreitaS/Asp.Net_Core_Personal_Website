using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Permissions;

namespace Core_ilk_Proje.ViewComponents.Contact
{
    public class SendMessageList : ViewComponent
    {
        MessageManager _messageManager = new MessageManager(new EfMessageDal());
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(Message p)
        //{
        //    p.Date=Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.Status=true;
        //    _messageManager.TAdd(p);    
        //    return View();
        //}
    }
}
