using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class ASpaceThreadsController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10813093;
        
        /// <summary>
        /// Retrieves SpaceThread information by the SpaceID.  Additional filtering can be performed with query parameters, even if the space id is unknown or if all space ids are wanted.
        /// </summary>
        /// <param name="SpaceID">The explicit Space Thread wanted.  Do not send this parameter if you want to get all information for a users feed.</param>
        /// <returns></returns>
        [HttpGet]
        [AptifyOutputCache(ControllerName="SpaceThreads", RouteName="Default")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_SpaceThreads_Default( long SpaceID = 0 ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("SpaceID", SpaceID);
            
            return ControllerUtility.InvokeController("SpaceThreads", "Default", Request, inputParameters);
        }
        
    }
}
