using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class ALogoutController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10813075;
        
        [HttpGet]
        [HttpPost]
        [AptifyOutputCache(ControllerName="Logout", RouteName="Default")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_Logout_Default(  ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            
            return ControllerUtility.InvokeController("Logout", "Default", Request, inputParameters);
        }
        
    }
}
