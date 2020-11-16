namespace MasterForm
{
    partial class MasterForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHamburguesas = new System.Windows.Forms.TabPage();
            this.dataGridViewHamb = new System.Windows.Forms.DataGridView();
            this.tabPostres = new System.Windows.Forms.TabPage();
            this.tabCafeteria = new System.Windows.Forms.TabPage();
            this.tabBebidas = new System.Windows.Forms.TabPage();
            this.tabPasteleria = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabHamburguesas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHamb)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHamburguesas);
            this.tabControl1.Controls.Add(this.tabPostres);
            this.tabControl1.Controls.Add(this.tabCafeteria);
            this.tabControl1.Controls.Add(this.tabBebidas);
            this.tabControl1.Controls.Add(this.tabPasteleria);
            this.tabControl1.Location = new System.Drawing.Point(362, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(814, 382);
            this.tabControl1.TabIndex = 5;
            // 
            // tabHamburguesas
            // 
            this.tabHamburguesas.Controls.Add(this.dataGridViewHamb);
            this.tabHamburguesas.Location = new System.Drawing.Point(4, 25);
            this.tabHamburguesas.Name = "tabHamburguesas";
            this.tabHamburguesas.Padding = new System.Windows.Forms.Padding(3);
            this.tabHamburguesas.Size = new System.Drawing.Size(806, 353);
            this.tabHamburguesas.TabIndex = 0;
            this.tabHamburguesas.Text = "Hamburguesas";
            this.tabHamburguesas.UseVisualStyleBackColor = true;
            this.tabHamburguesas.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridViewHamb
            // 
            this.dataGridViewHamb.AllowUserToOrderColumns = true;
            this.dataGridViewHamb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHamb.Location = new System.Drawing.Point(6, 15);
            this.dataGridViewHamb.Name = "dataGridViewHamb";
            this.dataGridViewHamb.RowHeadersWidth = 51;
            this.dataGridViewHamb.RowTemplate.Height = 24;
            this.dataGridViewHamb.Size = new System.Drawing.Size(776, 304);
            this.dataGridViewHamb.TabIndex = 0;
            this.dataGridViewHamb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHamb_CellContentClick);
            // 
            // tabPostres
            // 
            this.tabPostres.Location = new System.Drawing.Point(4, 25);
            this.tabPostres.Name = "tabPostres";
            this.tabPostres.Padding = new System.Windows.Forms.Padding(3);
            this.tabPostres.Size = new System.Drawing.Size(806, 353);
            this.tabPostres.TabIndex = 1;
            this.tabPostres.Text = "Postres";
            this.tabPostres.UseVisualStyleBackColor = true;
            // 
            // tabCafeteria
            // 
            this.tabCafeteria.Location = new System.Drawing.Point(4, 25);
            this.tabCafeteria.Name = "tabCafeteria";
            this.tabCafeteria.Size = new System.Drawing.Size(806, 353);
            this.tabCafeteria.TabIndex = 2;
            this.tabCafeteria.Text = "Cafeteria";
            this.tabCafeteria.UseVisualStyleBackColor = true;
            // 
            // tabBebidas
            // 
            this.tabBebidas.Location = new System.Drawing.Point(4, 25);
            this.tabBebidas.Name = "tabBebidas";
            this.tabBebidas.Size = new System.Drawing.Size(806, 353);
            this.tabBebidas.TabIndex = 3;
            this.tabBebidas.Text = "Bebidas";
            this.tabBebidas.UseVisualStyleBackColor = true;
            // 
            // tabPasteleria
            // 
            this.tabPasteleria.Location = new System.Drawing.Point(4, 25);
            this.tabPasteleria.Name = "tabPasteleria";
            this.tabPasteleria.Size = new System.Drawing.Size(806, 353);
            this.tabPasteleria.TabIndex = 4;
            this.tabPasteleria.Text = "Pasteleria";
            this.tabPasteleria.UseVisualStyleBackColor = true;
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 615);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "MasterForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabHamburguesas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHamb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHamburguesas;
        private System.Windows.Forms.TabPage tabPostres;
        private System.Windows.Forms.TabPage tabCafeteria;
        private System.Windows.Forms.TabPage tabBebidas;
        private System.Windows.Forms.TabPage tabPasteleria;
        private System.Windows.Forms.DataGridView dataGridViewHamb;
    }
}

