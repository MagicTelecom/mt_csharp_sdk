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
    public class Account : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string number;
        private List<string> roles;
        private string email;
        private string contactNumber;
        private string firstname;
        private string lastname;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("number")]
        public string Number 
        { 
            get 
            {
                return this.number; 
            } 
            set 
            {
                this.number = value;
                onPropertyChanged("Number");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("roles")]
        public List<string> Roles 
        { 
            get 
            {
                return this.roles; 
            } 
            set 
            {
                this.roles = value;
                onPropertyChanged("Roles");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("email")]
        public string Email 
        { 
            get 
            {
                return this.email; 
            } 
            set 
            {
                this.email = value;
                onPropertyChanged("Email");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("contact_number")]
        public string ContactNumber 
        { 
            get 
            {
                return this.contactNumber; 
            } 
            set 
            {
                this.contactNumber = value;
                onPropertyChanged("ContactNumber");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("firstname")]
        public string Firstname 
        { 
            get 
            {
                return this.firstname; 
            } 
            set 
            {
                this.firstname = value;
                onPropertyChanged("Firstname");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("lastname")]
        public string Lastname 
        { 
            get 
            {
                return this.lastname; 
            } 
            set 
            {
                this.lastname = value;
                onPropertyChanged("Lastname");
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