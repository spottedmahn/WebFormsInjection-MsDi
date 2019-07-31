using System;

namespace Microsoft.Extensions.DependencyInjection.WebForms.Sample
{
    public partial class WebUserControl2 : System.Web.UI.UserControl
    {
        public event EventHandler TestEvent2;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TestEvent2?.Invoke(this, EventArgs.Empty);
        }
    }
}