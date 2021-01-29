using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class ADashboardController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 1;
        
        [HttpPost]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_Dashboard_DashboardPart( int DashboardPartID ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("DashboardPartID", DashboardPartID);
            
            return ControllerUtility.InvokeController("Dashboard", "DashboardPart", Request, inputParameters);
        }
        
    }
}
