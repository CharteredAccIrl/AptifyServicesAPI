using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class AFormTemplateStaticDataController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10813095;
        
        [HttpGet]
        [AptifyOutputCache(ControllerName="FormTemplateStaticData", RouteName="Default")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_FormTemplateStaticData_Default(  ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            
            return ControllerUtility.InvokeController("FormTemplateStaticData", "Default", Request, inputParameters);
        }
        
    }
}
