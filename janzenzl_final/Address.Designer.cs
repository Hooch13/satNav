namespace janzenzl_final {
    partial class Address {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblPage2SelectMethod = new System.Windows.Forms.Label();
            this.btnCity = new System.Windows.Forms.Button();
            this.btnStreetAddress = new System.Windows.Forms.Button();
            this.btnChangeState = new System.Windows.Forms.Button();
            this.txtHoldState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPage2SelectMethod
            // 
            this.lblPage2SelectMethod.AutoSize = true;
            this.lblPage2SelectMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage2SelectMethod.Location = new System.Drawing.Point(122, 184);
            this.lblPage2SelectMethod.Name = "lblPage2SelectMethod";
            this.lblPage2SelectMethod.Size = new System.Drawing.Size(273, 17);
            this.lblPage2SelectMethod.TabIndex = 0;
            this.lblPage2SelectMethod.Text = "Select a method to search for an address:";
            // 
            // btnCity
            // 
            this.btnCity.Location = new System.Drawing.Point(125, 204);
            this.btnCity.Name = "btnCity";
            this.btnCity.Size = new System.Drawing.Size(143, 61);
            this.btnCity.TabIndex = 1;
            this.btnCity.Text = "City";
            this.btnCity.UseVisualStyleBackColor = true;
            this.btnCity.Click += new System.EventHandler(this.btnCity_Click);
            // 
            // btnStreetAddress
            // 
            this.btnStreetAddress.Location = new System.Drawing.Point(274, 204);
            this.btnStreetAddress.Name = "btnStreetAddress";
            this.btnStreetAddress.Size = new System.Drawing.Size(143, 61);
            this.btnStreetAddress.TabIndex = 2;
            this.btnStreetAddress.Text = "Street Address";
            this.btnStreetAddress.UseVisualStyleBackColor = true;
            // 
            // btnChangeState
            // 
            this.btnChangeState.Location = new System.Drawing.Point(125, 78);
            this.btnChangeState.Name = "btnChangeState";
            this.btnChangeState.Size = new System.Drawing.Size(143, 61);
            this.btnChangeState.TabIndex = 3;
            this.btnChangeState.Text = "Change State";
            this.btnChangeState.UseVisualStyleBackColor = true;
            this.btnChangeState.Click += new System.EventHandler(this.btnChangeState_Click);
            // 
            // txtHoldState
            // 
            this.txtHoldState.Location = new System.Drawing.Point(285, 99);
            this.txtHoldState.Name = "txtHoldState";
            this.txtHoldState.Size = new System.Drawing.Size(100, 20);
            this.txtHoldState.TabIndex = 4;
            this.txtHoldState.TextChanged += new System.EventHandler(this.txtHoldState_TextChanged);
            // 
            // Address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtHoldState);
            this.Controls.Add(this.btnChangeState);
            this.Controls.Add(this.btnStreetAddress);
            this.Controls.Add(this.btnCity);
            this.Controls.Add(this.lblPage2SelectMethod);
            this.Name = "Address";
            this.Size = new System.Drawing.Size(446, 286);
            this.Load += new System.EventHandler(this.Page2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPage2SelectMethod;
        private System.Windows.Forms.Button btnChangeState;
        public System.Windows.Forms.TextBox txtHoldState;
        public System.Windows.Forms.Button btnCity;
        public System.Windows.Forms.Button btnStreetAddress;
    }
}
