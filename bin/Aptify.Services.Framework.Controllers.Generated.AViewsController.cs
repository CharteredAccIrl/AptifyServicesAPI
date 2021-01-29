using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class AViewsController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10813088;
        
        /// <summary>
        /// Gets the data from a View.
        /// </summary>
        /// <param name="lViewId">The ID of the View.</param>
        /// <returns></returns>
        [HttpGet]
        [AptifyOutputCache(ControllerName="Views", RouteName="Default")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_Views_Default( long ViewId = 0 ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("ViewId", ViewId);
            
            return ControllerUtility.InvokeController("Views", "Default", Request, inputParameters);
        }
        
    }
}
