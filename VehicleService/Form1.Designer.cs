
namespace VehicleService
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
            this.bookingsTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.custNametxt = new System.Windows.Forms.TextBox();
            this.custNumtxt = new System.Windows.Forms.TextBox();
            this.datetxt = new System.Windows.Forms.DateTimePicker();
            this.notestxt = new System.Windows.Forms.TextBox();
            this.Vehicle = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.VehicleModeltxt = new System.Windows.Forms.TextBox();
            this.VehicleMaketxt = new System.Windows.Forms.TextBox();
            this.VehicleRegtxt = new System.Windows.Forms.TextBox();
            this.insert_Btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filter_btn = new System.Windows.Forms.Button();
            this.filterDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.displayall_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookingsTable
            // 
            this.bookingsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingsTable.Location = new System.Drawing.Point(12, 301);
            this.bookingsTable.Name = "bookingsTable";
            this.bookingsTable.RowTemplate.Height = 25;
            this.bookingsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookingsTable.Size = new System.Drawing.Size(825, 202);
            this.bookingsTable.TabIndex = 0;
            this.bookingsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookingsTable_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Nova Cond", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(232, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service Booking";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Booking Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Booking notes";
            // 
            // custNametxt
            // 
            this.custNametxt.Location = new System.Drawing.Point(186, 85);
            this.custNametxt.Name = "custNametxt";
            this.custNametxt.Size = new System.Drawing.Size(100, 23);
            this.custNametxt.TabIndex = 6;
            // 
            // custNumtxt
            // 
            this.custNumtxt.Location = new System.Drawing.Point(186, 115);
            this.custNumtxt.Name = "custNumtxt";
            this.custNumtxt.Size = new System.Drawing.Size(100, 23);
            this.custNumtxt.TabIndex = 7;
            // 
            // datetxt
            // 
            this.datetxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetxt.Location = new System.Drawing.Point(186, 155);
            this.datetxt.Name = "datetxt";
            this.datetxt.Size = new System.Drawing.Size(100, 23);
            this.datetxt.TabIndex = 8;
            // 
            // notestxt
            // 
            this.notestxt.Location = new System.Drawing.Point(186, 186);
            this.notestxt.MaxLength = 25;
            this.notestxt.Multiline = true;
            this.notestxt.Name = "notestxt";
            this.notestxt.Size = new System.Drawing.Size(100, 71);
            this.notestxt.TabIndex = 9;
            // 
            // Vehicle
            // 
            this.Vehicle.AutoSize = true;
            this.Vehicle.Location = new System.Drawing.Point(447, 93);
            this.Vehicle.Name = "Vehicle";
            this.Vehicle.Size = new System.Drawing.Size(81, 15);
            this.Vehicle.TabIndex = 10;
            this.Vehicle.Text = "Vehicle Model";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Vehicle Make";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(447, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Vehicle Registration";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // VehicleModeltxt
            // 
            this.VehicleModeltxt.Location = new System.Drawing.Point(598, 90);
            this.VehicleModeltxt.Name = "VehicleModeltxt";
            this.VehicleModeltxt.Size = new System.Drawing.Size(122, 23);
            this.VehicleModeltxt.TabIndex = 13;
            // 
            // VehicleMaketxt
            // 
            this.VehicleMaketxt.Location = new System.Drawing.Point(598, 123);
            this.VehicleMaketxt.Name = "VehicleMaketxt";
            this.VehicleMaketxt.Size = new System.Drawing.Size(122, 23);
            this.VehicleMaketxt.TabIndex = 14;
            // 
            // VehicleRegtxt
            // 
            this.VehicleRegtxt.Location = new System.Drawing.Point(598, 155);
            this.VehicleRegtxt.Name = "VehicleRegtxt";
            this.VehicleRegtxt.Size = new System.Drawing.Size(122, 23);
            this.VehicleRegtxt.TabIndex = 15;
            // 
            // insert_Btn
            // 
            this.insert_Btn.Location = new System.Drawing.Point(33, 272);
            this.insert_Btn.Name = "insert_Btn";
            this.insert_Btn.Size = new System.Drawing.Size(111, 23);
            this.insert_Btn.TabIndex = 16;
            this.insert_Btn.Text = "Create Booking";
            this.insert_Btn.UseVisualStyleBackColor = true;
            this.insert_Btn.Click += new System.EventHandler(this.insert_Btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(159, 272);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(127, 23);
            this.update_btn.TabIndex = 17;
            this.update_btn.Text = "Update Booking";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(303, 272);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(114, 23);
            this.delete_btn.TabIndex = 18;
            this.delete_btn.Text = "Delete Booking";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.filter_btn);
            this.panel1.Controls.Add(this.filterDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(607, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 94);
            this.panel1.TabIndex = 19;
            // 
            // filter_btn
            // 
            this.filter_btn.Location = new System.Drawing.Point(131, 58);
            this.filter_btn.Name = "filter_btn";
            this.filter_btn.Size = new System.Drawing.Size(75, 23);
            this.filter_btn.TabIndex = 2;
            this.filter_btn.Text = "Apply Filter";
            this.filter_btn.UseVisualStyleBackColor = true;
            this.filter_btn.Click += new System.EventHandler(this.filter_btn_Click);
            // 
            // filterDate
            // 
            this.filterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.filterDate.Location = new System.Drawing.Point(6, 33);
            this.filterDate.Name = "filterDate";
            this.filterDate.Size = new System.Drawing.Size(101, 23);
            this.filterDate.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(94, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Filter By Date";
            // 
            // displayall_btn
            // 
            this.displayall_btn.Location = new System.Drawing.Point(447, 272);
            this.displayall_btn.Name = "displayall_btn";
            this.displayall_btn.Size = new System.Drawing.Size(124, 23);
            this.displayall_btn.TabIndex = 20;
            this.displayall_btn.Text = "Display all Bookings";
            this.displayall_btn.UseVisualStyleBackColor = true;
            this.displayall_btn.Click += new System.EventHandler(this.displayall_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(849, 515);
            this.Controls.Add(this.displayall_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.insert_Btn);
            this.Controls.Add(this.VehicleRegtxt);
            this.Controls.Add(this.VehicleMaketxt);
            this.Controls.Add(this.VehicleModeltxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Vehicle);
            this.Controls.Add(this.notestxt);
            this.Controls.Add(this.datetxt);
            this.Controls.Add(this.custNumtxt);
            this.Controls.Add(this.custNametxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookingsTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingsTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bookingsTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox custNametxt;
        private System.Windows.Forms.TextBox custNumtxt;
        private System.Windows.Forms.DateTimePicker datetxt;
        private System.Windows.Forms.TextBox notestxt;
        private System.Windows.Forms.Label Vehicle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox VehicleModeltxt;
        private System.Windows.Forms.TextBox VehicleMaketxt;
        private System.Windows.Forms.TextBox VehicleRegtxt;
        private System.Windows.Forms.Button insert_Btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button filter_btn;
        private System.Windows.Forms.DateTimePicker filterDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button displayall_btn;
    }
}

