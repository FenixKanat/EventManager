using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManager
{
    /// <summary>
    /// The main form of the Event Manager application.
    /// </summary>
    public partial class MainForm : Form
    {
        EventManager eventManager;

        /// <summary>
        /// Initializes a new instance of the MainForm class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
            EventTitle11.TextChanged += EventTitle11_TextChanged;
            eventManager = new EventManager();
            BindCountryComboBox();
        }

        /// <summary>
        /// Initializes the GUI components of the main form.
        /// </summary>
        private void InitializeGUI()
        {
            this.Text += " Fenix Kanat";
            TotalCost11.Text = string.Empty;
            TotalFees11.Text = string.Empty;
            Deficit11.Text = string.Empty;
            NumberOfParticipants11.Text = string.Empty;
        }

        /// <summary>
        /// Binds the country combo box with the available country values.
        /// </summary>
        private void BindCountryComboBox()
        {
            Country11.DataSource = Enum.GetValues(typeof(Countries));
            Country11.DisplayMember = "ToString";
        }

        /// <summary>
        /// Updates the GUI elements with the latest data from the event manager.
        /// </summary>
        private void UpdateGUI()
        {
            string[] strInfo = eventManager.Participants.GetParticipantsInfo();

            if (strInfo != null)
            {
                listBox.Items.Clear();
                listBox.Items.AddRange(strInfo);
                NumberOfParticipants11.Text = listBox.Items.Count.ToString();
            }

            double totalCost = eventManager.CalcTotalCost();
            TotalCost11.Text = totalCost.ToString("0.00");

            double totalFees = eventManager.CalcTotalFees();
            TotalFees11.Text = totalFees.ToString("0.00");
            Deficit11.Text = (totalFees - totalCost).ToString("0.00");
        }

        /// <summary>
        /// Creates a new event based on the entered event details and participant information.
        /// </summary>
        private void CreateEvent()
        {
            Participant participant = new Participant();

            if (string.IsNullOrEmpty(EventTitle11.Text))
            {
                EventTitle11.Text = "Untitled Event";
            }

            eventManager.Title = EventTitle11.Text + " By Fenix Kanat";
            this.Text = eventManager.Title;

            bool costAmountsOK = ReadCostPerPerson();
            bool feeAmountsOK = ReadFeePerPerson();

            if (costAmountsOK && feeAmountsOK)
            {
                groupBox2.Enabled = true;
                MessageBox.Show("Event Created!");

                if (ReadInput(ref participant))
                {
                    UpdateGUI();
                }
            }
        }

        /// <summary>
        /// Reads and validates the cost per person value entered by the user.
        /// </summary>
        /// <returns>True if the cost value is valid, false otherwise.</returns>
        private bool ReadCostPerPerson()
        {
            double amount = 0.0;
            bool ok = true;

            if (double.TryParse(CostPerParticipant11.Text, out amount) && amount >= 0.0)
            {
                eventManager.CostPerPerson = amount;
            }
            else
            {
                MessageBox.Show("Invalid cost");
                ok = false;
            }

            return ok;
        }

        /// <summary>
        /// Reads and validates the fee per person value entered by the user.
        /// </summary>
        /// <returns>True if the fee value is valid, false otherwise.</returns>
        private bool ReadFeePerPerson()
        {
            double amount = 0.0;
            bool ok = true;

            if (double.TryParse(FeePerParticipant11.Text, out amount) && amount >= 0.0)
            {
                eventManager.FeePerPerson = amount;
            }
            else
            {
                MessageBox.Show("Invalid Fee");
                ok = false;
            }

            return ok;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;

            if (index >= 0)
            {

                Participant participant = eventManager.Participants.GetParticipantAt(index);
                FirstName11.Text = participant.FirstName;
                LastName11.Text = participant.LastName;
                Street11.Text = participant.Address.Street;
                City11.Text = participant.Address.City;
                ZipCode11.Text = participant.Address.ZipCode;

                Country11.SelectedIndex = (int)participant.Address.Country;
            }
            else
            {

                MessageBox.Show("Select an item");
            }
        }

        private int isListBoxItemSelected(ListBox listBox)
        {
            if (listBox.SelectedIndex >= 0)
            {
                return listBox.SelectedIndex;
            }
            else
            {
                MessageBox.Show("No item selected");
                return -1;
            }
        }

        /// <summary>
        /// Handles the click event of the change button to modify the selected participant's information.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            int index = isListBoxItemSelected(listBox);
            if (index < 0)
                return;

            Participant participant = eventManager.Participants.GetParticipantAt(index);

            if (ReadParticipantData(ref participant))
            {
                eventManager.Participants.ChangeParticipantAt(participant, index);
                UpdateGUI();
            }
        }

        /// <summary>
        /// Handles the click event of the delete button to remove the selected participant from the event.
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {

            int index = isListBoxItemSelected(listBox);
            if (index < 0)
                return;

            eventManager.Participants.DeleteParticipantAt(index);
            UpdateGUI();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void EventTitle11_TextChanged(object sender, EventArgs e)
        {

            string enteredText = EventTitle11.Text;
            eventManager.Title = enteredText + " By Fenix Kanat";
            this.Text = eventManager.Title;

        }

        /// <summary>
        /// Reads the input values entered by the user and adds a new participant to the event.
        /// </summary>
        /// <param name="participant">The Participant object to store the entered information.</param>
        /// <returns>True if the participant data is valid, false otherwise.</returns>
        private bool ReadInput(ref Participant participant)
        {
            bool ok = ReadParticipantData(ref participant);

            if (ok)
            {
                eventManager.Participants.AddParticipant(participant);
                UpdateGUI();
            }
            else
            {
                return false;
            }

            return ok;
        }


        /// <summary>
        /// Reads the participant data entered by the user and updates the Participant object accordingly.
        /// </summary>
        /// <param name="participant">The Participant object to update with the entered information.</param>
        /// <returns>True if the participant data is valid, false otherwise.</returns>
        private bool ReadParticipantData(ref Participant participant)
        {
            participant.FirstName = FirstName11.Text;
            participant.LastName = LastName11.Text;

            Address address = ReadAddress();

            participant.Address = address;

            bool ok = address.Validate();
            return ok;
        }

        /// <summary>
        /// Reads the address data entered by the user and creates an Address object.
        /// </summary>
        /// <returns>The created Address object.</returns>
        private Address ReadAddress()
        {
            Address address = new Address();

            address.Street = Street11.Text;
            address.City = City11.Text;
            address.ZipCode = ZipCode11.Text;

            address.Country = (Countries)Country11.SelectedIndex;

            return address;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Participant participant = new Participant();
            if (ReadParticipantData(ref participant))
            {
                eventManager.Participants.AddParticipant(participant);
                UpdateGUI();
            }
            else
            {

                String show = "Values required for Input";

                MessageBox.Show(show);
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            CreateEvent();
        }
    }
}
