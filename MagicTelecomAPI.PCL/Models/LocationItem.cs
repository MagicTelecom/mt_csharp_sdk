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
    public class LocationItem : Item 
    {
        // These fields hold the values for the public properties.
        private string locationHandle;
        private int quantity;
        private string attributes;
        private string didTypeHandle;
        private int trunkId;
        private CallerLocation callerLocation;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("location_handle")]
        public string LocationHandle 
        { 
            get 
            {
                return this.locationHandle; 
            } 
            set 
            {
                this.locationHandle = value;
                onPropertyChanged("LocationHandle");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity 
        { 
            get 
            {
                return this.quantity; 
            } 
            set 
            {
                this.quantity = value;
                onPropertyChanged("Quantity");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("attributes")]
        public string Attributes 
        { 
            get 
            {
                return this.attributes; 
            } 
            set 
            {
                this.attributes = value;
                onPropertyChanged("Attributes");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("did_type_handle")]
        public string DidTypeHandle 
        { 
            get 
            {
                return this.didTypeHandle; 
            } 
            set 
            {
                this.didTypeHandle = value;
                onPropertyChanged("DidTypeHandle");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("trunk_id")]
        public int TrunkId 
        { 
            get 
            {
                return this.trunkId; 
            } 
            set 
            {
                this.trunkId = value;
                onPropertyChanged("TrunkId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("_caller_location")]
        public CallerLocation CallerLocation 
        { 
            get 
            {
                return this.callerLocation; 
            } 
            set 
            {
                this.callerLocation = value;
                onPropertyChanged("CallerLocation");
            }
        }
    }
} 