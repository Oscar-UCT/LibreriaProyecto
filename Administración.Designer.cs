namespace LibreriaProyecto
{
    partial class Administración
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administración));
            this.tablaAdmin = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nombreInput = new System.Windows.Forms.TextBox();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.editarBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.autorInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.generoInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.añoInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.precioInput = new System.Windows.Forms.TextBox();
            this.avisoSeleccione = new System.Windows.Forms.Label();
            this.añadirBtn = new System.Windows.Forms.Button();
            this.añoInvalidoLabel = new System.Windows.Forms.Label();
            this.precioInvalidoLabel = new System.Windows.Forms.Label();
            this.salirBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAdmin)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaAdmin
            // 
            this.tablaAdmin.AllowUserToAddRows = false;
            this.tablaAdmin.AllowUserToDeleteRows = false;
            this.tablaAdmin.AllowUserToResizeColumns = false;
            this.tablaAdmin.AllowUserToResizeRows = false;
            this.tablaAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaAdmin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaAdmin.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAdmin.Location = new System.Drawing.Point(12, 232);
            this.tablaAdmin.MultiSelect = false;
            this.tablaAdmin.Name = "tablaAdmin";
            this.tablaAdmin.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Ebrima", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaAdmin.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaAdmin.RowHeadersVisible = false;
            this.tablaAdmin.RowHeadersWidth = 51;
            this.tablaAdmin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaAdmin.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaAdmin.RowTemplate.Height = 24;
            this.tablaAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaAdmin.Size = new System.Drawing.Size(1358, 509);
            this.tablaAdmin.TabIndex = 0;
            this.tablaAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaAdmin_CellClick);
            this.tablaAdmin.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tablaAdmin_ColumnHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.nombreInput);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(15, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 29);
            this.panel1.TabIndex = 10;
            // 
            // nombreInput
            // 
            this.nombreInput.BackColor = System.Drawing.Color.White;
            this.nombreInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreInput.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreInput.Location = new System.Drawing.Point(0, 0);
            this.nombreInput.MaxLength = 50;
            this.nombreInput.Name = "nombreInput";
            this.nombreInput.Size = new System.Drawing.Size(360, 25);
            this.nombreInput.TabIndex = 1;
            // 
            // buscarBtn
            // 
            this.buscarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buscarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buscarBtn.FlatAppearance.BorderSize = 0;
            this.buscarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buscarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buscarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarBtn.Font = new System.Drawing.Font("Fira Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarBtn.ForeColor = System.Drawing.Color.White;
            this.buscarBtn.Location = new System.Drawing.Point(538, 164);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(132, 32);
            this.buscarBtn.TabIndex = 9;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = false;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eliminarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.eliminarBtn.FlatAppearance.BorderSize = 0;
            this.eliminarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eliminarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.eliminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarBtn.Font = new System.Drawing.Font("Fira Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarBtn.ForeColor = System.Drawing.Color.White;
            this.eliminarBtn.Location = new System.Drawing.Point(1072, 194);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(132, 32);
            this.eliminarBtn.TabIndex = 12;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = false;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // editarBtn
            // 
            this.editarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.editarBtn.FlatAppearance.BorderSize = 0;
            this.editarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.editarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarBtn.Font = new System.Drawing.Font("Fira Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarBtn.ForeColor = System.Drawing.Color.White;
            this.editarBtn.Location = new System.Drawing.Point(934, 194);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(132, 32);
            this.editarBtn.TabIndex = 13;
            this.editarBtn.Text = "Editar";
            this.editarBtn.UseVisualStyleBackColor = false;
            this.editarBtn.Click += new System.EventHandler(this.editarBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Autor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.autorInput);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(15, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 29);
            this.panel2.TabIndex = 14;
            // 
            // autorInput
            // 
            this.autorInput.BackColor = System.Drawing.Color.White;
            this.autorInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.autorInput.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorInput.Location = new System.Drawing.Point(0, 0);
            this.autorInput.MaxLength = 50;
            this.autorInput.Name = "autorInput";
            this.autorInput.Size = new System.Drawing.Size(360, 25);
            this.autorInput.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Género";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel3.Controls.Add(this.generoInput);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(15, 167);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 29);
            this.panel3.TabIndex = 16;
            // 
            // generoInput
            // 
            this.generoInput.BackColor = System.Drawing.Color.White;
            this.generoInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.generoInput.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generoInput.Location = new System.Drawing.Point(0, 0);
            this.generoInput.MaxLength = 50;
            this.generoInput.Name = "generoInput";
            this.generoInput.Size = new System.Drawing.Size(360, 25);
            this.generoInput.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Año";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel4.Controls.Add(this.añoInput);
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(400, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(360, 29);
            this.panel4.TabIndex = 20;
            // 
            // añoInput
            // 
            this.añoInput.BackColor = System.Drawing.Color.White;
            this.añoInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.añoInput.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.añoInput.Location = new System.Drawing.Point(0, 0);
            this.añoInput.MaxLength = 5;
            this.añoInput.Name = "añoInput";
            this.añoInput.Size = new System.Drawing.Size(360, 25);
            this.añoInput.TabIndex = 1;
            this.añoInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.añoInput_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Precio";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel5.Controls.Add(this.precioInput);
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(400, 97);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(360, 29);
            this.panel5.TabIndex = 18;
            // 
            // precioInput
            // 
            this.precioInput.BackColor = System.Drawing.Color.White;
            this.precioInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.precioInput.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioInput.Location = new System.Drawing.Point(0, 0);
            this.precioInput.MaxLength = 10;
            this.precioInput.Name = "precioInput";
            this.precioInput.Size = new System.Drawing.Size(360, 25);
            this.precioInput.TabIndex = 1;
            this.precioInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.precioInput_KeyUp);
            // 
            // avisoSeleccione
            // 
            this.avisoSeleccione.AutoSize = true;
            this.avisoSeleccione.Location = new System.Drawing.Point(1219, 203);
            this.avisoSeleccione.Name = "avisoSeleccione";
            this.avisoSeleccione.Size = new System.Drawing.Size(120, 16);
            this.avisoSeleccione.TabIndex = 22;
            this.avisoSeleccione.Text = "Seleccione una fila";
            this.avisoSeleccione.Visible = false;
            // 
            // añadirBtn
            // 
            this.añadirBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.añadirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.añadirBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.añadirBtn.FlatAppearance.BorderSize = 0;
            this.añadirBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.añadirBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.añadirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.añadirBtn.Font = new System.Drawing.Font("Fira Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.añadirBtn.ForeColor = System.Drawing.Color.White;
            this.añadirBtn.Location = new System.Drawing.Point(400, 164);
            this.añadirBtn.Name = "añadirBtn";
            this.añadirBtn.Size = new System.Drawing.Size(132, 32);
            this.añadirBtn.TabIndex = 23;
            this.añadirBtn.Text = "Añadir";
            this.añadirBtn.UseVisualStyleBackColor = false;
            this.añadirBtn.Click += new System.EventHandler(this.añadirBtn_Click);
            // 
            // añoInvalidoLabel
            // 
            this.añoInvalidoLabel.AutoSize = true;
            this.añoInvalidoLabel.Location = new System.Drawing.Point(766, 28);
            this.añoInvalidoLabel.Name = "añoInvalidoLabel";
            this.añoInvalidoLabel.Size = new System.Drawing.Size(136, 16);
            this.añoInvalidoLabel.TabIndex = 24;
            this.añoInvalidoLabel.Text = "Ingrese solo números";
            this.añoInvalidoLabel.Visible = false;
            // 
            // precioInvalidoLabel
            // 
            this.precioInvalidoLabel.AutoSize = true;
            this.precioInvalidoLabel.Location = new System.Drawing.Point(766, 102);
            this.precioInvalidoLabel.Name = "precioInvalidoLabel";
            this.precioInvalidoLabel.Size = new System.Drawing.Size(136, 16);
            this.precioInvalidoLabel.TabIndex = 25;
            this.precioInvalidoLabel.Text = "Ingrese solo números";
            this.precioInvalidoLabel.Visible = false;
            // 
            // salirBtn
            // 
            this.salirBtn.BackColor = System.Drawing.Color.White;
            this.salirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salirBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.salirBtn.FlatAppearance.BorderSize = 0;
            this.salirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salirBtn.Font = new System.Drawing.Font("Fira Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salirBtn.Location = new System.Drawing.Point(1201, 12);
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.Size = new System.Drawing.Size(169, 32);
            this.salirBtn.TabIndex = 26;
            this.salirBtn.Text = "Salir";
            this.salirBtn.UseVisualStyleBackColor = false;
            this.salirBtn.Click += new System.EventHandler(this.salirBtn_Click);
            // 
            // Administración
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.salirBtn);
            this.Controls.Add(this.precioInvalidoLabel);
            this.Controls.Add(this.añoInvalidoLabel);
            this.Controls.Add(this.añadirBtn);
            this.Controls.Add(this.avisoSeleccione);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.editarBtn);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buscarBtn);
            this.Controls.Add(this.tablaAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Administración";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Administración_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.tablaAdmin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nombreInput;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox autorInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox generoInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox añoInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox precioInput;
        private System.Windows.Forms.Label avisoSeleccione;
        private System.Windows.Forms.Button añadirBtn;
        private System.Windows.Forms.Label añoInvalidoLabel;
        private System.Windows.Forms.Label precioInvalidoLabel;
        private System.Windows.Forms.Button salirBtn;
    }
}