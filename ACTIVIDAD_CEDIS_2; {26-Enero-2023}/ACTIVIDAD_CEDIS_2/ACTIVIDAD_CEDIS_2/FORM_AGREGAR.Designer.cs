namespace ACTIVIDAD_CEDIS_2
{
    partial class FORM_AGREGAR
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_CODIGO = new System.Windows.Forms.TextBox();
            this.TXT_DESCRIPCION = new System.Windows.Forms.TextBox();
            this.CHBX_ACTIVO = new System.Windows.Forms.CheckBox();
            this.GB_Formulario = new System.Windows.Forms.GroupBox();
            this.BTN_ACEPTAR = new System.Windows.Forms.Button();
            this.TXT_PROVEEDOR = new System.Windows.Forms.TextBox();
            this.GB_Formulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Proveedor";
            // 
            // TXT_CODIGO
            // 
            this.TXT_CODIGO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_CODIGO.Location = new System.Drawing.Point(43, 64);
            this.TXT_CODIGO.Name = "TXT_CODIGO";
            this.TXT_CODIGO.Size = new System.Drawing.Size(238, 20);
            this.TXT_CODIGO.TabIndex = 4;
            // 
            // TXT_DESCRIPCION
            // 
            this.TXT_DESCRIPCION.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_DESCRIPCION.Location = new System.Drawing.Point(43, 132);
            this.TXT_DESCRIPCION.Name = "TXT_DESCRIPCION";
            this.TXT_DESCRIPCION.Size = new System.Drawing.Size(238, 20);
            this.TXT_DESCRIPCION.TabIndex = 5;
            // 
            // CHBX_ACTIVO
            // 
            this.CHBX_ACTIVO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CHBX_ACTIVO.AutoSize = true;
            this.CHBX_ACTIVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHBX_ACTIVO.Location = new System.Drawing.Point(43, 263);
            this.CHBX_ACTIVO.Name = "CHBX_ACTIVO";
            this.CHBX_ACTIVO.Size = new System.Drawing.Size(71, 24);
            this.CHBX_ACTIVO.TabIndex = 7;
            this.CHBX_ACTIVO.Text = "Activo";
            this.CHBX_ACTIVO.UseVisualStyleBackColor = true;
            // 
            // GB_Formulario
            // 
            this.GB_Formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Formulario.BackColor = System.Drawing.Color.LightSteelBlue;
            this.GB_Formulario.Controls.Add(this.TXT_PROVEEDOR);
            this.GB_Formulario.Controls.Add(this.BTN_ACEPTAR);
            this.GB_Formulario.Controls.Add(this.label1);
            this.GB_Formulario.Controls.Add(this.CHBX_ACTIVO);
            this.GB_Formulario.Controls.Add(this.label2);
            this.GB_Formulario.Controls.Add(this.label3);
            this.GB_Formulario.Controls.Add(this.TXT_DESCRIPCION);
            this.GB_Formulario.Controls.Add(this.TXT_CODIGO);
            this.GB_Formulario.Location = new System.Drawing.Point(59, 33);
            this.GB_Formulario.Name = "GB_Formulario";
            this.GB_Formulario.Size = new System.Drawing.Size(335, 390);
            this.GB_Formulario.TabIndex = 8;
            this.GB_Formulario.TabStop = false;
            // 
            // BTN_ACEPTAR
            // 
            this.BTN_ACEPTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ACEPTAR.Location = new System.Drawing.Point(199, 302);
            this.BTN_ACEPTAR.Name = "BTN_ACEPTAR";
            this.BTN_ACEPTAR.Size = new System.Drawing.Size(82, 39);
            this.BTN_ACEPTAR.TabIndex = 8;
            this.BTN_ACEPTAR.Text = "Aceptar";
            this.BTN_ACEPTAR.UseVisualStyleBackColor = true;
            this.BTN_ACEPTAR.Click += new System.EventHandler(this.BTN_ACEPTAR_Click);
            // 
            // TXT_PROVEEDOR
            // 
            this.TXT_PROVEEDOR.Location = new System.Drawing.Point(43, 210);
            this.TXT_PROVEEDOR.Name = "TXT_PROVEEDOR";
            this.TXT_PROVEEDOR.Size = new System.Drawing.Size(238, 20);
            this.TXT_PROVEEDOR.TabIndex = 9;
            // 
            // FORM_AGREGAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 452);
            this.Controls.Add(this.GB_Formulario);
            this.Name = "FORM_AGREGAR";
            this.Text = "FORM_AGREGAR";
            this.GB_Formulario.ResumeLayout(false);
            this.GB_Formulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_CODIGO;
        private System.Windows.Forms.TextBox TXT_DESCRIPCION;
        private System.Windows.Forms.CheckBox CHBX_ACTIVO;
        private System.Windows.Forms.GroupBox GB_Formulario;
        private System.Windows.Forms.Button BTN_ACEPTAR;
        private System.Windows.Forms.TextBox TXT_PROVEEDOR;
    }
}