namespace ACTIVIDAD_CEDIS_2
{
    partial class Form1
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
            this.DGV_CATALOGO = new System.Windows.Forms.DataGridView();
            this.BTN_AGREGAR = new System.Windows.Forms.Button();
            this.LBL_PRODUCTOS = new System.Windows.Forms.Label();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.TXT_CODIGO_ARTICULO = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BTN_EDITAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CATALOGO)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_CATALOGO
            // 
            this.DGV_CATALOGO.AllowUserToAddRows = false;
            this.DGV_CATALOGO.AllowUserToDeleteRows = false;
            this.DGV_CATALOGO.AllowUserToResizeColumns = false;
            this.DGV_CATALOGO.AllowUserToResizeRows = false;
            this.DGV_CATALOGO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_CATALOGO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CATALOGO.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_CATALOGO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CATALOGO.Location = new System.Drawing.Point(39, 122);
            this.DGV_CATALOGO.MultiSelect = false;
            this.DGV_CATALOGO.Name = "DGV_CATALOGO";
            this.DGV_CATALOGO.ReadOnly = true;
            this.DGV_CATALOGO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CATALOGO.Size = new System.Drawing.Size(545, 320);
            this.DGV_CATALOGO.TabIndex = 0;
            this.DGV_CATALOGO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CATALOGO_CellClick);
            this.DGV_CATALOGO.SelectionChanged += new System.EventHandler(this.DGV_CATALOGO_SelectionChanged);
            // 
            // BTN_AGREGAR
            // 
            this.BTN_AGREGAR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_AGREGAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AGREGAR.Location = new System.Drawing.Point(26, 35);
            this.BTN_AGREGAR.Name = "BTN_AGREGAR";
            this.BTN_AGREGAR.Size = new System.Drawing.Size(148, 55);
            this.BTN_AGREGAR.TabIndex = 1;
            this.BTN_AGREGAR.Text = "Agregar";
            this.BTN_AGREGAR.UseVisualStyleBackColor = true;
            this.BTN_AGREGAR.Click += new System.EventHandler(this.BTN_AGREGAR_Click);
            // 
            // LBL_PRODUCTOS
            // 
            this.LBL_PRODUCTOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_PRODUCTOS.AutoSize = true;
            this.LBL_PRODUCTOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PRODUCTOS.Location = new System.Drawing.Point(229, 64);
            this.LBL_PRODUCTOS.Name = "LBL_PRODUCTOS";
            this.LBL_PRODUCTOS.Size = new System.Drawing.Size(158, 29);
            this.LBL_PRODUCTOS.TabIndex = 2;
            this.LBL_PRODUCTOS.Text = "ARTICULOS";
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.Enabled = false;
            this.BTN_DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DELETE.Location = new System.Drawing.Point(26, 117);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(148, 55);
            this.BTN_DELETE.TabIndex = 3;
            this.BTN_DELETE.Text = "Eliminar";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // TXT_CODIGO_ARTICULO
            // 
            this.TXT_CODIGO_ARTICULO.Location = new System.Drawing.Point(26, 284);
            this.TXT_CODIGO_ARTICULO.Name = "TXT_CODIGO_ARTICULO";
            this.TXT_CODIGO_ARTICULO.Size = new System.Drawing.Size(148, 20);
            this.TXT_CODIGO_ARTICULO.TabIndex = 4;
            this.TXT_CODIGO_ARTICULO.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Beige;
            this.groupBox1.Controls.Add(this.BTN_EDITAR);
            this.groupBox1.Controls.Add(this.BTN_AGREGAR);
            this.groupBox1.Controls.Add(this.TXT_CODIGO_ARTICULO);
            this.groupBox1.Controls.Add(this.BTN_DELETE);
            this.groupBox1.Location = new System.Drawing.Point(606, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 320);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // BTN_EDITAR
            // 
            this.BTN_EDITAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EDITAR.Location = new System.Drawing.Point(26, 200);
            this.BTN_EDITAR.Name = "BTN_EDITAR";
            this.BTN_EDITAR.Size = new System.Drawing.Size(148, 55);
            this.BTN_EDITAR.TabIndex = 5;
            this.BTN_EDITAR.Text = "Editar";
            this.BTN_EDITAR.UseVisualStyleBackColor = true;
            this.BTN_EDITAR.Click += new System.EventHandler(this.BTN_EDITAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 479);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LBL_PRODUCTOS);
            this.Controls.Add(this.DGV_CATALOGO);
            this.Name = "Form1";
            this.Text = "Catalogo";
            this.Enter += new System.EventHandler(this.Form1_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CATALOGO)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_CATALOGO;
        private System.Windows.Forms.Button BTN_AGREGAR;
        private System.Windows.Forms.Label LBL_PRODUCTOS;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.TextBox TXT_CODIGO_ARTICULO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BTN_EDITAR;
    }
}

