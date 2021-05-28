
namespace DashUI
{
    partial class MainUI
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpData = new System.Windows.Forms.TableLayoutPanel();
            this.panelUC = new System.Windows.Forms.Panel();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonEmp = new System.Windows.Forms.Button();
            this.buttonVentas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCom3 = new System.Windows.Forms.Label();
            this.labelCom2 = new System.Windows.Forms.Label();
            this.labelCom1 = new System.Windows.Forms.Label();
            this.buttonReport = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tlpData.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpMain.Controls.Add(this.tlpData, 1, 0);
            this.tlpMain.Controls.Add(this.panel1, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(1092, 610);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpData
            // 
            this.tlpData.ColumnCount = 1;
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpData.Controls.Add(this.panelUC, 0, 1);
            this.tlpData.Controls.Add(this.tlpBotones, 0, 0);
            this.tlpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpData.Location = new System.Drawing.Point(221, 3);
            this.tlpData.Name = "tlpData";
            this.tlpData.RowCount = 2;
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpData.Size = new System.Drawing.Size(868, 604);
            this.tlpData.TabIndex = 0;
            // 
            // panelUC
            // 
            this.panelUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUC.Location = new System.Drawing.Point(3, 93);
            this.panelUC.Name = "panelUC";
            this.panelUC.Size = new System.Drawing.Size(862, 508);
            this.panelUC.TabIndex = 0;
            // 
            // tlpBotones
            // 
            this.tlpBotones.ColumnCount = 4;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBotones.Controls.Add(this.buttonInfo, 0, 0);
            this.tlpBotones.Controls.Add(this.buttonEmp, 1, 0);
            this.tlpBotones.Controls.Add(this.buttonVentas, 2, 0);
            this.tlpBotones.Controls.Add(this.buttonReport, 3, 0);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotones.Location = new System.Drawing.Point(3, 3);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.Size = new System.Drawing.Size(862, 84);
            this.tlpBotones.TabIndex = 1;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(3, 3);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(209, 78);
            this.buttonInfo.TabIndex = 0;
            this.buttonInfo.Text = "INFO";
            this.buttonInfo.UseVisualStyleBackColor = true;
            // 
            // buttonEmp
            // 
            this.buttonEmp.Location = new System.Drawing.Point(218, 3);
            this.buttonEmp.Name = "buttonEmp";
            this.buttonEmp.Size = new System.Drawing.Size(209, 78);
            this.buttonEmp.TabIndex = 1;
            this.buttonEmp.Text = "EMPLEADOS";
            this.buttonEmp.UseVisualStyleBackColor = true;
            this.buttonEmp.Click += new System.EventHandler(this.buttonEmp_Click);
            // 
            // buttonVentas
            // 
            this.buttonVentas.Location = new System.Drawing.Point(433, 3);
            this.buttonVentas.Name = "buttonVentas";
            this.buttonVentas.Size = new System.Drawing.Size(209, 78);
            this.buttonVentas.TabIndex = 2;
            this.buttonVentas.Text = "VENTAS";
            this.buttonVentas.UseVisualStyleBackColor = true;
            this.buttonVentas.Click += new System.EventHandler(this.buttonVentas_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelCom3);
            this.panel1.Controls.Add(this.labelCom2);
            this.panel1.Controls.Add(this.labelCom1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 604);
            this.panel1.TabIndex = 1;
            // 
            // labelCom3
            // 
            this.labelCom3.AutoSize = true;
            this.labelCom3.Location = new System.Drawing.Point(9, 93);
            this.labelCom3.Name = "labelCom3";
            this.labelCom3.Size = new System.Drawing.Size(18, 20);
            this.labelCom3.TabIndex = 2;
            this.labelCom3.Text = "3";
            this.labelCom3.Click += new System.EventHandler(this.SeleccionaComercial);
            // 
            // labelCom2
            // 
            this.labelCom2.AutoSize = true;
            this.labelCom2.Location = new System.Drawing.Point(9, 52);
            this.labelCom2.Name = "labelCom2";
            this.labelCom2.Size = new System.Drawing.Size(18, 20);
            this.labelCom2.TabIndex = 1;
            this.labelCom2.Text = "2";
            this.labelCom2.Click += new System.EventHandler(this.SeleccionaComercial);
            // 
            // labelCom1
            // 
            this.labelCom1.AutoSize = true;
            this.labelCom1.Location = new System.Drawing.Point(10, 10);
            this.labelCom1.Name = "labelCom1";
            this.labelCom1.Size = new System.Drawing.Size(18, 20);
            this.labelCom1.TabIndex = 0;
            this.labelCom1.Text = "1";
            this.labelCom1.Click += new System.EventHandler(this.SeleccionaComercial);
            // 
            // buttonReport
            // 
            this.buttonReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReport.Location = new System.Drawing.Point(648, 3);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(211, 78);
            this.buttonReport.TabIndex = 3;
            this.buttonReport.Text = "INFORME";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 610);
            this.Controls.Add(this.tlpMain);
            this.Name = "MainUI";
            this.Text = "Form1";
            this.tlpMain.ResumeLayout(false);
            this.tlpData.ResumeLayout(false);
            this.tlpBotones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpData;
        private System.Windows.Forms.Panel panelUC;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonEmp;
        private System.Windows.Forms.Button buttonVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCom3;
        private System.Windows.Forms.Label labelCom2;
        private System.Windows.Forms.Label labelCom1;
        private System.Windows.Forms.Button buttonReport;
    }
}

