using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class AHostedPaymentProcessResponseServiceController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 1;
        
        [HttpPost]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_HostedPaymentProcessResponseService_Default(  ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            
            return ControllerUtility.InvokeController("HostedPaymentProcessResponseService", "Default", Request, inputParameters);
        }
        
    }
}
