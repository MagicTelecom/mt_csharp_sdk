/*
 * MagicTelecomAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 on 06/24/2016
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicTelecomAPI.PCL;
using MagicTelecomAPI.PCL.Http.Request;
using MagicTelecomAPI.PCL.Http.Response;
using MagicTelecomAPI.PCL.Http.Client;
using MagicTelecomAPI.PCL.Models;

namespace MagicTelecomAPI.PCL.Controllers
{
    public partial class DidsProductsController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static DidsProductsController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static DidsProductsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new DidsProductsController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Allow clients to get the list of available phone_numbers
        /// </summary>
        /// <param name="page">Optional parameter: Zero based offset index for the results. e.g. 0 would start at the first result and 10 would start at the eleventh result</param>
        /// <param name="limit">Optional parameter: Maximum number of results to return in the response</param>
        /// <param name="filter">Optional parameter: Allowed fields: country_iso2, region_handle, location_handle, location_name, phone_number, phone_number_type, zip_code</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetDidsAsync(
                int? page = null,
                int? limit = null,
                string filter = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/dids/products/dids");


            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "page", (null != page) ? page : 1 },
                { "limit", (null != limit) ? limit : 10 },
                { "filter", filter }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("X-Auth-Token", Configuration.XAuthToken);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 401)
                throw new APIException(@"You are not authenticated", _context);

            else if (_response.StatusCode == 403)
                throw new APIException(@"This action needs a valid WSSE header", _context);

            else if (_response.StatusCode == 404)
                throw new APIException(@"Resource not found", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Allow clients to get a specific phone_number
        /// </summary>
        /// <param name="phoneNumber">Required parameter: Phone Number</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetDidsByPhoneNumberAsync(
                string phoneNumber)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/dids/products/dids/{phone_number}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "phone_number", phoneNumber }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("X-Auth-Token", Configuration.XAuthToken);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 401)
                throw new APIException(@"You are not authenticated", _context);

            else if (_response.StatusCode == 403)
                throw new APIException(@"This action needs a valid WSSE header", _context);

            else if (_response.StatusCode == 404)
                throw new APIException(@"Resource not found", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Allow clients to get the list of available locations.
        /// </summary>
        /// <param name="page">Optional parameter: Zero based offset index for the results. e.g. 0 would start at the first result and 10 would start at the eleventh result</param>
        /// <param name="limit">Optional parameter: Maximum number of results to return in the response</param>
        /// <param name="filter">Optional parameter: Allowed fields: country_iso2, region_handle, location_handle, location_name, prefix, phone_number_type, zip_code, npa, nxx, fax</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetLocationsAsync(
                int? page = null,
                int? limit = null,
                string filter = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/dids/products/locations");


            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "page", (null != page) ? page : 1 },
                { "limit", (null != limit) ? limit : 10 },
                { "filter", filter }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("X-Auth-Token", Configuration.XAuthToken);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 401)
                throw new APIException(@"You are not authenticated", _context);

            else if (_response.StatusCode == 403)
                throw new APIException(@"This action needs a valid WSSE header", _context);

            else if (_response.StatusCode == 404)
                throw new APIException(@"Resource not found", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Allow clients to get a specific location.
        /// </summary>
        /// <param name="locationHandle">Required parameter: Location Handle</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetLocationByHandleAsync(
                string locationHandle)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/dids/products/locations/{location_handle}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "location_handle", locationHandle }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("X-Auth-Token", Configuration.XAuthToken);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 401)
                throw new APIException(@"You are not authenticated", _context);

            else if (_response.StatusCode == 403)
                throw new APIException(@"This action needs a valid WSSE header", _context);

            else if (_response.StatusCode == 404)
                throw new APIException(@"Resource not found", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Allow clients to get the list of available trunks
        /// </summary>
        /// <param name="page">Optional parameter: Zero based offset index for the results. e.g. 0 would start at the first result and 10 would start at the eleventh result</param>
        /// <param name="limit">Optional parameter: Maximum number of results to return in the response</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetTrunksAsync(
                int? page = null,
                int? limit = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/dids/products/trunks");


            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "page", (null != page) ? page : 1 },
                { "limit", (null != limit) ? limit : 10 }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("X-Auth-Token", Configuration.XAuthToken);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 401)
                throw new APIException(@"You are not authenticated", _context);

            else if (_response.StatusCode == 403)
                throw new APIException(@"This action needs a valid WSSE header", _context);

            else if (_response.StatusCode == 404)
                throw new APIException(@"Resource not found", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Allow clients to get a specific trunk
        /// </summary>
        /// <param name="trunkHandle">Required parameter: Trunk Handle</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetTrunkByHandleAsync(
                string trunkHandle)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/dids/products/trunks/{trunk_handle}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "trunk_handle", trunkHandle }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("X-Auth-Token", Configuration.XAuthToken);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 401)
                throw new APIException(@"You are not authenticated", _context);

            else if (_response.StatusCode == 403)
                throw new APIException(@"This action needs a valid WSSE header", _context);

            else if (_response.StatusCode == 404)
                throw new APIException(@"Resource not found", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Allow clients to get trunk zones.
        /// </summary>
        /// <param name="page">Required parameter: Zero based offset index for the results. e.g. 0 would start at the first result and 10 would start at the eleventh result.</param>
        /// <param name="limit">Required parameter: Maximum number of results to return in the response.</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetCountriesByTrunkAsync(
                int page,
                int limit)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/dids/products/trunks/countries");


            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "page", page },
                { "limit", limit }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("X-Auth-Token", Configuration.XAuthToken);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 401)
                throw new APIException(@"You are not authenticated", _context);

            else if (_response.StatusCode == 403)
                throw new APIException(@"This action needs a valid WSSE header", _context);

            else if (_response.StatusCode == 404)
                throw new APIException(@"Resource not found", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

    }
} 