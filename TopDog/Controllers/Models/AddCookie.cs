using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TopDog.Controllers
{
    public class AddCookie
    {
        public AddCookie()
        { }

        public void topDog(Controller td)
        {
            int spare = 0;
            for (int i = 0; i < td.Request.Cookies.Count; i++ )
            {
                HttpCookie c = td.Request.Cookies.Get(i);
                if (c != null)
                {
                    spare++;
                }
            }
            for (int j = 0; j < td.Response.Cookies.Count; j++)
            {
                HttpCookie c = td.Response.Cookies.Get(j);
                if (c != null)
                {
                    spare++;
                }
            }
            HttpCookie aCookie = new HttpCookie("HyperAcdtiveTrader");

            aCookie.Value = DateTime.Now.ToString();
            aCookie.Expires = DateTime.Now.AddYears(25);
            td.Response.Cookies.Add(aCookie);
        }

        public void peakProfits(Controller pp)
        {
            HttpCookie aCookie = new HttpCookie("HyperAcdtiveTrader");

            aCookie.Value = DateTime.Now.ToString();
            aCookie.Expires = DateTime.Now.AddYears(25);
            pp.Response.Cookies.Add(aCookie);

        }

        public void blog(Controller b)
        {
            HttpCookie aCookie = new HttpCookie("HyperAcdtiveTrader");

            aCookie.Value = DateTime.Now.ToString();
            aCookie.Expires = DateTime.Now.AddYears(25);
            b.Response.Cookies.Add(aCookie);

        }

    }
}