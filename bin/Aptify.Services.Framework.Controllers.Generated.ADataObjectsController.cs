using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class ADataObjectsController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10813081;
        
        /// <summary>
        /// This method is used to retrieves the service data object request.These objects must be defined in the SDO entity in Aptify.Use query strings to pass the parameters required.
        /// </summary>
        /// <param name="sDataObjectName">The name of the Service Data Object.</param>
        /// <returns>This return's response object.</returns>
        [HttpGet]
        [AptifyOutputCache(ControllerName="DataObjects", RouteName="DefaultRoute")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_DataObjects_DefaultRoute( string sDataObjectName ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("sDataObjectName", sDataObjectName);
            
            return ControllerUtility.InvokeController("DataObjects", "DefaultRoute", Request, inputParameters);
        }
        
    }
}
