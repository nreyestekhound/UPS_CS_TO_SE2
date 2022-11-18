
namespace UPS.Shipper.ToShipExecFromConnectShip
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCSConnectionString = new System.Windows.Forms.TextBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnMigrate = new System.Windows.Forms.Button();
            this.txtSEAppDB = new System.Windows.Forms.TextBox();
            this.lblAppdb = new System.Windows.Forms.Label();
            this.btnTestSE = new System.Windows.Forms.Button();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ConnectShip Controller - Database connection string:";
            // 
            // txtCSConnectionString
            // 
            this.txtCSConnectionString.Location = new System.Drawing.Point(13, 32);
            this.txtCSConnectionString.Name = "txtCSConnectionString";
            this.txtCSConnectionString.Size = new System.Drawing.Size(694, 23);
            this.txtCSConnectionString.TabIndex = 1;
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(12, 189);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(776, 283);
            this.txtResults.TabIndex = 2;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(713, 31);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnMigrate
            // 
            this.btnMigrate.Location = new System.Drawing.Point(713, 137);
            this.btnMigrate.Name = "btnMigrate";
            this.btnMigrate.Size = new System.Drawing.Size(75, 23);
            this.btnMigrate.TabIndex = 6;
            this.btnMigrate.Text = "Migrate Shippers";
            this.btnMigrate.UseVisualStyleBackColor = true;
            this.btnMigrate.Visible = false;
            this.btnMigrate.Click += new System.EventHandler(this.btnMigrate_Click);
            // 
            // txtSEAppDB
            // 
            this.txtSEAppDB.Location = new System.Drawing.Point(13, 88);
            this.txtSEAppDB.Name = "txtSEAppDB";
            this.txtSEAppDB.Size = new System.Drawing.Size(694, 23);
            this.txtSEAppDB.TabIndex = 5;
            this.txtSEAppDB.Visible = false;
            // 
            // lblAppdb
            // 
            this.lblAppdb.AutoSize = true;
            this.lblAppdb.Location = new System.Drawing.Point(13, 69);
            this.lblAppdb.Name = "lblAppdb";
            this.lblAppdb.Size = new System.Drawing.Size(252, 15);
            this.lblAppdb.TabIndex = 4;
            this.lblAppdb.Text = "ShipExec AppDb - Database connection string:";
            this.lblAppdb.Visible = false;
            // 
            // btnTestSE
            // 
            this.btnTestSE.Location = new System.Drawing.Point(713, 88);
            this.btnTestSE.Name = "btnTestSE";
            this.btnTestSE.Size = new System.Drawing.Size(75, 23);
            this.btnTestSE.TabIndex = 7;
            this.btnTestSE.Text = "Test";
            this.btnTestSE.UseVisualStyleBackColor = true;
            this.btnTestSE.Visible = false;
            this.btnTestSE.Click += new System.EventHandler(this.btnTestSE_Click);
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(13, 137);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(694, 23);
            this.txtCompany.TabIndex = 9;
            this.txtCompany.Visible = false;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(13, 118);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(97, 15);
            this.lblCompany.TabIndex = 8;
            this.lblCompany.Text = "Company Name:";
            this.lblCompany.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.btnTestSE);
            this.Controls.Add(this.btnMigrate);
            this.Controls.Add(this.txtSEAppDB);
            this.Controls.Add(this.lblAppdb);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.txtCSConnectionString);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCSConnectionString;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnMigrate;
        private System.Windows.Forms.TextBox txtSEAppDB;
        private System.Windows.Forms.Label lblAppdb;
        private System.Windows.Forms.Button btnTestSE;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label lblCompany;
    }
}

