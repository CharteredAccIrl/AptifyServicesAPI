using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class ACheckConnectionController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10813076;
        
        /// <summary>
        /// Tests if the connection to the service layer is still active.
        /// </summary>
        /// <returns>The current server time in UTC in text/plain format</returns>
        [HttpGet]
        [AptifyOutputCache(ControllerName="CheckConnection", RouteName="Default")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_CheckConnection_Default(  ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            
            return ControllerUtility.InvokeController("CheckConnection", "Default", Request, inputParameters);
        }
        
    }
}
