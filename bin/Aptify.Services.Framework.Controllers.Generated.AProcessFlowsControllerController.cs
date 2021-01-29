using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class AProcessFlowsControllerController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10813091;
        
        /// <summary>
        /// Executes a process flow.  The process flow parameters should be passed as POST data.  This service will return an
        /// http error code if the process flow is not found, if the user does not have the authority to execute the process flow,
        /// or if required input parameters are missing.  If the process flow exits successfully with a failed result, an OK http code
        /// will be returned for the response.  The results of the process flow will be returned as json data.
        /// </summary>
        /// <param name="sProcessFlowName">The Name of a Process Flow record.</param>
        /// <returns></returns>
        [HttpPost]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_ProcessFlowsController_Default( string sProcessFlowName ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("sProcessFlowName", sProcessFlowName);
            
            return ControllerUtility.InvokeController("ProcessFlowsController", "Default", Request, inputParameters);
        }
        
    }
}
