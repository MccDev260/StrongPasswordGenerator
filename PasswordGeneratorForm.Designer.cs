namespace StrongPasswordGenerator
{
    partial class PasswordGeneratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGeneratorForm));
            this.passwordOutput = new System.Windows.Forms.Label();
            this.generatePasswordButton = new System.Windows.Forms.Button();
            this.includeSymbolsCb = new System.Windows.Forms.CheckBox();
            this.passwordLengthInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthInput)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordOutput
            // 
            this.passwordOutput.AccessibleDescription = "Password Output";
            this.passwordOutput.AccessibleName = "Output";
            this.passwordOutput.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.passwordOutput.BackColor = System.Drawing.SystemColors.Menu;
            this.passwordOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.passwordOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordOutput.Location = new System.Drawing.Point(12, 118);
            this.passwordOutput.Name = "passwordOutput";
            this.passwordOutput.Size = new System.Drawing.Size(776, 63);
            this.passwordOutput.TabIndex = 0;
            this.passwordOutput.Text = "Press button to generate password!";
            this.passwordOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passwordOutput.DoubleClick += new System.EventHandler(this.PasswordOutput_DoubleClick);
            // 
            // generatePasswordButton
            // 
            this.generatePasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generatePasswordButton.Location = new System.Drawing.Point(324, 255);
            this.generatePasswordButton.Name = "generatePasswordButton";
            this.generatePasswordButton.Size = new System.Drawing.Size(120, 39);
            this.generatePasswordButton.TabIndex = 1;
            this.generatePasswordButton.Text = "Generate Password";
            this.generatePasswordButton.UseVisualStyleBackColor = true;
            this.generatePasswordButton.Click += new System.EventHandler(this.GeneratePasswordButton_Click);
            // 
            // includeSymbolsCb
            // 
            this.includeSymbolsCb.AutoSize = true;
            this.includeSymbolsCb.Checked = true;
            this.includeSymbolsCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeSymbolsCb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.includeSymbolsCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.includeSymbolsCb.Location = new System.Drawing.Point(486, 229);
            this.includeSymbolsCb.Name = "includeSymbolsCb";
            this.includeSymbolsCb.Size = new System.Drawing.Size(129, 21);
            this.includeSymbolsCb.TabIndex = 2;
            this.includeSymbolsCb.Text = "Include Symbols";
            this.includeSymbolsCb.UseVisualStyleBackColor = true;
            // 
            // passwordLengthInput
            // 
            this.passwordLengthInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordLengthInput.Location = new System.Drawing.Point(324, 229);
            this.passwordLengthInput.Name = "passwordLengthInput";
            this.passwordLengthInput.Size = new System.Drawing.Size(120, 20);
            this.passwordLengthInput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password Length:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(324, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Double click to copy!";
            // 
            // PasswordGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordLengthInput);
            this.Controls.Add(this.includeSymbolsCb);
            this.Controls.Add(this.generatePasswordButton);
            this.Controls.Add(this.passwordOutput);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PasswordGeneratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Strong Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label passwordOutput;
        private System.Windows.Forms.Button generatePasswordButton;
        private System.Windows.Forms.CheckBox includeSymbolsCb;
        private System.Windows.Forms.NumericUpDown passwordLengthInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

