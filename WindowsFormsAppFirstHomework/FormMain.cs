using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppFirstHomework
{
    public partial class FormMain : Form
    {
        private PhoneNumbersManager phoneNumbersManager;

        private void UpdatedataGridViewPhoneNumbers(List<PhoneNumber> phoneNumbers)
        {
            dataGridViewPhoneNumbers.Rows.Clear();

            for (int i = 0; i < phoneNumbers.Count; i++)
            {
                dataGridViewPhoneNumbers.Rows.Add(
                    i + 1,
                    phoneNumbers[i].Number,
                    phoneNumbers[i].Name,
                    phoneNumbers[i].Info,
                    phoneNumbers[i].Grade
                    );
            }
        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            phoneNumbersManager = new PhoneNumbersManager();
        }

        private void buttonPhoneNumbersFromTxtFile_Click(object sender, EventArgs e)
        {
            phoneNumbersManager.LoadPhoneNumbersFromTxtFile();
            UpdatedataGridViewPhoneNumbers(phoneNumbersManager.GetPhoneNumbers());
        }

        private void buttonAddPhoneNumber_Click(object sender, EventArgs e)
        {
            string number = textBoxNumber.Text;

            string name = textBoxName.Text;

            string info = textBoxInfo.Text;
          
            PhoneNumber.GradeList grade = (PhoneNumber.GradeList)int.Parse(textBoxGrade.Text);

            PhoneNumber pnum = new PhoneNumber(number, name, info, grade);

            phoneNumbersManager.AddPhoneNumber(pnum);
            UpdatedataGridViewPhoneNumbers(phoneNumbersManager.GetPhoneNumbers());

            textBoxNumber.Clear();
            textBoxName.Clear();
            textBoxInfo.Clear();
            textBoxGrade.Clear();
        }
    }
}
