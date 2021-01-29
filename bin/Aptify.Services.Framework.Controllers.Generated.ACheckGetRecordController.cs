using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class ACheckGetRecordController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10813080;
        
        /// <summary>
        /// Returns a simple json structure with the url path and query parameters for the real location of this record.
        /// Used internally by Aptify to determine if the client cache can be used for record access.  The optional query parameter
        /// ds indicates the timestamp of the version the client already has.
        /// </summary>
        /// <param name="sEntityIdentifier">Either the entity name or entity id</param>
        /// <param name="RecordId">The record id for the entity</param>
        /// <param name="ds">optional query string parameter representing the timestamp version the client currently has.
        /// Indicates that the client wants the current record version returned</param>
        /// <returns></returns>
        [HttpGet]
        [AptifyOutputCache(ControllerName="CheckGetRecord", RouteName="DefaultRoute")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_CheckGetRecord_DefaultRoute( string sEntityIdentifier, long RecordId ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("sEntityIdentifier", sEntityIdentifier);
            inputParameters.Add("RecordId", RecordId);
            
            return ControllerUtility.InvokeController("CheckGetRecord", "DefaultRoute", Request, inputParameters);
        }
        
    }
}
