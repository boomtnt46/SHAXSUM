namespace SHAXSUM
{
    partial class SHAXSUM
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
            this.checkSHA1Button = new System.Windows.Forms.Button();
            this.sha1TextBox = new System.Windows.Forms.TextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.sha256TextBox = new System.Windows.Forms.TextBox();
            this.checkSHA256Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sha1Result = new System.Windows.Forms.Label();
            this.sha256Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkSHA1Button
            // 
            this.checkSHA1Button.Location = new System.Drawing.Point(571, 35);
            this.checkSHA1Button.Name = "checkSHA1Button";
            this.checkSHA1Button.Size = new System.Drawing.Size(90, 36);
            this.checkSHA1Button.TabIndex = 0;
            this.checkSHA1Button.Text = "Check";
            this.checkSHA1Button.UseVisualStyleBackColor = true;
            this.checkSHA1Button.Click += new System.EventHandler(this.checkSHA1Button_Click);
            // 
            // sha1TextBox
            // 
            this.sha1TextBox.Location = new System.Drawing.Point(94, 40);
            this.sha1TextBox.Name = "sha1TextBox";
            this.sha1TextBox.Size = new System.Drawing.Size(471, 26);
            this.sha1TextBox.TabIndex = 1;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(4, 35);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(83, 78);
            this.openFileButton.TabIndex = 2;
            this.openFileButton.Text = "Open file";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // sha256TextBox
            // 
            this.sha256TextBox.Location = new System.Drawing.Point(94, 82);
            this.sha256TextBox.Name = "sha256TextBox";
            this.sha256TextBox.Size = new System.Drawing.Size(471, 26);
            this.sha256TextBox.TabIndex = 5;
            // 
            // checkSHA256Button
            // 
            this.checkSHA256Button.Location = new System.Drawing.Point(571, 77);
            this.checkSHA256Button.Name = "checkSHA256Button";
            this.checkSHA256Button.Size = new System.Drawing.Size(90, 36);
            this.checkSHA256Button.TabIndex = 4;
            this.checkSHA256Button.Text = "Check";
            this.checkSHA256Button.UseVisualStyleBackColor = true;
            this.checkSHA256Button.Click += new System.EventHandler(this.checkSHA256Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "SHA1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "SHA256";
            // 
            // sha1Result
            // 
            this.sha1Result.AutoSize = true;
            this.sha1Result.Location = new System.Drawing.Point(763, 43);
            this.sha1Result.Name = "sha1Result";
            this.sha1Result.Size = new System.Drawing.Size(0, 20);
            this.sha1Result.TabIndex = 8;
            // 
            // sha256Result
            // 
            this.sha256Result.AutoSize = true;
            this.sha256Result.Location = new System.Drawing.Point(767, 87);
            this.sha256Result.Name = "sha256Result";
            this.sha256Result.Size = new System.Drawing.Size(0, 20);
            this.sha256Result.TabIndex = 9;
            // 
            // SHAXSUM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 136);
            this.Controls.Add(this.sha256Result);
            this.Controls.Add(this.sha1Result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sha256TextBox);
            this.Controls.Add(this.checkSHA256Button);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.sha1TextBox);
            this.Controls.Add(this.checkSHA1Button);
            this.Name = "SHAXSUM";
            this.Text = "SHAXSUM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkSHA1Button;
        private System.Windows.Forms.TextBox sha1TextBox;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.TextBox sha256TextBox;
        private System.Windows.Forms.Button checkSHA256Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sha1Result;
        private System.Windows.Forms.Label sha256Result;
    }
}

