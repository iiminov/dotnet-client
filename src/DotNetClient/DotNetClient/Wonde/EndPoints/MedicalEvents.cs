﻿namespace Wonde.EndPoints
{
    public class MedicalEvents : BootstrapEndpoint
    {
        /// <summary>
        /// Internal Constructor so object can only be retrieved through Wonde.Endpoints.Schools object
        /// </summary>
        /// <param name="token">Api Token</param>
        /// <param name="url">Url to set</param>
        internal MedicalEvents(string token, string url) : base(token, url)
        {
            Uri = Uri + "medical-events/";
        }
    }
}