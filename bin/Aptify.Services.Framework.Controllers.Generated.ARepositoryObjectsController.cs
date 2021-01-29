using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class ARepositoryObjectsController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10813092;
        
        /// <summary>
        /// Retrieves the object from the object repository.  Optional query parameters are:
        ///     ImageWidth
        ///     ImageHeight
        ///     RetainFormat
        /// </summary>
        /// <param name="ObjectIdentifier">The object ID or the object name (in the format package.name)</param>
        /// <returns></returns>
        [HttpGet]
        [AptifyOutputCache(ControllerName="RepositoryObjects", RouteName="RepositoryObjectById")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_RepositoryObjects_RepositoryObjectById( string ObjectIdentifier ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("ObjectIdentifier", ObjectIdentifier);
            
            return ControllerUtility.InvokeController("RepositoryObjects", "RepositoryObjectById", Request, inputParameters);
        }
        
        /// <summary>
        /// Retrieves the object from the object repository.  Optional query parameters are:
        ///     ImageWidth
        ///     ImageHeight
        ///     RetainFormat
        /// </summary>
        /// <param name="PackageName">The Name of an Object Repository Package.</param>
        /// <param name="ObjectName">The Name of an Object Repository Object inside sPackageName.</param>
        /// <returns></returns>
        [HttpGet]
        [AptifyOutputCache(ControllerName="RepositoryObjects", RouteName="RepositoryObjectByName")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_RepositoryObjects_RepositoryObjectByName( string PackageName, string ObjectName ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("PackageName", PackageName);
            inputParameters.Add("ObjectName", ObjectName);
            
            return ControllerUtility.InvokeController("RepositoryObjects", "RepositoryObjectByName", Request, inputParameters);
        }
        
    }
}
