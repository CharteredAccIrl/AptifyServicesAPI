using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class AHostedPaymentRequestServiceController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 1;
        
        [HttpPost]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_HostedPaymentRequestService_Default(  ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            
            return ControllerUtility.InvokeController("HostedPaymentRequestService", "Default", Request, inputParameters);
        }
        
    }
}
