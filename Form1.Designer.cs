namespace LibreriaProyecto
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ingresoBtn = new System.Windows.Forms.Button();
            this.contraseñaInput = new System.Windows.Forms.MaskedTextBox();
            this.usuarioInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.registrarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.avisoRellene = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ingresoBtn
            // 
            this.ingresoBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ingresoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ingresoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresoBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ingresoBtn.FlatAppearance.BorderSize = 0;
            this.ingresoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ingresoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ingresoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingresoBtn.Font = new System.Drawing.Font("Fira Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresoBtn.ForeColor = System.Drawing.Color.White;
            this.ingresoBtn.Location = new System.Drawing.Point(77, 348);
            this.ingresoBtn.Name = "ingresoBtn";
            this.ingresoBtn.Size = new System.Drawing.Size(132, 32);
            this.ingresoBtn.TabIndex = 3;
            this.ingresoBtn.Text = "Ingresar";
            this.ingresoBtn.UseVisualStyleBackColor = false;
            this.ingresoBtn.Click += new System.EventHandler(this.ingresoBtn_Click);
            // 
            // contraseñaInput
            // 
            this.contraseñaInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contraseñaInput.AsciiOnly = true;
            this.contraseñaInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contraseñaInput.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaInput.Location = new System.Drawing.Point(122, 284);
            this.contraseñaInput.Name = "contraseñaInput";
            this.contraseñaInput.PasswordChar = '*';
            this.contraseñaInput.Size = new System.Drawing.Size(262, 25);
            this.contraseñaInput.TabIndex = 2;
            this.contraseñaInput.Text = "12345";
            // 
            // usuarioInput
            // 
            this.usuarioInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usuarioInput.BackColor = System.Drawing.Color.White;
            this.usuarioInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuarioInput.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioInput.Location = new System.Drawing.Point(0, 0);
            this.usuarioInput.MaxLength = 16;
            this.usuarioInput.Name = "usuarioInput";
            this.usuarioInput.Size = new System.Drawing.Size(262, 25);
            this.usuarioInput.TabIndex = 1;
            this.usuarioInput.Text = "Oscar";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.usuarioInput);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(122, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 29);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Location = new System.Drawing.Point(122, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 29);
            this.panel2.TabIndex = 8;
            // 
            // registrarBtn
            // 
            this.registrarBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registrarBtn.BackColor = System.Drawing.Color.White;
            this.registrarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrarBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.registrarBtn.FlatAppearance.BorderSize = 0;
            this.registrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarBtn.Font = new System.Drawing.Font("Fira Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.registrarBtn.Location = new System.Drawing.Point(215, 348);
            this.registrarBtn.Name = "registrarBtn";
            this.registrarBtn.Size = new System.Drawing.Size(169, 32);
            this.registrarBtn.TabIndex = 4;
            this.registrarBtn.Text = "Registrarse";
            this.registrarBtn.UseVisualStyleBackColor = false;
            this.registrarBtn.Click += new System.EventHandler(this.registrarBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ventana de acceso";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(175, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 120);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(77, 226);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // avisoRellene
            // 
            this.avisoRellene.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.avisoRellene.AutoSize = true;
            this.avisoRellene.ForeColor = System.Drawing.Color.Black;
            this.avisoRellene.Location = new System.Drawing.Point(79, 397);
            this.avisoRellene.Name = "avisoRellene";
            this.avisoRellene.Size = new System.Drawing.Size(115, 16);
            this.avisoRellene.TabIndex = 23;
            this.avisoRellene.Text = "Rellene sus datos";
            this.avisoRellene.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.avisoRellene);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrarBtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.contraseñaInput);
            this.Controls.Add(this.ingresoBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libromania";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ingresoBtn;
        private System.Windows.Forms.MaskedTextBox contraseñaInput;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox usuarioInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button registrarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label avisoRellene;
    }
}

