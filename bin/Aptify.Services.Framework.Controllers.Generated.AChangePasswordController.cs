using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class AChangePasswordController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10831885;
        
        [HttpGet]
        [AptifyOutputCache(ControllerName="ChangePassword", RouteName="Default")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_ChangePassword_Default( string Current_Password, string New_Password, string Confirm_Password ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("Current_Password", Current_Password);
            inputParameters.Add("New_Password", New_Password);
            inputParameters.Add("Confirm_Password", Confirm_Password);
            
            return ControllerUtility.InvokeController("ChangePassword", "Default", Request, inputParameters);
        }
        
        [HttpPost]
        [HttpGet]
        [AptifyOutputCache(ControllerName="ChangePassword", RouteName="ValidateUser")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_ChangePassword_ValidateUser(  ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            
            return ControllerUtility.InvokeController("ChangePassword", "ValidateUser", Request, inputParameters);
        }
        
        [HttpPost]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_ChangePassword_ChangePassword(  ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            
            return ControllerUtility.InvokeController("ChangePassword", "ChangePassword", Request, inputParameters);
        }
        
    }
}
