namespace janzenzl_final
{
    partial class Results
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMark = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblConfirmDestination = new System.Windows.Forms.Label();
            this.lblFinalNumber = new System.Windows.Forms.Label();
            this.lblFinalStreet = new System.Windows.Forms.Label();
            this.lblFinalCity = new System.Windows.Forms.Label();
            this.lblFinalState = new System.Windows.Forms.Label();
            this.txtHoldMe = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMark
            // 
            this.btnMark.Location = new System.Drawing.Point(42, 236);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(75, 23);
            this.btnMark.TabIndex = 0;
            this.btnMark.Text = "Mark";
            this.btnMark.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(146, 236);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // lblConfirmDestination
            // 
            this.lblConfirmDestination.AutoSize = true;
            this.lblConfirmDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmDestination.Location = new System.Drawing.Point(49, 58);
            this.lblConfirmDestination.Name = "lblConfirmDestination";
            this.lblConfirmDestination.Size = new System.Drawing.Size(172, 24);
            this.lblConfirmDestination.TabIndex = 2;
            this.lblConfirmDestination.Text = "Confirm Destination";
            // 
            // lblFinalNumber
            // 
            this.lblFinalNumber.AutoSize = true;
            this.lblFinalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalNumber.Location = new System.Drawing.Point(141, 334);
            this.lblFinalNumber.Name = "lblFinalNumber";
            this.lblFinalNumber.Size = new System.Drawing.Size(88, 17);
            this.lblFinalNumber.TabIndex = 3;
            this.lblFinalNumber.Text = "FinalNumber";
            this.lblFinalNumber.Visible = false;
            // 
            // lblFinalStreet
            // 
            this.lblFinalStreet.AutoSize = true;
            this.lblFinalStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalStreet.Location = new System.Drawing.Point(220, 334);
            this.lblFinalStreet.Name = "lblFinalStreet";
            this.lblFinalStreet.Size = new System.Drawing.Size(76, 17);
            this.lblFinalStreet.TabIndex = 4;
            this.lblFinalStreet.Text = "FinalStreet";
            this.lblFinalStreet.Visible = false;
            // 
            // lblFinalCity
            // 
            this.lblFinalCity.AutoSize = true;
            this.lblFinalCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalCity.Location = new System.Drawing.Point(126, 399);
            this.lblFinalCity.Name = "lblFinalCity";
            this.lblFinalCity.Size = new System.Drawing.Size(61, 17);
            this.lblFinalCity.TabIndex = 5;
            this.lblFinalCity.Text = "FinalCity";
            this.lblFinalCity.Visible = false;
            // 
            // lblFinalState
            // 
            this.lblFinalState.AutoSize = true;
            this.lblFinalState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalState.Location = new System.Drawing.Point(220, 399);
            this.lblFinalState.Name = "lblFinalState";
            this.lblFinalState.Size = new System.Drawing.Size(71, 17);
            this.lblFinalState.TabIndex = 6;
            this.lblFinalState.Text = "FinalState";
            this.lblFinalState.Visible = false;
            // 
            // txtHoldMe
            // 
            this.txtHoldMe.Location = new System.Drawing.Point(36, 106);
            this.txtHoldMe.Multiline = true;
            this.txtHoldMe.Name = "txtHoldMe";
            this.txtHoldMe.Size = new System.Drawing.Size(199, 87);
            this.txtHoldMe.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::janzenzl_final.Properties.Resources.road2;
            this.pictureBox1.Location = new System.Drawing.Point(284, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 287);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtHoldMe);
            this.Controls.Add(this.lblFinalState);
            this.Controls.Add(this.lblFinalCity);
            this.Controls.Add(this.lblFinalStreet);
            this.Controls.Add(this.lblFinalNumber);
            this.Controls.Add(this.lblConfirmDestination);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnMark);
            this.Name = "Results";
            this.Size = new System.Drawing.Size(554, 326);
            this.Load += new System.EventHandler(this.Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblConfirmDestination;
        public System.Windows.Forms.Label lblFinalNumber;
        public System.Windows.Forms.Label lblFinalStreet;
        public System.Windows.Forms.Label lblFinalCity;
        public System.Windows.Forms.Label lblFinalState;
        private System.Windows.Forms.TextBox txtHoldMe;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
