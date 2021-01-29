using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class AUIPartsController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10813085;
        
        /// <summary>
        /// Gets the Text from a UI Parts record, encoded according to its Type.
        /// </summary>
        /// <param name="PartIdentifier">Either the ID or the Name of the UI Part.</param>
        /// <returns></returns>
        [HttpGet]
        [AptifyOutputCache(ControllerName="UIParts", RouteName="Default")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_UIParts_Default( string PartIdentifier ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("PartIdentifier", PartIdentifier);
            
            return ControllerUtility.InvokeController("UIParts", "Default", Request, inputParameters);
        }
        
    }
}
