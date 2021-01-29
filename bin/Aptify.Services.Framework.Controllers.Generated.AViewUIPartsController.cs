using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class AViewUIPartsController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10813097;
        
        /// <summary>
        /// Retrieves the part information for a particular view.  The viewID can be passed directly in if it is known,
        /// otherwise query parameters can be used to search for the proper view ID.  If searching is used the response headers will
        /// contain the canonical URL to the resource for future reference.  If more than one view is found the views have not
        /// been created according to best practices, and the system will simply return first view it finds (this is rare).
        /// </summary>
        /// <param name="PartId">The viewID being requested.</param>
        /// <returns></returns>
        [HttpGet]
        [AptifyOutputCache(ControllerName="ViewUIParts", RouteName="Default")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_ViewUIParts_Default( long PartId = 0 ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("PartId", PartId);
            
            return ControllerUtility.InvokeController("ViewUIParts", "Default", Request, inputParameters);
        }
        
    }
}
