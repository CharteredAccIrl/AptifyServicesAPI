using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aptify.Services.Framework;
using Aptify.Services.Framework.OutputCache;

namespace Aptify.Services.Framework.Controllers.Generated {

    public class AImageFieldController : System.Web.Http.ApiController {
    
        public static long ParentRecordVersion = 10813082;
        
        /// <summary>
        /// Returns a particular field for an entity record id as an image.  Optionally allows the caller to resize the image with query parameters ImageHeight and ImageWidth.  Can use the query parameter NoImageObject to specify an optional image to be returned if the requested image cannot be found.
        ///
        /// </summary>
        /// <param name="EntityName">URL segment for the entity name</param>
        /// <param name="RecordID">URL segment for the record id</param>
        /// <param name="FieldName">URL segment for the field of the record id that should be obtained</param>
        /// <param name="imageHeight">Query parameter for transforming the requested image into a particular size</param>
        /// <param name="imageWidth">Query parameter for transforming the requested image into a particular size</param>
        /// <param name="noImageObject">Query parameter.  Name of an object repository image to return if the requested image is not found</param>
        /// <returns></returns>
        [HttpGet]
        [AptifyOutputCache(ControllerName="ImageField", RouteName="Default")]
        public System.Net.Http.HttpResponseMessage AptifyGeneratedEntryMethod_ImageField_Default( string EntityName, long RecordID, string FieldName ) {
        
            IDictionary<string, object> inputParameters;
            
            inputParameters = new Dictionary<string, object>();
            inputParameters.Add("EntityName", EntityName);
            inputParameters.Add("RecordID", RecordID);
            inputParameters.Add("FieldName", FieldName);
            
            return ControllerUtility.InvokeController("ImageField", "Default", Request, inputParameters);
        }
        
    }
}
