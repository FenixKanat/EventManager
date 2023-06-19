using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    /// <summary>
    /// Manages the collection of participants for an event.
    /// </summary>
    class ParticipantManager
    {
        private List<Participant> participants;

        /// <summary>
        /// Initializes a new instance of the <see cref="ParticipantManager"/> class.
        /// </summary>
        public ParticipantManager()
        {
            participants = new List<Participant>();
        }

        /// <summary>
        /// Gets the participant at the specified index.
        /// </summary>
        /// <param name="index">The index of the participant to retrieve.</param>
        /// <returns>The participant at the specified index, or null if the index is out of range.</returns>
        public Participant GetParticipantAt(int index)
        {
            if (CheckIndex(index))
                return participants[index];

            return null;
        }

        /// <summary>
        /// Gets the number of participants in the manager.
        /// </summary>
        public int Count
        {
            get { return participants.Count; }
        }

        /// <summary>
        /// Adds a participant with the specified first name, last name, and address to the manager.
        /// </summary>
        /// <param name="firstName">The first name of the participant.</param>
        /// <param name="lastName">The last name of the participant.</param>
        /// <param name="addressIn">The address of the participant.</param>
        /// <returns>True if the participant was successfully added, false otherwise.</returns>
        public bool AddParticipant(string firstName, string lastName, Address addressIn)
        {
            Participant participant = new Participant(firstName, lastName, addressIn);
            participants.Add(participant);
            return true;
        }

        /// <summary>
        /// Adds a participant to the manager.
        /// </summary>
        /// <param name="participantIn">The participant to add.</param>
        /// <returns>True if the participant was successfully added, false if the participant is null.</returns>
        public bool AddParticipant(Participant participantIn)
        {
            if (participantIn == null)
                return false;

            participants.Add(participantIn);
            return true;
        }

        /// <summary>
        /// Changes the participant at the specified index with the provided participant.
        /// </summary>
        /// <param name="participantIn">The participant to replace the existing participant with.</param>
        /// <param name="index">The index of the participant to change.</param>
        /// <returns>True if the participant was successfully changed, false otherwise.</returns>
        public bool ChangeParticipantAt(Participant participantIn, int index)
        {
            bool ok = true;

            if ((participantIn != null) && (CheckIndex(index)))
                participants[index] = participantIn;
            else
                ok = false;

            return ok;
        }

        /// <summary>
        /// Checks if the specified index is valid within the participants collection.
        /// </summary>
        /// <param name="index">The index to check.</param>
        /// <returns>True if the index is valid, false otherwise.</returns>
        public bool CheckIndex(int index)
        {
            return (index >= 0) && (index < participants.Count);
        }

        /// <summary>
        /// Deletes the participant at the specified index from the manager.
        /// </summary>
        /// <param name="index">The index of the participant to delete.</param>
        /// <returns>True if the participant was successfully deleted, false otherwise.</returns>
        public bool DeleteParticipantAt(int index)
        {
            if (CheckIndex(index))
                participants.RemoveAt(index);
            else
                return false;

            return true;
        }

        /// <summary>
        /// Gets an array of strings representing the information of all participants in the manager.
        /// </summary>
        /// <returns>An array of strings representing the information of all participants.</returns>
        public string[] GetParticipantsInfo()
        {
            string[] strInfo = new string[participants.Count];

            int i = 0;

            foreach (Participant participantObj in participants)
            {
                strInfo[i] = participantObj.ToString();
                i++;
            }

            return strInfo;
        }

        /// <summary>
        /// Used for testing purposes to add sample participants.
        /// </summary>
        public void TestValues()
        {
            // AddParticipant(new Participant("Apu", "Simpson", new Address("Simpson No")))
        }
    }
}
