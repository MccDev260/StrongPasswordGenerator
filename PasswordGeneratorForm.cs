using System;
using System.Windows.Forms;

namespace StrongPasswordGenerator
{
    public partial class PasswordGeneratorForm : Form
    {
        private PasswordGenerator passwordGenerator;

        public PasswordGeneratorForm()
        {
            InitializeComponent();
            passwordGenerator = new PasswordGenerator(includeSymbolsCb, passwordLengthInput);
        }

        private void GeneratePasswordButton_Click(object sender, EventArgs e)
        {
            passwordOutput.Text = passwordGenerator.GeneratePassword();
        }

        private void PasswordOutput_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Password copied to clipboard!");
        }
    }
}
