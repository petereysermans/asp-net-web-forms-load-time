using System;
using System.Globalization;
using System.Threading;
using System.Web.UI;

namespace AspNetWebFormsLoadTime
{
    public partial class Simple : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var start = DateTime.Now;
            Thread.Sleep(5000);
            var loadTime = DateTime.Now - start;
            loadTimeLiteral.Text = (loadTime.TotalMilliseconds/1000).ToString(CultureInfo.InvariantCulture);
        }
    }
}