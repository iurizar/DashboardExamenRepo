
namespace DashUI
{
    partial class InfoUC
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelID = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelApe = new System.Windows.Forms.Label();
            this.labelLoc = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(192, 127);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(51, 20);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "label1";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(192, 169);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(51, 20);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "label1";
            // 
            // labelApe
            // 
            this.labelApe.AutoSize = true;
            this.labelApe.Location = new System.Drawing.Point(192, 210);
            this.labelApe.Name = "labelApe";
            this.labelApe.Size = new System.Drawing.Size(51, 20);
            this.labelApe.TabIndex = 2;
            this.labelApe.Text = "label1";
            // 
            // labelLoc
            // 
            this.labelLoc.AutoSize = true;
            this.labelLoc.Location = new System.Drawing.Point(192, 252);
            this.labelLoc.Name = "labelLoc";
            this.labelLoc.Size = new System.Drawing.Size(51, 20);
            this.labelLoc.TabIndex = 3;
            this.labelLoc.Text = "label1";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(192, 290);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(51, 20);
            this.labelEdad.TabIndex = 4;
            this.labelEdad.Text = "label1";
            // 
            // InfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelLoc);
            this.Controls.Add(this.labelApe);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelID);
            this.Name = "InfoUC";
            this.Size = new System.Drawing.Size(862, 508);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.InfoUC_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelApe;
        private System.Windows.Forms.Label labelLoc;
        private System.Windows.Forms.Label labelEdad;
    }
}
