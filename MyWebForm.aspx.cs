using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestLog4Net
{
    public partial class MyWebForm : System.Web.UI.Page
    {
        // Define a static logger variable so that it references the
        // Logger instance named "MyApp".
        private static readonly ILog log = LogManager.GetLogger(typeof(MyWebForm));

        protected void Page_Load(object sender, EventArgs e)
        {
            // Set up a xml configuration that logs.
            XmlConfigurator.Configure();

            log.Info("Entering application.");

            // do somethings...

            log.Info("Exiting application.");
        }
    }
}