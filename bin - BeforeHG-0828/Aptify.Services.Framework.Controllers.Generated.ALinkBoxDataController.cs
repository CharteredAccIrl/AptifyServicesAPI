using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class ALinkBoxDataController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10813090;
        
        /// <summary>
        /// This method is used to performs a search for a link box.This can either go against an entire search configuration or an explicit list of entities.
        /// </summary>
        /// <returns>It's returns response object.</returns>
        [HttpGet]
        [AptifyOutputCache(ControllerName="LinkBoxData", RouteName="PerformSearch")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_LinkBoxData_PerformSearch(  ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            
            return ControllerUtility.InvokeController("LinkBoxData", "PerformSearch", Request, inputParameters);
        }
        
        /// <summary>
        /// This method is used to performs a advance search data.
        /// </summary>
        /// <returns>It's returns response object.</returns>
        [HttpGet]
        [AptifyOutputCache(ControllerName="LinkBoxData", RouteName="AdvancedSearch")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_LinkBoxData_AdvancedSearch(  ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            
            return ControllerUtility.InvokeController("LinkBoxData", "AdvancedSearch", Request, inputParameters);
        }
        
        /// <summary>
        /// This method is used to retrieves the search configuration data as JSON.
        /// </summary>
        /// <param name="ConfigurationName">The name of the configuration requested.</param>
        /// <returns>It's returns response object.</returns>
        [HttpGet]
        [AptifyOutputCache(ControllerName="LinkBoxData", RouteName="GetSearchConfiguration")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_LinkBoxData_GetSearchConfiguration( string ConfigurationName ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("ConfigurationName", ConfigurationName);
            
            return ControllerUtility.InvokeController("LinkBoxData", "GetSearchConfiguration", Request, inputParameters);
        }
        
    }
}
