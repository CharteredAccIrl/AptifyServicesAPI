using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class AEntityUIPartsController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10813094;
        
        [HttpGet]
        [AptifyOutputCache(ControllerName="EntityUIParts", RouteName="Default")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_EntityUIParts_Default( string EntityIdentifier, string Type = "" ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("EntityIdentifier", EntityIdentifier);
            inputParameters.Add("Type", Type);
            
            return ControllerUtility.InvokeController("EntityUIParts", "Default", Request, inputParameters);
        }
        
    }
}
