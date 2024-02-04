
namespace WindowsFormsApp1
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
            this.baseClassButton = new System.Windows.Forms.Button();
            this.subClassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // baseClassButton
            // 
            this.baseClassButton.Location = new System.Drawing.Point(273, 91);
            this.baseClassButton.Name = "baseClassButton";
            this.baseClassButton.Size = new System.Drawing.Size(75, 23);
            this.baseClassButton.TabIndex = 0;
            this.baseClassButton.Text = "BaseClass";
            this.baseClassButton.UseVisualStyleBackColor = true;
            this.baseClassButton.Click += new System.EventHandler(this.baseClassButton_Click);
            // 
            // subClassButton
            // 
            this.subClassButton.Location = new System.Drawing.Point(273, 138);
            this.subClassButton.Name = "subClassButton";
            this.subClassButton.Size = new System.Drawing.Size(75, 23);
            this.subClassButton.TabIndex = 1;
            this.subClassButton.Text = "subClass";
            this.subClassButton.UseVisualStyleBackColor = true;
            this.subClassButton.Click += new System.EventHandler(this.subClassButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.subClassButton);
            this.Controls.Add(this.baseClassButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button baseClassButton;
        private System.Windows.Forms.Button subClassButton;
    }
}

