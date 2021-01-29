using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class AFormTemplateUIPartsController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10813096;
        
        /// <summary>
        /// This method is used to gets the text of UI Part for a form template.
        /// </summary>
        /// <param name="lRecordID">The ID of the form template.</param>
        /// <param name="Type">The MIME type to encode the form template UI Part in; defaults to JSON.</param>
        /// <returns>This return's response object.</returns>
        [HttpGet]
        [AptifyOutputCache(ControllerName="FormTemplateUIParts", RouteName="Default")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_FormTemplateUIParts_Default( long RecordID, string Type = "" ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("RecordID", RecordID);
            inputParameters.Add("Type", Type);
            
            return ControllerUtility.InvokeController("FormTemplateUIParts", "Default", Request, inputParameters);
        }
        
    }
}
