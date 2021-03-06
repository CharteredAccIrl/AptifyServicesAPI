using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class ABatchCreateUpdateDeleteController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10813089;
        
        /// <summary>
        /// This endpoint is for batching multiple create update and delete entity requests into a single transaction.  The resource in this scenario is the batch request itself, since we need
        /// to safeguard against batches being replayed inadvertently.  Each batch is identified by a GUID, which is the resource identifier.  Batches can only be created, never deleted.  If a
        /// batch is resubmitted this service will respond with a 409 response code indicating a conflict.
        /// </summary>
        /// <param name="BatchGuid">The batch GUID to create.</param>
        /// <returns>
        /// Typically this service will always return a 200 response code, unless the batch is being replayed.  A 200 response code indicates that the batch was successfully created.  It does not
        /// mean that the batch was successfully applied.  Callers must look at the JSON response to determine which portions of the batch were successful.
        /// </returns>
        [HttpPost]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_BatchCreateUpdateDelete_Default( string BatchGuid ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("BatchGuid", BatchGuid);
            
            return ControllerUtility.InvokeController("BatchCreateUpdateDelete", "Default", Request, inputParameters);
        }
        
    }
}
