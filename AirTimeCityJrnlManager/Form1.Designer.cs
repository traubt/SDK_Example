namespace SDKSample
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataPath = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.GetInventoryItem = new System.Windows.Forms.Button();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustCode = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUnitP = new System.Windows.Forms.TextBox();
            this.btnSaveSett = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtNewCC = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test SDK Connection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLicense
            // 
            this.txtLicense.Location = new System.Drawing.Point(276, 70);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(128, 20);
            this.txtLicense.TabIndex = 1;
            this.txtLicense.Text = "DK198110007";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "License";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Serial No";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(276, 96);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(128, 20);
            this.txtSerial.TabIndex = 3;
            this.txtSerial.Text = "5635796";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Path";
            // 
            // txtDataPath
            // 
            this.txtDataPath.Location = new System.Drawing.Point(276, 122);
            this.txtDataPath.Name = "txtDataPath";
            this.txtDataPath.Size = new System.Drawing.Size(272, 20);
            this.txtDataPath.TabIndex = 5;
            this.txtDataPath.Text = "H:\\PastelData\\CFATEST";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(144, 317);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(504, 40);
            this.txtResult.TabIndex = 7;
            // 
            // GetInventoryItem
            // 
            this.GetInventoryItem.Location = new System.Drawing.Point(461, 229);
            this.GetInventoryItem.Name = "GetInventoryItem";
            this.GetInventoryItem.Size = new System.Drawing.Size(132, 28);
            this.GetInventoryItem.TabIndex = 8;
            this.GetInventoryItem.Text = "Get Inventory Item";
            this.GetInventoryItem.UseVisualStyleBackColor = true;
            this.GetInventoryItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(332, 234);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(128, 20);
            this.txtItemCode.TabIndex = 10;
            this.txtItemCode.Text = "ACC/LOC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enter Known Item Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Results from Get Item and Get Customer will appear here.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Enter Known Customer Account Code";
            // 
            // txtCustCode
            // 
            this.txtCustCode.Location = new System.Drawing.Point(332, 269);
            this.txtCustCode.Name = "txtCustCode";
            this.txtCustCode.Size = new System.Drawing.Size(128, 20);
            this.txtCustCode.TabIndex = 14;
            this.txtCustCode.Text = "ACK001";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(461, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 28);
            this.button3.TabIndex = 13;
            this.button3.Text = "Get Customer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(599, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "(SDK.GetRecord)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(599, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "(SDK.GetNearest)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(718, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Enter relevant details here and click \"Test SDK Connection\". This is the fist bas" +
    "ic test that the app can connect to the SDK.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(179, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(523, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Enter different values in the 2 textboxes here to test the SDK connection to the " +
    "data itself. ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(461, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 28);
            this.button2.TabIndex = 21;
            this.button2.Text = "Create Sales Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(221, 423);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(66, 20);
            this.txtCode.TabIndex = 22;
            this.txtCode.Text = "ACC/LOC";
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(224, 405);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Item Code";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(164, 405);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Store";
            // 
            // txtStore
            // 
            this.txtStore.Location = new System.Drawing.Point(149, 423);
            this.txtStore.Name = "txtStore";
            this.txtStore.Size = new System.Drawing.Size(66, 20);
            this.txtStore.TabIndex = 24;
            this.txtStore.Text = "005";
            this.txtStore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStore.UseWaitCursor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(316, 405);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Qty";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(293, 423);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(66, 20);
            this.txtQty.TabIndex = 26;
            this.txtQty.Text = "1";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(371, 405);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Unit Price";
            // 
            // txtUnitP
            // 
            this.txtUnitP.Location = new System.Drawing.Point(365, 423);
            this.txtUnitP.Name = "txtUnitP";
            this.txtUnitP.Size = new System.Drawing.Size(66, 20);
            this.txtUnitP.TabIndex = 28;
            this.txtUnitP.Text = "121.45";
            this.txtUnitP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSaveSett
            // 
            this.btnSaveSett.Location = new System.Drawing.Point(410, 148);
            this.btnSaveSett.Name = "btnSaveSett";
            this.btnSaveSett.Size = new System.Drawing.Size(138, 28);
            this.btnSaveSett.TabIndex = 30;
            this.btnSaveSett.Text = "Save Settings";
            this.btnSaveSett.UseVisualStyleBackColor = true;
            this.btnSaveSett.Click += new System.EventHandler(this.btnSaveSett_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(461, 469);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 28);
            this.button4.TabIndex = 31;
            this.button4.Text = "Create New Customer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtNewCC
            // 
            this.txtNewCC.Location = new System.Drawing.Point(216, 477);
            this.txtNewCC.Name = "txtNewCC";
            this.txtNewCC.Size = new System.Drawing.Size(71, 20);
            this.txtNewCC.TabIndex = 32;
            this.txtNewCC.Text = "ACK001";
            this.txtNewCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(204, 458);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "New Customer Code";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 542);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtNewCC);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSaveSett);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtUnitP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtStore);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCustCode);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.GetInventoryItem);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDataPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLicense);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Test Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDataPath;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button GetInventoryItem;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustCode;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUnitP;
        private System.Windows.Forms.Button btnSaveSett;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtNewCC;
        private System.Windows.Forms.Label label15;
    }
}