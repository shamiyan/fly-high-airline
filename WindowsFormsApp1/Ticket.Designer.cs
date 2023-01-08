
namespace WindowsFormsApp1
{
    partial class Ticket
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
            this.PassengerIDCb = new System.Windows.Forms.ComboBox();
            this.TicketDGV = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.FCodeCb = new System.Windows.Forms.ComboBox();
            this.PIdCb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PAmtTb = new System.Windows.Forms.TextBox();
            this.PPassTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PNatTb = new System.Windows.Forms.TextBox();
            this.Passport = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PNameTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Tid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TicketDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // PassengerIDCb
            // 
            this.PassengerIDCb.FormattingEnabled = true;
            this.PassengerIDCb.Location = new System.Drawing.Point(19, 183);
            this.PassengerIDCb.Name = "PassengerIDCb";
            this.PassengerIDCb.Size = new System.Drawing.Size(194, 21);
            this.PassengerIDCb.TabIndex = 58;
            this.PassengerIDCb.SelectedIndexChanged += new System.EventHandler(this.PassengerIDCb_SelectedIndexChanged);
            this.PassengerIDCb.SelectionChangeCommitted += new System.EventHandler(this.PassengerIDCb_SelectionChangeCommitted);
            // 
            // TicketDGV
            // 
            this.TicketDGV.AllowUserToAddRows = false;
            this.TicketDGV.AllowUserToDeleteRows = false;
            this.TicketDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketDGV.Location = new System.Drawing.Point(23, 342);
            this.TicketDGV.Name = "TicketDGV";
            this.TicketDGV.ReadOnly = true;
            this.TicketDGV.Size = new System.Drawing.Size(552, 187);
            this.TicketDGV.TabIndex = 57;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(179, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 32);
            this.button2.TabIndex = 54;
            this.button2.Text = "Book";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(257, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 32);
            this.button3.TabIndex = 55;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(336, 304);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 32);
            this.button4.TabIndex = 56;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FCodeCb
            // 
            this.FCodeCb.FormattingEnabled = true;
            this.FCodeCb.Items.AddRange(new object[] {
            "Australia",
            "America",
            "Brazil",
            "Dubai",
            "Canada",
            "China",
            "Japan",
            "Turkey",
            "Russia"});
            this.FCodeCb.Location = new System.Drawing.Point(377, 138);
            this.FCodeCb.Name = "FCodeCb";
            this.FCodeCb.Size = new System.Drawing.Size(194, 21);
            this.FCodeCb.TabIndex = 53;
            // 
            // PIdCb
            // 
            this.PIdCb.AutoSize = true;
            this.PIdCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIdCb.Location = new System.Drawing.Point(19, 161);
            this.PIdCb.Name = "PIdCb";
            this.PIdCb.Size = new System.Drawing.Size(103, 20);
            this.PIdCb.TabIndex = 52;
            this.PIdCb.Text = "Passenger Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Flight Code";
            // 
            // PAmtTb
            // 
            this.PAmtTb.Location = new System.Drawing.Point(203, 278);
            this.PAmtTb.Name = "PAmtTb";
            this.PAmtTb.Size = new System.Drawing.Size(194, 20);
            this.PAmtTb.TabIndex = 50;
            // 
            // PPassTb
            // 
            this.PPassTb.Location = new System.Drawing.Point(23, 231);
            this.PPassTb.Name = "PPassTb";
            this.PPassTb.Size = new System.Drawing.Size(194, 20);
            this.PPassTb.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(253, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "Amount";
            // 
            // PNatTb
            // 
            this.PNatTb.Location = new System.Drawing.Point(381, 228);
            this.PNatTb.Name = "PNatTb";
            this.PNatTb.Size = new System.Drawing.Size(194, 20);
            this.PNatTb.TabIndex = 48;
            // 
            // Passport
            // 
            this.Passport.AutoSize = true;
            this.Passport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passport.Location = new System.Drawing.Point(19, 208);
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(72, 20);
            this.Passport.TabIndex = 44;
            this.Passport.Text = "Passport";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Nationality";
            // 
            // PNameTb
            // 
            this.PNameTb.Location = new System.Drawing.Point(381, 184);
            this.PNameTb.Name = "PNameTb";
            this.PNameTb.Size = new System.Drawing.Size(194, 20);
            this.PNameTb.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(377, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Name";
            // 
            // Tid
            // 
            this.Tid.Location = new System.Drawing.Point(19, 138);
            this.Tid.Name = "Tid";
            this.Tid.Size = new System.Drawing.Size(194, 20);
            this.Tid.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Ticket Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(197, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 31);
            this.label2.TabIndex = 40;
            this.label2.Text = "VIEW FLIGHT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(146, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 33);
            this.label1.TabIndex = 39;
            this.label1.Text = "FLY HIGH AIRLINE";
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 551);
            this.Controls.Add(this.PassengerIDCb);
            this.Controls.Add(this.TicketDGV);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.FCodeCb);
            this.Controls.Add(this.PIdCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PAmtTb);
            this.Controls.Add(this.PPassTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PNatTb);
            this.Controls.Add(this.Passport);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PNameTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PassengerIDCb;
        private System.Windows.Forms.DataGridView TicketDGV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox FCodeCb;
        private System.Windows.Forms.Label PIdCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PAmtTb;
        private System.Windows.Forms.TextBox PPassTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PNatTb;
        private System.Windows.Forms.Label Passport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PNameTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Tid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}