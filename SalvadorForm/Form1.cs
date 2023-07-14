using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalvadorForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            bool checkCheckbox;
            bool checkDescription;

            if (!checkBoxProd.Checked && !checkBoxPrepod.Checked && !checkBoxDemo.Checked)
            {
                errorProvider1.SetError(environment, "Select a option");
                checkCheckbox = false;
            }
            else
            {
                errorProvider1.SetError(environment, "");
                checkCheckbox = true;
            }

            if (string.IsNullOrEmpty(richTextBoxDescription.Text))
            {
                errorProvider1.SetError(richTextBoxDescription, "Campo Obligatorio");
                checkDescription = false;
            }
            else
            {
                errorProvider1.SetError(richTextBoxDescription, "");
                checkDescription = true;
            }

            if (checkCheckbox && checkDescription)
            {
            MessageBox.Show(textBoxTitle.Text + 
                "\n" + comboBoxLocation.Text +
                "\n" + comboBoxType.Text +
                "\n" + comboBoxCriticity.Text +
                "\n" + checkBoxProd.Checked +
                "\n" + checkBoxPrepod.Checked +
                "\n" + checkBoxDemo.Checked +
                "\n" + richTextBoxDescription.Text +
                "\n" + dateTimeStartDate.Text +
                "\n" + textBoxDuration.Text +
                "\n" + comboBoxStatus.Text +
                "\n" + comboBoxPercent.Text,
                "Resultados");
            }

        }
    }
}
