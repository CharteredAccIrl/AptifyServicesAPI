using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class AAttachmentsController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10813079;
        
        /// <summary>
        /// This service is used to retrieves the contents of an Attachment record.
        /// </summary>
        /// <param name="attachmentId">The ID of the Attachment to get.</param>
        /// <returns>This service will return a successful HTTP status code.The returned json structure will have the results.</returns>
        ///
        [HttpGet]
        [AptifyOutputCache(ControllerName="Attachments", RouteName="Get")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_Attachments_Get( string attachmentId ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("attachmentId", attachmentId);
            
            return ControllerUtility.InvokeController("Attachments", "Get", Request, inputParameters);
        }
        
        /// <summary>
        /// Allows attachments uploaded through the AttachmentsUpload end point to be associated with an entity record.  Post data should be form data (key value pairs).  Accepted keys are EntityName, RecordId and GuidList.  GuidList is a comma delimited list of guids returned by the AttachmentUpload service.  All attachments will be associated with the single record described by EntityName and RecordId.
        /// </summary>
        /// <returns>A JSON structure that describes which guids were successfully associated with the record.</returns>
        [HttpPost]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_Attachments_CreateViaPost(  ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            
            return ControllerUtility.InvokeController("Attachments", "CreateViaPost", Request, inputParameters);
        }
        
    }
}
