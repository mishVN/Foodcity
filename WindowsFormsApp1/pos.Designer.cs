namespace WindowsFormsApp1
{
    partial class pos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvunitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.butlogin = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcash = new System.Windows.Forms.TextBox();
            this.lblbalance = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.butprint = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lbldisqnty = new System.Windows.Forms.Label();
            this.lblminprice = new System.Windows.Forms.Label();
            this.lblfraction = new System.Windows.Forms.Label();
            this.lblwholesaleprice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblbillnumber = new System.Windows.Forms.Label();
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtvalue = new System.Windows.Forms.TextBox();
            this.cashin = new System.Windows.Forms.Button();
            this.cashout = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.lblavailablebal = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcode,
            this.dgvname,
            this.dgvquantity,
            this.dgvdiscount,
            this.dgvunitprice,
            this.dgvtotal});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1080, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgvcode
            // 
            this.dgvcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcode.HeaderText = "Code";
            this.dgvcode.Name = "dgvcode";
            // 
            // dgvname
            // 
            this.dgvname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvname.HeaderText = "Name";
            this.dgvname.Name = "dgvname";
            // 
            // dgvquantity
            // 
            this.dgvquantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvquantity.HeaderText = "quantity";
            this.dgvquantity.Name = "dgvquantity";
            // 
            // dgvdiscount
            // 
            this.dgvdiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvdiscount.HeaderText = "Discount";
            this.dgvdiscount.Name = "dgvdiscount";
            // 
            // dgvunitprice
            // 
            this.dgvunitprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvunitprice.HeaderText = "Unit Price";
            this.dgvunitprice.Name = "dgvunitprice";
            // 
            // dgvtotal
            // 
            this.dgvtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvtotal.HeaderText = "Total";
            this.dgvtotal.Name = "dgvtotal";
            // 
            // txtcode
            // 
            this.txtcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.Location = new System.Drawing.Point(12, 333);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(155, 24);
            this.txtcode.TabIndex = 1;
            this.txtcode.TextChanged += new System.EventHandler(this.txtcode_TextChanged);
            this.txtcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcode_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(269, 333);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(342, 24);
            this.txtname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(743, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
            // 
            // txtprice
            // 
            this.txtprice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(743, 333);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(155, 24);
            this.txtprice.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Discount";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtdiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscount.Location = new System.Drawing.Point(269, 393);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.ReadOnly = true;
            this.txtdiscount.Size = new System.Drawing.Size(155, 24);
            this.txtdiscount.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity";
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(12, 393);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(155, 24);
            this.txtquantity.TabIndex = 1;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            this.txtquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantity_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(746, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total";
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(746, 393);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(155, 24);
            this.txttotal.TabIndex = 11;
            // 
            // butlogin
            // 
            this.butlogin.BackColor = System.Drawing.Color.PaleGreen;
            this.butlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butlogin.Location = new System.Drawing.Point(211, 20);
            this.butlogin.Name = "butlogin";
            this.butlogin.Size = new System.Drawing.Size(110, 50);
            this.butlogin.TabIndex = 4;
            this.butlogin.Text = "Add";
            this.butlogin.UseVisualStyleBackColor = false;
            this.butlogin.Click += new System.EventHandler(this.butlogin_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(918, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(980, 496);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(41, 18);
            this.lbltotal.TabIndex = 15;
            this.lbltotal.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(892, 521);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Discount";
            // 
            // lbldiscount
            // 
            this.lbldiscount.AutoSize = true;
            this.lbldiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscount.Location = new System.Drawing.Point(980, 521);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(67, 18);
            this.lbldiscount.TabIndex = 17;
            this.lbldiscount.Text = "Discount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(916, 580);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 18);
            this.label12.TabIndex = 18;
            this.label12.Text = "Cash";
            // 
            // txtcash
            // 
            this.txtcash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcash.Location = new System.Drawing.Point(980, 580);
            this.txtcash.Name = "txtcash";
            this.txtcash.Size = new System.Drawing.Size(107, 24);
            this.txtcash.TabIndex = 3;
            this.txtcash.TextChanged += new System.EventHandler(this.txtcash_TextChanged);
            this.txtcash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcash_KeyPress);
            // 
            // lblbalance
            // 
            this.lblbalance.AutoSize = true;
            this.lblbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalance.Location = new System.Drawing.Point(980, 612);
            this.lblbalance.Name = "lblbalance";
            this.lblbalance.Size = new System.Drawing.Size(61, 18);
            this.lblbalance.TabIndex = 21;
            this.lblbalance.Text = "Balance";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(898, 612);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 18);
            this.label13.TabIndex = 20;
            this.label13.Text = "Balance";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(413, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Process(ESC)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butprint
            // 
            this.butprint.BackColor = System.Drawing.Color.PaleGreen;
            this.butprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butprint.Location = new System.Drawing.Point(618, 20);
            this.butprint.Name = "butprint";
            this.butprint.Size = new System.Drawing.Size(110, 50);
            this.butprint.TabIndex = 6;
            this.butprint.Text = "Print";
            this.butprint.UseVisualStyleBackColor = false;
            this.butprint.Click += new System.EventHandler(this.butprint_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(21, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 50);
            this.button3.TabIndex = 0;
            this.button3.Text = "New Bill";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(71, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 25);
            this.label14.TabIndex = 26;
            this.label14.Text = "Sign Off";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // lbldisqnty
            // 
            this.lbldisqnty.AutoSize = true;
            this.lbldisqnty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisqnty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbldisqnty.Location = new System.Drawing.Point(566, 388);
            this.lbldisqnty.Name = "lbldisqnty";
            this.lbldisqnty.Size = new System.Drawing.Size(0, 22);
            this.lbldisqnty.TabIndex = 27;
            // 
            // lblminprice
            // 
            this.lblminprice.AutoSize = true;
            this.lblminprice.ForeColor = System.Drawing.SystemColors.Control;
            this.lblminprice.Location = new System.Drawing.Point(16, 469);
            this.lblminprice.Name = "lblminprice";
            this.lblminprice.Size = new System.Drawing.Size(41, 13);
            this.lblminprice.TabIndex = 28;
            this.lblminprice.Text = "label15";
            // 
            // lblfraction
            // 
            this.lblfraction.AutoSize = true;
            this.lblfraction.ForeColor = System.Drawing.SystemColors.Control;
            this.lblfraction.Location = new System.Drawing.Point(69, 436);
            this.lblfraction.Name = "lblfraction";
            this.lblfraction.Size = new System.Drawing.Size(52, 13);
            this.lblfraction.TabIndex = 29;
            this.lblfraction.Text = "lblfraction";
            // 
            // lblwholesaleprice
            // 
            this.lblwholesaleprice.AutoSize = true;
            this.lblwholesaleprice.ForeColor = System.Drawing.SystemColors.Control;
            this.lblwholesaleprice.Location = new System.Drawing.Point(69, 469);
            this.lblwholesaleprice.Name = "lblwholesaleprice";
            this.lblwholesaleprice.Size = new System.Drawing.Size(41, 13);
            this.lblwholesaleprice.TabIndex = 30;
            this.lblwholesaleprice.Text = "label15";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.images1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(479, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 34);
            this.label8.TabIndex = 31;
            this.label8.Text = "Wholesale\r\nPrice";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(905, 470);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 18);
            this.label10.TabIndex = 32;
            this.label10.Text = "Bill No.";
            // 
            // lblbillnumber
            // 
            this.lblbillnumber.AutoSize = true;
            this.lblbillnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbillnumber.Location = new System.Drawing.Point(981, 469);
            this.lblbillnumber.Name = "lblbillnumber";
            this.lblbillnumber.Size = new System.Drawing.Size(28, 18);
            this.lblbillnumber.TabIndex = 33;
            this.lblbillnumber.Text = "No";
            // 
            // txtcustomer
            // 
            this.txtcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomer.Location = new System.Drawing.Point(980, 547);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(107, 24);
            this.txtcustomer.TabIndex = 34;
            this.txtcustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcustomer_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(832, 550);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 18);
            this.label11.TabIndex = 35;
            this.label11.Text = "Customer Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblavailablebal);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.cashout);
            this.panel1.Controls.Add(this.cashin);
            this.panel1.Controls.Add(this.txtvalue);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.butlogin);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.butprint);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(2, 486);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 195);
            this.panel1.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(277, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 22);
            this.label15.TabIndex = 37;
            this.label15.Text = "Cash Value";
            // 
            // txtvalue
            // 
            this.txtvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalue.Location = new System.Drawing.Point(280, 151);
            this.txtvalue.Name = "txtvalue";
            this.txtvalue.Size = new System.Drawing.Size(164, 27);
            this.txtvalue.TabIndex = 37;
            // 
            // cashin
            // 
            this.cashin.BackColor = System.Drawing.Color.PaleGreen;
            this.cashin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cashin.Location = new System.Drawing.Point(467, 117);
            this.cashin.Name = "cashin";
            this.cashin.Size = new System.Drawing.Size(139, 32);
            this.cashin.TabIndex = 38;
            this.cashin.Text = "IN";
            this.cashin.UseVisualStyleBackColor = false;
            this.cashin.Click += new System.EventHandler(this.cashin_Click);
            // 
            // cashout
            // 
            this.cashout.BackColor = System.Drawing.Color.PaleGreen;
            this.cashout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cashout.Location = new System.Drawing.Point(467, 152);
            this.cashout.Name = "cashout";
            this.cashout.Size = new System.Drawing.Size(139, 32);
            this.cashout.TabIndex = 39;
            this.cashout.Text = "OUT";
            this.cashout.UseVisualStyleBackColor = false;
            this.cashout.Click += new System.EventHandler(this.cashout_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(616, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(153, 22);
            this.label16.TabIndex = 41;
            this.label16.Text = "Available Balance";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // lblavailablebal
            // 
            this.lblavailablebal.AutoSize = true;
            this.lblavailablebal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavailablebal.Location = new System.Drawing.Point(617, 154);
            this.lblavailablebal.Name = "lblavailablebal";
            this.lblavailablebal.Size = new System.Drawing.Size(150, 22);
            this.lblavailablebal.TabIndex = 42;
            this.lblavailablebal.Text = "______________";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.ForeColor = System.Drawing.SystemColors.Control;
            this.lblusername.Location = new System.Drawing.Point(813, 617);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(41, 13);
            this.lblusername.TabIndex = 37;
            this.lblusername.Text = "label17";
            // 
            // pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 684);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtcustomer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblbillnumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblwholesaleprice);
            this.Controls.Add(this.lblfraction);
            this.Controls.Add(this.lblminprice);
            this.Controls.Add(this.lbldisqnty);
            this.Controls.Add(this.lblbalance);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtcash);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.pos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button butlogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcash;
        private System.Windows.Forms.Label lblbalance;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butprint;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbldisqnty;
        private System.Windows.Forms.Label lblminprice;
        private System.Windows.Forms.Label lblfraction;
        private System.Windows.Forms.Label lblwholesaleprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvunitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtotal;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblbillnumber;
        private System.Windows.Forms.TextBox txtcustomer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cashout;
        private System.Windows.Forms.Button cashin;
        private System.Windows.Forms.TextBox txtvalue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblavailablebal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblusername;
    }
}