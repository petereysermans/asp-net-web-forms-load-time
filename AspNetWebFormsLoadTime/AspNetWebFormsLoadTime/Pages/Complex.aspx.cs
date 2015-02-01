using System;
using System.Threading;
using System.Web.UI;

namespace AspNetWebFormsLoadTime.Pages
{
    public partial class Complex : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.Sleep(5000);
        }
    }
}