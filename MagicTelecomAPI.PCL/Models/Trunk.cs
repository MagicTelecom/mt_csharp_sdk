/*
 * MagicTelecomAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 on 06/24/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using MagicTelecomAPI.PCL;

namespace MagicTelecomAPI.PCL.Models
{
    public class Trunk : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string sipEndPointUri;
        private string description;
        private Routing routing;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("sip_end_point_uri")]
        public string SipEndPointUri 
        { 
            get 
            {
                return this.sipEndPointUri; 
            } 
            set 
            {
                this.sipEndPointUri = value;
                onPropertyChanged("SipEndPointUri");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get 
            {
                return this.description; 
            } 
            set 
            {
                this.description = value;
                onPropertyChanged("Description");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("_routing")]
        public Routing Routing 
        { 
            get 
            {
                return this.routing; 
            } 
            set 
            {
                this.routing = value;
                onPropertyChanged("Routing");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 