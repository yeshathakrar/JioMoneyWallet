using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JioMoney
{
    public partial class _Default : Page
    {
        public string pay { get; set; }

        public void Page_Load(object sender, EventArgs e)
        {
            pay = "https://testpg.rpay.co.in/reliance-webpay/v1.0/jiopayments";
        }
    }
}