using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    /// <summary>
    /// Manages the event and its participants.
    /// </summary>
    class EventManager
    {
        private double costPerPerson;
        private double feePerPerson;
        private string title;
        private ParticipantManager participant;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventManager"/> class.
        /// </summary>
        public EventManager()
        {
            participant = new ParticipantManager();
        }

        /// <summary>
        /// Gets the participant manager.
        /// </summary>
        public ParticipantManager Participants
        {
            get { return participant; }
        }

        /// <summary>
        /// Gets or sets the title of the event.
        /// </summary>
        public string Title
        {
            get { return title; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    title = value;
            }
        }

        /// <summary>
        /// Gets or sets the cost per person for the event.
        /// </summary>
        public double CostPerPerson
        {
            get { return costPerPerson; }
            set
            {
                if (value >= 0.0)
                    costPerPerson = value;
            }
        }

        /// <summary>
        /// Gets or sets the fee per person for the event.
        /// </summary>
        public double FeePerPerson
        {
            get { return feePerPerson; }
            set
            {
                if (value >= 0.0)
                    feePerPerson = value;
            }
        }

        /// <summary>
        /// Calculates the total cost of the event.
        /// </summary>
        /// <returns>The total cost of the event.</returns>
        public double CalcTotalCost()
        {
            return Participants.Count * costPerPerson;
        }

        /// <summary>
        /// Calculates the total fees collected from the participants.
        /// </summary>
        /// <returns>The total fees collected from the participants.</returns>
        public double CalcTotalFees()
        {
            return Participants.Count * feePerPerson;
        }
    }
}
