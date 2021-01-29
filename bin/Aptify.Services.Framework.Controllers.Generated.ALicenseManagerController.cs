using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class ALicenseManagerController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 1;
        
        /// <summary>
        /// This method retrieves the available license types and how many of each is available.
        /// </summary>
        /// <returns>Response object</returns>
        [HttpGet]
        [AptifyOutputCache(ControllerName="LicenseManager", RouteName="Available")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_LicenseManager_Available( long UserID, string LicenseType = "" ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("UserID", UserID);
            inputParameters.Add("LicenseType", LicenseType);
            
            return ControllerUtility.InvokeController("LicenseManager", "Available", Request, inputParameters);
        }
        
        [HttpGet]
        [AptifyOutputCache(ControllerName="LicenseManager", RouteName="EveryAvailable")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_LicenseManager_EveryAvailable( long UserID, string LicenseType = "" ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("UserID", UserID);
            inputParameters.Add("LicenseType", LicenseType);
            
            return ControllerUtility.InvokeController("LicenseManager", "EveryAvailable", Request, inputParameters);
        }
        
    }
}
