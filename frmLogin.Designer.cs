namespace sartorialsys_front
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panel1 = new FlowLayoutPanel();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnAcceder = new Button();
            Login = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(210, 189, 165);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 360);
            panel1.TabIndex = 10;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(15, 15, 15);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Century Gothic", 11.25F);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(364, 128);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(402, 30);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "Usuario";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(15, 15, 15);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Century Gothic", 11.25F);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(364, 191);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(402, 30);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "Contraseña";
            // 
            // btnAcceder
            // 
            btnAcceder.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAcceder.BackColor = Color.FromArgb(40, 40, 40);
            btnAcceder.BackgroundImageLayout = ImageLayout.Center;
            btnAcceder.FlatAppearance.BorderSize = 0;
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Century Gothic", 11.25F);
            btnAcceder.ForeColor = Color.DimGray;
            btnAcceder.Location = new Point(460, 253);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(211, 40);
            btnAcceder.TabIndex = 3;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Century Gothic", 21.75F);
            Login.ForeColor = Color.DimGray;
            Login.Location = new Point(507, 50);
            Login.Name = "Login";
            Login.Size = new Size(116, 44);
            Login.TabIndex = 4;
            Login.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 357);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(800, 360);
            Controls.Add(Login);
            Controls.Add(btnAcceder);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SartorialSys";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel panel1;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnAcceder;
        private Label Login;
        private PictureBox pictureBox1;
    }
}