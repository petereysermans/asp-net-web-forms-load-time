﻿using System;
using System.Threading;
using System.Web.UI;

namespace AspNetWebFormsLoadTime.UserControls
{
    public partial class LoadTimeUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.Sleep(5000);
        }
    }
}