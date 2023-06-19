using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    /// <summary>
    /// Represents an address.
    /// </summary>
    class Address
    {
        #region INSTANCEVAR
        private string street;
        private string city;
        private Countries country;
        private string zipCode;

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class with the specified values.
        /// </summary>
        /// <param name="street">The street name.</param>
        /// <param name="city">The city name.</param>
        /// <param name="country">The country.</param>
        /// <param name="zip">The ZIP code.</param>
        public Address(string street, string city, Countries country, string zip)
        {
            this.street = street;
            this.zipCode = zip;
            this.city = city;
            this.country = country;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class with the specified values.
        /// </summary>
        /// <param name="street">The street name.</param>
        /// <param name="zipCode">The ZIP code.</param>
        /// <param name="city">The city name.</param>
        public Address(string street, string zipCode, string city)
        {
            this.street = street;
            this.zipCode = zipCode;
            this.city = city;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class with default values.
        /// </summary>
        public Address() : this(string.Empty, string.Empty, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class with the same values as another address.
        /// </summary>
        /// <param name="theOther">The address to copy the values from.</param>
        public Address(Address theOther)
        {
            this.street = theOther.street;
            this.zipCode = theOther.zipCode;
            this.city = theOther.city;
            this.country = theOther.country;
        }

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets the street name.
        /// </summary>
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        /// <summary>
        /// Gets or sets the city name.
        /// </summary>
        public string City
        {
            get { return city; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    city = value;
            }
        }

        /// <summary>
        /// Gets or sets the ZIP code.
        /// </summary>
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        public Countries Country
        {
            get { return country; }
            set { country = value; }
        }

        #endregion

        #region METHODS

        /// <summary>
        /// Gets the string representation of the country.
        /// </summary>
        /// <returns>The string representation of the country.</returns>
        public string GetCountryString()
        {
            string strCountry = country.ToString();
            strCountry = strCountry.Replace("_", " ");
            return strCountry;
        }

        /// <summary>
        /// Gets the formatted address label.
        /// </summary>
        /// <returns>The formatted address label.</returns>
        public string GetAddressLabel()
        {
            string strout = street + Environment.NewLine;
            strout += zipCode + " " + city;
            return strout;
        }

        /// <summary>
        /// Validates the address.
        /// </summary>
        /// <returns><c>true</c> if the address is valid; otherwise, <c>false</c>.</returns>
        public bool Validate()
        {
            bool cityOK = !string.IsNullOrEmpty(city);
            return cityOK;
        }

        /// <summary>
        /// Returns a string that represents the current address.
        /// </summary>
        /// <returns>A string that represents the current address.</returns>
        public override string ToString()
        {
            string strout = string.Format("{0, -25} {1, -8} {2, -10} {3}",
                street, zipCode, city, GetCountryString());

            return strout;
        }

        #endregion
    }
}
