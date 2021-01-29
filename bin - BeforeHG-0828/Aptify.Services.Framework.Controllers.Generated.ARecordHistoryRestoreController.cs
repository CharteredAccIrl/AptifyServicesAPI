using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class ARecordHistoryRestoreController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10813099;
        
        /// <summary>
        /// Restore Record History Record Version
        /// </summary>
        [HttpPost]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_RecordHistoryRestore_Default(  ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            
            return ControllerUtility.InvokeController("RecordHistoryRestore", "Default", Request, inputParameters);
        }
        
    }
}
