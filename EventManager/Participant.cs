using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    /// <summary>
    /// Represents a participant in an event.
    /// </summary>
    class Participant
    {
        #region INSTANCEVAR
        private string firstName = string.Empty;
        private string lastName = " ";
        private string _fullName;

        private Address address;

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Initializes a new instance of the <see cref="Participant"/> class with default values.
        /// </summary>
        public Participant()
        {
            address = new Address();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Participant"/> class with the specified values.
        /// </summary>
        /// <param name="firstName">The first name of the participant.</param>
        /// <param name="lastName">The last name of the participant.</param>
        /// <param name="adr">The address of the participant.</param>
        public Participant(string firstName, string lastName, Address adr)
        {
            this.firstName = firstName;
            this.lastName = lastName;

            if (address != null)
            {
                address = adr;
            }
            else
            {
                address = new Address();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Participant"/> class with the same values as another participant.
        /// </summary>
        /// <param name="theOther">The participant to copy the values from.</param>
        public Participant(Participant theOther)
        {
            this.firstName = theOther.firstName;
            this.lastName = theOther.lastName;
            this.address = new Address(theOther.address);
        }

        #endregion

        /// <summary>
        /// Gets or sets the address of the participant.
        /// </summary>
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        /// <summary>
        /// Gets or sets the full name of the participant.
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        /// <summary>
        /// Gets or sets the first name of the participant.
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                _fullName = firstName + " " + lastName;
            }
        }

        /// <summary>
        /// Gets or sets the last name of the participant.
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                _fullName = firstName + " " + lastName;
            }
        }

        /// <summary>
        /// Validates the participant's data.
        /// </summary>
        /// <returns><c>true</c> if the participant's data is valid, <c>false</c> otherwise.</returns>
        public bool Validate()
        {
            bool addrOK = address.Validate();
            bool namesOK = (string.IsNullOrEmpty(firstName) && (!string.IsNullOrEmpty(lastName)));
            return addrOK && namesOK;
        }

        /// <summary>
        /// Returns a string representation of the participant.
        /// </summary>
        /// <returns>A string representation of the participant.</returns>
        public override string ToString()
        {
            string strout = string.Format("{0, -20} {1},", FullName, address.ToString());
            return strout;
        }

    }
}
