using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class AAuthenticationController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10813073;
        
        [HttpGet]
        [HttpPost]
        [AptifyOutputCache(ControllerName="Authentication", RouteName="Default")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_Authentication_Default( string sAuthenticationMethod = "" ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("sAuthenticationMethod", sAuthenticationMethod);
            
            return ControllerUtility.InvokeController("Authentication", "Default", Request, inputParameters);
        }
        
        [HttpPost]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_Authentication_PasswordReset( string sAuthenticationMethod ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("sAuthenticationMethod", sAuthenticationMethod);
            
            return ControllerUtility.InvokeController("Authentication", "PasswordReset", Request, inputParameters);
        }
        
        [HttpPost]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_Authentication_PasswordResetRequest( string sAuthenticationMethod ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("sAuthenticationMethod", sAuthenticationMethod);
            
            return ControllerUtility.InvokeController("Authentication", "PasswordResetRequest", Request, inputParameters);
        }
        
    }
}
