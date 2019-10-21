using Core.BussisnessObjects;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ExampleApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            string conn = @"Integrated Security=SSPI;Pooling=false;Data Source=(localdb)\mssqllocaldb;Initial Catalog=ExampleApi";
            DevExpress.Xpo.Metadata.XPDictionary dict = new DevExpress.Xpo.Metadata.ReflectionDictionary();
            // Initialize the XPO dictionary.
            dict.GetDataStoreSchema(typeof(Auto).Assembly);
            DevExpress.Xpo.XpoDefault.Session = null;
            DevExpress.Xpo.DB.IDataStore store = DevExpress.Xpo.XpoDefault.GetConnectionProvider(conn,
                DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
            DevExpress.Xpo.XpoDefault.DataLayer = new DevExpress.Xpo.ThreadSafeDataLayer(dict, store);

            //Ez csak ahhoz kell, hogy legyen tesztadat
            var sess = new Session();
            if(new XPQuery<Auto>(sess).Count() == 0)
            {
                Auto au1 = new Auto(sess)
                {
                    PlateNumber = "ABC123",
                    Make = "Volkswagen",
                    Model = "Golf"
                };

                Auto au2 = new Auto(sess)
                {
                    PlateNumber = "ABC124",
                    Make = "Audi",
                    Model = "A4"
                };

                au1.Save();
                au2.Save();
            }

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
