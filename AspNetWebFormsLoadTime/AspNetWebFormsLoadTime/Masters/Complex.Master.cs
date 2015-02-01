using System;
using System.Threading;
using System.Web.UI;

namespace AspNetWebFormsLoadTime.Masters
{
    public partial class Complex : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.Sleep(5000);
        }
    }
}