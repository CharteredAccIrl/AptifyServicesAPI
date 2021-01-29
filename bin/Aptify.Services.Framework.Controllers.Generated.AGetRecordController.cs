using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class AGetRecordController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10813077;
        
        [HttpGet]
        [AptifyOutputCache(ControllerName="GetRecord", RouteName="Default")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_GetRecord_Default( string sEntityIdentifier, long RecordId ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("sEntityIdentifier", sEntityIdentifier);
            inputParameters.Add("RecordId", RecordId);
            
            return ControllerUtility.InvokeController("GetRecord", "Default", Request, inputParameters);
        }
        
    }
}
