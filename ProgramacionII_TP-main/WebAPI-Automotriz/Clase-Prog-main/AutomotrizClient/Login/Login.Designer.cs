namespace AutomotrizClient
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lbUsario = new Label();
            lbContra = new Label();
            btnOk = new Button();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lbUsario
            // 
            lbUsario.AutoSize = true;
            lbUsario.BackColor = Color.Transparent;
            lbUsario.BorderStyle = BorderStyle.Fixed3D;
            lbUsario.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbUsario.ForeColor = SystemColors.ControlText;
            lbUsario.Location = new Point(107, 108);
            lbUsario.Name = "lbUsario";
            lbUsario.Size = new Size(83, 26);
            lbUsario.TabIndex = 0;
            lbUsario.Text = "Usuario";
            // 
            // lbContra
            // 
            lbContra.AutoSize = true;
            lbContra.BackColor = Color.Transparent;
            lbContra.BorderStyle = BorderStyle.Fixed3D;
            lbContra.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbContra.Location = new Point(107, 237);
            lbContra.Name = "lbContra";
            lbContra.Size = new Size(118, 26);
            lbContra.TabIndex = 0;
            lbContra.Text = "Contraseña";
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.RoyalBlue;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Popup;
            btnOk.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(107, 343);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(89, 29);
            btnOk.TabIndex = 5;
            btnOk.Text = "Confirmar";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(107, 150);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(175, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(107, 277);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '·';
            txtContraseña.Size = new Size(175, 23);
            txtContraseña.TabIndex = 2;
            txtContraseña.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(202, 343);
            button1.Name = "button1";
            button1.Size = new Size(89, 29);
            button1.TabIndex = 6;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(107, 50);
            label1.Name = "label1";
            label1.Size = new Size(222, 24);
            label1.TabIndex = 0;
            label1.Text = "Ingrese Credenciales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(107, 186);
            label2.Name = "label2";
            label2.Size = new Size(188, 16);
            label2.TabIndex = 3;
            label2.Text = "¿Has olvidado la usuario?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(107, 303);
            label3.Name = "label3";
            label3.Size = new Size(175, 16);
            label3.TabIndex = 4;
            label3.Text = "¿Has olvidado la clave?";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(435, 493);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(btnOk);
            Controls.Add(lbContra);
            Controls.Add(lbUsario);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsario;
        private Label lbContra;
        private Button btnOk;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}