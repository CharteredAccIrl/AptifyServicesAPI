using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class ADashboardUIPartsController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10813098;
        
        /// <summary>
        /// Gets the text of UI Part for a Dashboard.
        /// </summary>
        /// <param name="lRecordID">The ID of the Dashboard.</param>
        /// <param name="Type">The MIME type to encode the Dashboard UI Part in; defaults to JSON.</param>
        /// <returns></returns>
        [HttpGet]
        [AptifyOutputCache(ControllerName="DashboardUIParts", RouteName="Default")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_DashboardUIParts_Default( long RecordID, string Type = "" ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("RecordID", RecordID);
            inputParameters.Add("Type", Type);
            
            return ControllerUtility.InvokeController("DashboardUIParts", "Default", Request, inputParameters);
        }
        
    }
}
