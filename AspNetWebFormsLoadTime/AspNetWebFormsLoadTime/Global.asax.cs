using System;
using System.Web;
using AspNetWebFormsLoadTime.Components;

namespace AspNetWebFormsLoadTime
{
    public class Global : HttpApplication
    {
        protected void Application_BeginRequest(
            object sender,
            EventArgs e)
        {
            Context.Items.Add("StartTime", DateTime.UtcNow);
        }

        protected void Application_PostReleaseRequestState(
            object sender,
            EventArgs e)
        {
            Response.Filter = new AddLoadTimeStream(Response.Filter);
        }
    }
}