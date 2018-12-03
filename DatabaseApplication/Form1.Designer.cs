namespace DatabaseApplication
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
            this.buttonHozzaAd = new System.Windows.Forms.Button();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.textBoxFajta = new System.Windows.Forms.TextBox();
            this.dateTimePickerOrokbeFogad = new System.Windows.Forms.DateTimePicker();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.buttonModositas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHozzaAd
            // 
            this.buttonHozzaAd.Location = new System.Drawing.Point(379, 67);
            this.buttonHozzaAd.Name = "buttonHozzaAd";
            this.buttonHozzaAd.Size = new System.Drawing.Size(75, 23);
            this.buttonHozzaAd.TabIndex = 0;
            this.buttonHozzaAd.Text = "Hozzáad";
            this.buttonHozzaAd.UseVisualStyleBackColor = true;
            this.buttonHozzaAd.Click += new System.EventHandler(this.buttonHozzaAd_Click);
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(40, 30);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(100, 20);
            this.textBoxNev.TabIndex = 1;
            // 
            // textBoxFajta
            // 
            this.textBoxFajta.Location = new System.Drawing.Point(147, 29);
            this.textBoxFajta.Name = "textBoxFajta";
            this.textBoxFajta.Size = new System.Drawing.Size(100, 20);
            this.textBoxFajta.TabIndex = 2;
            // 
            // dateTimePickerOrokbeFogad
            // 
            this.dateTimePickerOrokbeFogad.Location = new System.Drawing.Point(254, 29);
            this.dateTimePickerOrokbeFogad.Name = "dateTimePickerOrokbeFogad";
            this.dateTimePickerOrokbeFogad.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerOrokbeFogad.TabIndex = 3;
            // 
            // buttonTorles
            // 
            this.buttonTorles.Location = new System.Drawing.Point(379, 97);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(75, 23);
            this.buttonTorles.TabIndex = 4;
            this.buttonTorles.Text = "Törlés";
            this.buttonTorles.UseVisualStyleBackColor = true;
            this.buttonTorles.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonModositas
            // 
            this.buttonModositas.Location = new System.Drawing.Point(379, 127);
            this.buttonModositas.Name = "buttonModositas";
            this.buttonModositas.Size = new System.Drawing.Size(75, 23);
            this.buttonModositas.TabIndex = 5;
            this.buttonModositas.Text = "Módosítás";
            this.buttonModositas.UseVisualStyleBackColor = true;
            this.buttonModositas.Click += new System.EventHandler(this.buttonModositas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 355);
            this.Controls.Add(this.buttonModositas);
            this.Controls.Add(this.buttonTorles);
            this.Controls.Add(this.dateTimePickerOrokbeFogad);
            this.Controls.Add(this.textBoxFajta);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.buttonHozzaAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHozzaAd;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.TextBox textBoxFajta;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrokbeFogad;
        private System.Windows.Forms.Button buttonTorles;
        private System.Windows.Forms.Button buttonModositas;
    }
}

