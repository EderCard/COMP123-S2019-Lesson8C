using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson8C
{
    public partial class Lab8Form : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }
        /// <summary>
        /// This is the constructor for the Lab8form
        /// </summary>
        public Lab8Form()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the Event Handler for the SubmitButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;
            UserAge = float.Parse(AgeTextBox.Text);

            OutputLabel.Text = NameTextBox.Text + " " + AgeTextBox.Text;
            ClearForm();
        }
        /// <summary>
        /// This method clears the TextBoxes on the form and other proporties
        /// </summary>
        private void ClearForm()
        {
            NameTextBox.Text = string.Empty;
            AgeTextBox.Text = string.Empty;
            SubmitButton.Enabled = false;
        }
        /// <summary>
        /// This is the Event Handler for the Lab8Form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab8Form_Load(object sender, EventArgs e)
        {
            ClearForm();
        }
        /// <summary>
        /// This is the Event Handler for the AgeTextBox TextChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(AgeTextBox.Text);
                SubmitButton.Enabled = true;
            }
            catch 
            {
                SubmitButton.Enabled = false;
            }
        }
        /// <summary>
        /// This is the Event Handler for the NameTextBox TextChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTextBox.Text.Length >= 2) ? true : false;
        }
    }
}
