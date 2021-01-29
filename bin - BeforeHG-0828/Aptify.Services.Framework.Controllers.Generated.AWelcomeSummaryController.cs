using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class AWelcomeSummaryController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 1;
        
        [HttpGet]
        [AptifyOutputCache(ControllerName="WelcomeSummary", RouteName="WelcomeSummary")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_WelcomeSummary_WelcomeSummary( long WelcomeSummaryID, long SummaryItemIndex = 0 ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("WelcomeSummaryID", WelcomeSummaryID);
            inputParameters.Add("SummaryItemIndex", SummaryItemIndex);
            
            return ControllerUtility.InvokeController("WelcomeSummary", "WelcomeSummary", Request, inputParameters);
        }
        
    }
}
