using System;
using System.Diagnostics;
using System.Threading;

namespace Microsoft.Extensions.DependencyInjection.WebForms.Sample
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected IDependency2 Dependency { get; }

        public event EventHandler TestEventHandler;

        public WebUserControl1(IDependency2 dependency)
        {
            Dependency = dependency;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TestEventHandler?.Invoke(new object(), EventArgs.Empty);
        }
    }

    public interface IDependency2
    {
        int Id { get; }
    }

    [DebuggerDisplay("Dependency #{" + nameof(Id) + "}")]
    public class Dependency2 : IDependency2
    {
        private static int _id;

        public int Id { get; }

        public Dependency2()
        {
            Id = Interlocked.Increment(ref _id);
        }
    }
}