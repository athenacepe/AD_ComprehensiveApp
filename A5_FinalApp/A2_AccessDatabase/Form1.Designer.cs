namespace A2_AccessDatabase
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
            this.Confirm = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.QueryOutput = new System.Windows.Forms.TextBox();
            this.QueryInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Profit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AvgProfit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AmtMilk = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DogC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TotalC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LivestockRed = new System.Windows.Forms.TextBox();
            this.JCowTax = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SheepProfit = new System.Windows.Forms.TextBox();
            this.JCowProfit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AvgAge = new System.Windows.Forms.TextBox();
            this.ThresholdInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ThresholdOutput = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // Confirm
            // 
            this.Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.Location = new System.Drawing.Point(254, 461);
            this.Confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(82, 33);
            this.Confirm.TabIndex = 1;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click_1);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(363, 461);
            this.Clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(70, 33);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // QueryOutput
            // 
            this.QueryOutput.Location = new System.Drawing.Point(104, 11);
            this.QueryOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QueryOutput.Multiline = true;
            this.QueryOutput.Name = "QueryOutput";
            this.QueryOutput.ReadOnly = true;
            this.QueryOutput.Size = new System.Drawing.Size(486, 40);
            this.QueryOutput.TabIndex = 2;
            // 
            // QueryInput
            // 
            this.QueryInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryInput.Location = new System.Drawing.Point(188, 21);
            this.QueryInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QueryInput.Name = "QueryInput";
            this.QueryInput.Size = new System.Drawing.Size(90, 22);
            this.QueryInput.TabIndex = 1;
            this.QueryInput.Text = "               ";
            this.QueryInput.TextChanged += new System.EventHandler(this.QueryInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search by ID:";
            // 
            // Tax
            // 
            this.Tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tax.Location = new System.Drawing.Point(441, 24);
            this.Tax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tax.Name = "Tax";
            this.Tax.ReadOnly = true;
            this.Tax.Size = new System.Drawing.Size(150, 22);
            this.Tax.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(337, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tax per month: ";
            // 
            // Profit
            // 
            this.Profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profit.Location = new System.Drawing.Point(154, 24);
            this.Profit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            this.Profit.Size = new System.Drawing.Size(161, 22);
            this.Profit.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Profit/Loose of Farm:";
            // 
            // AvgProfit
            // 
            this.AvgProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvgProfit.Location = new System.Drawing.Point(472, 22);
            this.AvgProfit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AvgProfit.Name = "AvgProfit";
            this.AvgProfit.ReadOnly = true;
            this.AvgProfit.Size = new System.Drawing.Size(118, 22);
            this.AvgProfit.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Average profitability:";
            // 
            // AmtMilk
            // 
            this.AmtMilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmtMilk.Location = new System.Drawing.Point(182, 22);
            this.AmtMilk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AmtMilk.Name = "AmtMilk";
            this.AmtMilk.ReadOnly = true;
            this.AmtMilk.Size = new System.Drawing.Size(133, 22);
            this.AmtMilk.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Amount of Milk (per day):";
            // 
            // DogC
            // 
            this.DogC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DogC.Location = new System.Drawing.Point(104, 16);
            this.DogC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DogC.Name = "DogC";
            this.DogC.ReadOnly = true;
            this.DogC.Size = new System.Drawing.Size(211, 22);
            this.DogC.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Dog Cost:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(337, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Total Cost:";
            // 
            // TotalC
            // 
            this.TotalC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalC.Location = new System.Drawing.Point(420, 18);
            this.TotalC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TotalC.Name = "TotalC";
            this.TotalC.ReadOnly = true;
            this.TotalC.Size = new System.Drawing.Size(170, 22);
            this.TotalC.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Livestock with Red:";
            // 
            // LivestockRed
            // 
            this.LivestockRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivestockRed.Location = new System.Drawing.Point(136, 17);
            this.LivestockRed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LivestockRed.Name = "LivestockRed";
            this.LivestockRed.ReadOnly = true;
            this.LivestockRed.Size = new System.Drawing.Size(161, 22);
            this.LivestockRed.TabIndex = 25;
            // 
            // JCowTax
            // 
            this.JCowTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JCowTax.Location = new System.Drawing.Point(116, 17);
            this.JCowTax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.JCowTax.Name = "JCowTax";
            this.JCowTax.ReadOnly = true;
            this.JCowTax.Size = new System.Drawing.Size(140, 22);
            this.JCowTax.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 20);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Jersy Cow Tax: ";
            // 
            // SheepProfit
            // 
            this.SheepProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SheepProfit.Location = new System.Drawing.Point(451, 17);
            this.SheepProfit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SheepProfit.Name = "SheepProfit";
            this.SheepProfit.ReadOnly = true;
            this.SheepProfit.Size = new System.Drawing.Size(140, 22);
            this.SheepProfit.TabIndex = 34;
            // 
            // JCowProfit
            // 
            this.JCowProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JCowProfit.Location = new System.Drawing.Point(451, 17);
            this.JCowProfit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.JCowProfit.Name = "JCowProfit";
            this.JCowProfit.ReadOnly = true;
            this.JCowProfit.Size = new System.Drawing.Size(140, 22);
            this.JCowProfit.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(325, 17);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 17);
            this.label13.TabIndex = 33;
            this.label13.Text = "Sheep Profitability: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(288, 19);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "Jersy Cow Profitability:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Details:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tax);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Profit);
            this.groupBox1.Location = new System.Drawing.Point(22, 175);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(645, 56);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profit/Loose and Tax of Farm";
            // 
            // AvgAge
            // 
            this.AvgAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvgAge.Location = new System.Drawing.Point(116, 14);
            this.AvgAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AvgAge.Name = "AvgAge";
            this.AvgAge.ReadOnly = true;
            this.AvgAge.Size = new System.Drawing.Size(150, 23);
            this.AvgAge.TabIndex = 12;
            // 
            // ThresholdInput
            // 
            this.ThresholdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThresholdInput.Location = new System.Drawing.Point(422, 21);
            this.ThresholdInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ThresholdInput.Name = "ThresholdInput";
            this.ThresholdInput.Size = new System.Drawing.Size(62, 23);
            this.ThresholdInput.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Average Age:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(325, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Threshold:";
            // 
            // ThresholdOutput
            // 
            this.ThresholdOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThresholdOutput.Location = new System.Drawing.Point(422, 13);
            this.ThresholdOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ThresholdOutput.Name = "ThresholdOutput";
            this.ThresholdOutput.ReadOnly = true;
            this.ThresholdOutput.Size = new System.Drawing.Size(170, 23);
            this.ThresholdOutput.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(297, 15);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 17);
            this.label15.TabIndex = 6;
            this.label15.Text = "Above Threshold: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.QueryInput);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ThresholdInput);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(22, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(645, 54);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Input";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.QueryOutput);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(22, 117);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(645, 53);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details of ID";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AvgProfit);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.AmtMilk);
            this.groupBox4.Location = new System.Drawing.Point(22, 236);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(645, 58);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Amount of Milk and Profit";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DogC);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.TotalC);
            this.groupBox5.Location = new System.Drawing.Point(22, 299);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(645, 47);
            this.groupBox5.TabIndex = 45;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dog Cost vs Daily Cost";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.JCowTax);
            this.groupBox6.Controls.Add(this.JCowProfit);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Location = new System.Drawing.Point(22, 351);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Size = new System.Drawing.Size(645, 47);
            this.groupBox6.TabIndex = 46;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Jersy Cow Profit and Tax";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.SheepProfit);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.LivestockRed);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Location = new System.Drawing.Point(22, 412);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Size = new System.Drawing.Size(645, 45);
            this.groupBox7.TabIndex = 47;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Red Livestock and Sheep Profit";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.ThresholdOutput);
            this.groupBox8.Controls.Add(this.AvgAge);
            this.groupBox8.Location = new System.Drawing.Point(22, 68);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox8.Size = new System.Drawing.Size(645, 44);
            this.groupBox8.TabIndex = 48;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Age";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(696, 517);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Confirm);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "A5 Final App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox QueryOutput;
        private System.Windows.Forms.TextBox QueryInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Profit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AvgProfit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AmtMilk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DogC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TotalC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox LivestockRed;
        private System.Windows.Forms.TextBox JCowTax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox SheepProfit;
        private System.Windows.Forms.TextBox JCowProfit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AvgAge;
        private System.Windows.Forms.TextBox ThresholdInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ThresholdOutput;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
    }
}

