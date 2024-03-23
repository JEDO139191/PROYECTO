namespace ProyectoInicio
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            txtuser = new TextBox();
            txtpass = new TextBox();
            label1 = new Label();
            btnlogin = new Button();
            linkpass = new LinkLabel();
            btncerrar = new PictureBox();
            btnminimizar = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-2, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(264, 295);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.FromArgb(15, 15, 15);
            txtuser.BorderStyle = BorderStyle.None;
            txtuser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.ForeColor = Color.Silver;
            txtuser.Location = new Point(309, 90);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(399, 25);
            txtuser.TabIndex = 1;
            txtuser.Text = "Usuario";
            txtuser.Enter += txtuser_Enter;
            txtuser.Leave += txtuser_Leave;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.FromArgb(15, 15, 15);
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.ForeColor = Color.Silver;
            txtpass.Location = new Point(309, 158);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(399, 25);
            txtpass.TabIndex = 2;
            txtpass.Text = "Contraseña";
            txtpass.Enter += txtpass_Enter;
            txtpass.Leave += txtpass_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(410, 25);
            label1.Name = "label1";
            label1.Size = new Size(180, 37);
            label1.TabIndex = 3;
            label1.Text = "SAIE LOGIN";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(40, 40, 40);
            btnlogin.FlatAppearance.BorderSize = 0;
            btnlogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnlogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.ForeColor = Color.LightGray;
            btnlogin.Location = new Point(309, 211);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(399, 29);
            btnlogin.TabIndex = 3;
            btnlogin.Text = "ACCEDER";
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // linkpass
            // 
            linkpass.ActiveLinkColor = Color.FromArgb(0, 122, 204);
            linkpass.AutoSize = true;
            linkpass.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkpass.LinkColor = Color.LightGray;
            linkpass.Location = new Point(390, 256);
            linkpass.Name = "linkpass";
            linkpass.Size = new Size(222, 20);
            linkpass.TabIndex = 0;
            linkpass.TabStop = true;
            linkpass.Text = "¿Ha olvidado la contraseña?";
            // 
            // btncerrar
            // 
            btncerrar.BackColor = Color.DimGray;
            btncerrar.Image = (Image)resources.GetObject("btncerrar.Image");
            btncerrar.Location = new Point(754, -1);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(25, 25);
            btncerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btncerrar.TabIndex = 6;
            btncerrar.TabStop = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // btnminimizar
            // 
            btnminimizar.BackColor = Color.DimGray;
            btnminimizar.Image = Properties.Resources.windowminimize_104316;
            btnminimizar.Location = new Point(729, -1);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(25, 25);
            btnminimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnminimizar.TabIndex = 7;
            btnminimizar.TabStop = false;
            btnminimizar.Click += btnminimizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(780, 330);
            Controls.Add(btnminimizar);
            Controls.Add(btncerrar);
            Controls.Add(linkpass);
            Controls.Add(btnlogin);
            Controls.Add(label1);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtuser;
        private TextBox txtpass;
        private Label label1;
        private Button btnlogin;
        private LinkLabel linkpass;
        private PictureBox btncerrar;
        private PictureBox btnminimizar;
        private PictureBox pictureBox3;
    }
}
