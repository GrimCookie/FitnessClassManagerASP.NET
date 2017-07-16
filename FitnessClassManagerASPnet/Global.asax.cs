using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace FitnessClassManagerASPnet
{
    public class Global : System.Web.HttpApplication
    {
        FitnessClassManagerASPnet.FitnessClassList fitnessClassList = new FitnessClassManagerASPnet.FitnessClassList();

        protected void Application_Start(object sender, EventArgs e)
        {
            //FitnessClassManagerASPnet.FitnessClassList fitnessClassList = new FitnessClassManagerASPnet.FitnessClassList();
            HttpContext.Current.Application["FitnessClassList"] = fitnessClassList;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //FitnessClassManagerASPnet.FitnessClassList fitnessClassList = new FitnessClassManagerASPnet.FitnessClassList();
            HttpContext.Current.Session["FitnessClassList"] = fitnessClassList;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}