namespace ClubDeportivo
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnIngresar = new Button();
            checkBox = new CheckBox();
            pictureBoxLogin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Cursor = Cursors.IBeam;
            resources.ApplyResources(txtUser, "txtUser");
            txtUser.Name = "txtUser";
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Cursor = Cursors.IBeam;
            resources.ApplyResources(txtPass, "txtPass");
            txtPass.Name = "txtPass";
            txtPass.Enter += txtPass_Enter;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(54, 116, 181);
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.BorderColor = Color.FromArgb(54, 116, 181);
            resources.ApplyResources(btnIngresar, "btnIngresar");
            btnIngresar.ForeColor = SystemColors.ButtonHighlight;
            btnIngresar.Name = "btnIngresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // checkBox
            // 
            resources.ApplyResources(checkBox, "checkBox");
            checkBox.Name = "checkBox";
            checkBox.UseVisualStyleBackColor = true;
            checkBox.Click += txtPass_Enter;
            // 
            // pictureBoxLogin
            // 
            resources.ApplyResources(pictureBoxLogin, "pictureBoxLogin");
            pictureBoxLogin.Name = "pictureBoxLogin";
            pictureBoxLogin.TabStop = false;
            // 
            // fLogin
            // 
            AcceptButton = btnIngresar;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 241, 253);
            Controls.Add(pictureBoxLogin);
            Controls.Add(checkBox);
            Controls.Add(btnIngresar);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Name = "fLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnIngresar;
        private CheckBox checkBox;
        private PictureBox pictureBoxLogin;
    }
}
