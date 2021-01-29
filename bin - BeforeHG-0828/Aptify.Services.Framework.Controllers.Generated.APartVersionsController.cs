using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class APartVersionsController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10813084;
        
        /// <summary>
        /// Returns the part versions that have been updated after a particular time.  The time wanted is defined by the query parameter UpdatedAfter in the format YYYYMMDDHHMMSS.
        /// </summary>
        /// <param name="UpdatedAfter">Query parameter in YYYMMDDHHMMSS format</param>
        /// <returns></returns>
        [HttpGet]
        [AptifyOutputCache(ControllerName="PartVersions", RouteName="Default")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_PartVersions_Default(  ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            
            return ControllerUtility.InvokeController("PartVersions", "Default", Request, inputParameters);
        }
        
    }
}
