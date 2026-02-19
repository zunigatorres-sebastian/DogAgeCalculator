using DogAgeCalculator.BLL;
using DogAgeCalculator.Entities;

namespace DogAgeCalculator.UI
{
    public partial class Form1 : Form
    {

        // ---------------------------------------------------------
        // DATA LOADING & INITIALIZATION
        // ---------------------------------------------------------
        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(Form1_load);
        }


        private void Form1_load(object? sender, EventArgs e)
        {
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = false;

            dgv.ColumnCount = 7;
            dgv.Columns[0].Name = "Owner's name";
            dgv.Columns[1].Name = "Dog's name";
            dgv.Columns[2].Name = "Dog breed";
            dgv.Columns[3].Name = "Dog's age";
            dgv.Columns[4].Name = "Converted age";
            dgv.Columns[5].Name = "Dog's weight";
            dgv.Columns[6].Name = "Date of consultation";

            LoadDgvData();
        }


        // ---------------------------------------------------------
        // HELPER METHODS
        // ---------------------------------------------------------
        /// <summary>
        /// Refresh the DataGridView by retrieving the updated list of records from the Business Logic Layer.
        /// </summary>
        private void LoadDgvData()
        {
            dgv.Rows.Clear();

            DogDataBLL consult = new DogDataBLL();
            List<DogData> data = consult.GetDogs();

            if (data != null)
            {
                foreach (var d in data.Where(t => t != null))
                {
                    dgv.Rows.Add(d.OwnerName, d.Name, d.Breed, d.Age, d.ConvertedAge, d.Weight, d.Date.ToString("d"));
                }
            }
        }


        /// <summary>
        /// Clear the contents of all input fields and reset the cursor to the owner's name field.
        /// </summary>
        private void ClearTextBoxes()
        {
            txt_ownerName.Clear();
            txt_dogName.Clear();
            txt_dogAge.Clear();
            txt_dogWeight.Clear();
            txt_dogBreed.Clear();
            txt_ownerName.Focus();
        }


        // ---------------------------------------------------------
        // BUTTON EVENTS
        // ---------------------------------------------------------
        private void bClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }


        private void bCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get data
                string ownerName = txt_ownerName.Text.Trim();
                string dogName = txt_dogName.Text.Trim();
                string dogAge = txt_dogAge.Text.Trim();
                string dogWeight = txt_dogWeight.Text.Trim();
                string dogBreed = txt_dogBreed.Text.Trim();
                DateTime localDate = DateTime.Now;

                //Instance of BLL
                DogDataBLL logic = new DogDataBLL();
                int convertedAge = logic.AddDog(ownerName, dogName, dogAge, dogWeight, dogBreed, localDate);
                txt_result.Text = convertedAge.ToString();

                MessageBox.Show("Dog record saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDgvData();
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Calculation error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
