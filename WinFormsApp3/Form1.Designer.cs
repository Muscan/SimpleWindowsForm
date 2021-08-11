
namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCarName = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMotor = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblTraction = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.txtCar = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtEngine = new System.Windows.Forms.TextBox();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.txtTraction = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblReset = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCarName
            // 
            this.lblCarName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCarName.AutoSize = true;
            this.lblCarName.Location = new System.Drawing.Point(506, 43);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.Size = new System.Drawing.Size(56, 20);
            this.lblCarName.TabIndex = 0;
            this.lblCarName.Text = "Masina";
            this.lblCarName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCarName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(464, 131);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(136, 20);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Modelul de Masina";
            this.lblModel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Location = new System.Drawing.Point(492, 274);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(82, 20);
            this.lblMotor.TabIndex = 2;
            this.lblMotor.Text = "Motorizare";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(464, 396);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(148, 20);
            this.lblCategorie.TabIndex = 3;
            this.lblCategorie.Text = "Categorie(SUV, Oras)";
            // 
            // lblTraction
            // 
            this.lblTraction.AutoSize = true;
            this.lblTraction.Location = new System.Drawing.Point(506, 503);
            this.lblTraction.Name = "lblTraction";
            this.lblTraction.Size = new System.Drawing.Size(69, 20);
            this.lblTraction.TabIndex = 4;
            this.lblTraction.Text = "Tractiune";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(516, 588);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(35, 20);
            this.lblPret.TabIndex = 5;
            this.lblPret.Text = "Pret";
            // 
            // txtCar
            // 
            this.txtCar.Location = new System.Drawing.Point(423, 66);
            this.txtCar.Name = "txtCar";
            this.txtCar.Size = new System.Drawing.Size(235, 27);
            this.txtCar.TabIndex = 6;
            this.txtCar.TextChanged += new System.EventHandler(this.txtCar_TextChanged);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(423, 196);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(235, 27);
            this.txtModel.TabIndex = 7;
            // 
            // txtEngine
            // 
            this.txtEngine.Location = new System.Drawing.Point(423, 318);
            this.txtEngine.Name = "txtEngine";
            this.txtEngine.Size = new System.Drawing.Size(235, 27);
            this.txtEngine.TabIndex = 8;
            // 
            // txtCategorie
            // 
            this.txtCategorie.Location = new System.Drawing.Point(423, 445);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(235, 27);
            this.txtCategorie.TabIndex = 9;
            // 
            // txtTraction
            // 
            this.txtTraction.Location = new System.Drawing.Point(423, 539);
            this.txtTraction.Name = "txtTraction";
            this.txtTraction.Size = new System.Drawing.Size(235, 27);
            this.txtTraction.TabIndex = 10;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(423, 840);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(120, 41);
            this.btnDisplay.TabIndex = 12;
            this.btnDisplay.Text = "Afisare";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblReset
            // 
            this.lblReset.Location = new System.Drawing.Point(554, 840);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(104, 41);
            this.lblReset.TabIndex = 13;
            this.lblReset.Text = "Reset Button";
            this.lblReset.UseVisualStyleBackColor = true;
            this.lblReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(463, 659);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(137, 20);
            this.lblDisplay.TabIndex = 14;
            this.lblDisplay.Text = "Afisare Configurare";
            this.lblDisplay.Visible = false;
            this.lblDisplay.Click += new System.EventHandler(this.lblDisplay_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(423, 629);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(235, 27);
            this.txtPrice.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 950);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblReset);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTraction);
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.txtEngine);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtCar);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblTraction);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblMotor);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblCarName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarName;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMotor;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblTraction;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.TextBox txtCar;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtEngine;
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.TextBox txtTraction;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button lblReset;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.TextBox txtPrice;
    }
}

