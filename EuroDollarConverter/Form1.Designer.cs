
namespace EuroDollarConverter
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
            this.BtnEuroToDollar = new System.Windows.Forms.Button();
            this.BtnDollarToEuro = new System.Windows.Forms.Button();
            this.TxtEuro = new System.Windows.Forms.TextBox();
            this.TxtDollar = new System.Windows.Forms.TextBox();
            this.NudCourse = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NudCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEuroToDollar
            // 
            this.BtnEuroToDollar.Location = new System.Drawing.Point(413, 169);
            this.BtnEuroToDollar.Name = "BtnEuroToDollar";
            this.BtnEuroToDollar.Size = new System.Drawing.Size(93, 50);
            this.BtnEuroToDollar.TabIndex = 0;
            this.BtnEuroToDollar.Text = ">";
            this.BtnEuroToDollar.UseVisualStyleBackColor = true;
            this.BtnEuroToDollar.Click += new System.EventHandler(this.BtnEuroToDollar_Click);
            // 
            // BtnDollarToEuro
            // 
            this.BtnDollarToEuro.Location = new System.Drawing.Point(314, 169);
            this.BtnDollarToEuro.Name = "BtnDollarToEuro";
            this.BtnDollarToEuro.Size = new System.Drawing.Size(93, 50);
            this.BtnDollarToEuro.TabIndex = 1;
            this.BtnDollarToEuro.Text = "<";
            this.BtnDollarToEuro.UseVisualStyleBackColor = true;
            this.BtnDollarToEuro.Click += new System.EventHandler(this.BtnDollarToEuro_Click);
            // 
            // TxtEuro
            // 
            this.TxtEuro.Location = new System.Drawing.Point(213, 185);
            this.TxtEuro.Name = "TxtEuro";
            this.TxtEuro.Size = new System.Drawing.Size(95, 20);
            this.TxtEuro.TabIndex = 2;
            // 
            // TxtDollar
            // 
            this.TxtDollar.Location = new System.Drawing.Point(512, 185);
            this.TxtDollar.Name = "TxtDollar";
            this.TxtDollar.Size = new System.Drawing.Size(95, 20);
            this.TxtDollar.TabIndex = 3;
            // 
            // NudCourse
            // 
            this.NudCourse.DecimalPlaces = 2;
            this.NudCourse.Location = new System.Drawing.Point(386, 263);
            this.NudCourse.Name = "NudCourse";
            this.NudCourse.Size = new System.Drawing.Size(120, 20);
            this.NudCourse.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NudCourse);
            this.Controls.Add(this.TxtDollar);
            this.Controls.Add(this.TxtEuro);
            this.Controls.Add(this.BtnDollarToEuro);
            this.Controls.Add(this.BtnEuroToDollar);
            this.Name = "Form1";
            this.Text = "Euro Dollar Converter";
            ((System.ComponentModel.ISupportInitialize)(this.NudCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEuroToDollar;
        private System.Windows.Forms.Button BtnDollarToEuro;
        private System.Windows.Forms.TextBox TxtEuro;
        private System.Windows.Forms.TextBox TxtDollar;
        private System.Windows.Forms.NumericUpDown NudCourse;
    }
}

