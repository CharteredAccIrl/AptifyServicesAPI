using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class AUserInformationController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10813087;
        
        /// <summary>
        /// Gets basic information about the current logged-in user.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AptifyOutputCache(ControllerName="UserInformation", RouteName="Default")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_UserInformation_Default(  ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            
            return ControllerUtility.InvokeController("UserInformation", "Default", Request, inputParameters);
        }
        
    }
}
