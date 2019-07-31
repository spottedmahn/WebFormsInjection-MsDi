using System;
using System.Web.UI;

namespace Microsoft.Extensions.DependencyInjection.WebForms.Sample
{
    public partial class Index : Page
    {
        protected IDependency Dependency { get; }

        public Index(IDependency dependency)
        {
            Dependency = dependency;
        }

        public void MyTestEventHandler(object sender, EventArgs e)
        {

        }

        public void MyTestEventHandler2(object sender, EventArgs e)
        {

        }
    }
}