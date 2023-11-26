namespace Frontend.Presentación
{
    partial class FrmLogin
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
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnIniciar = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(196, 59);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(189, 23);
            txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(196, 161);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(189, 23);
            txtPass.TabIndex = 1;
            txtPass.UseSystemPasswordChar = true;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(236, 246);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(109, 33);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar sesión";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Controls.Add(btnIniciar);
            groupBox1.Controls.Add(txtPass);
            groupBox1.Location = new Point(65, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 354);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inicio de Sesión ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 143);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 41);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 450);
            Controls.Add(groupBox1);
            Name = "FrmLogin";
            Text = "Login";
            Load += FrmLogin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnIniciar;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
    }
}