namespace gatali
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.AGV1_start_x = new System.Windows.Forms.TextBox();
            this.AGV1_start_y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AGV1_target_y = new System.Windows.Forms.TextBox();
            this.AGV1_target_x = new System.Windows.Forms.TextBox();
            this.AGV1_route_list = new System.Windows.Forms.ListBox();
            this.AGV1_btn_go = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_AGV1_totalRoute = new System.Windows.Forms.Label();
            this.lbl_AGV1_totalY = new System.Windows.Forms.Label();
            this.lbl_AGV1_totalX = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AGV2_btn_go = new System.Windows.Forms.Button();
            this.lbl_AGV2_totalRoute = new System.Windows.Forms.Label();
            this.lbl_AGV2_totalY = new System.Windows.Forms.Label();
            this.lbl_AGV2_totalX = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.AGV2_route_list = new System.Windows.Forms.ListBox();
            this.AGV2_start_x = new System.Windows.Forms.TextBox();
            this.AGV2_start_y = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.AGV2_target_x = new System.Windows.Forms.TextBox();
            this.AGV2_target_y = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // AGV1_start_x
            // 
            this.AGV1_start_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AGV1_start_x.Location = new System.Drawing.Point(97, 38);
            this.AGV1_start_x.Name = "AGV1_start_x";
            this.AGV1_start_x.Size = new System.Drawing.Size(30, 20);
            this.AGV1_start_x.TabIndex = 0;
            this.AGV1_start_x.Text = "3";
            this.AGV1_start_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AGV1_start_y
            // 
            this.AGV1_start_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AGV1_start_y.Location = new System.Drawing.Point(133, 38);
            this.AGV1_start_y.Name = "AGV1_start_y";
            this.AGV1_start_y.Size = new System.Drawing.Size(30, 20);
            this.AGV1_start_y.TabIndex = 1;
            this.AGV1_start_y.Text = "1";
            this.AGV1_start_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(105, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "x0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(142, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "y0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(142, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "y1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(105, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "x1";
            // 
            // AGV1_target_y
            // 
            this.AGV1_target_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AGV1_target_y.Location = new System.Drawing.Point(133, 84);
            this.AGV1_target_y.Name = "AGV1_target_y";
            this.AGV1_target_y.Size = new System.Drawing.Size(30, 20);
            this.AGV1_target_y.TabIndex = 3;
            this.AGV1_target_y.Text = "7";
            this.AGV1_target_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AGV1_target_x
            // 
            this.AGV1_target_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AGV1_target_x.Location = new System.Drawing.Point(97, 84);
            this.AGV1_target_x.Name = "AGV1_target_x";
            this.AGV1_target_x.Size = new System.Drawing.Size(30, 20);
            this.AGV1_target_x.TabIndex = 2;
            this.AGV1_target_x.Text = "5";
            this.AGV1_target_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AGV1_route_list
            // 
            this.AGV1_route_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AGV1_route_list.FormattingEnabled = true;
            this.AGV1_route_list.ItemHeight = 16;
            this.AGV1_route_list.Location = new System.Drawing.Point(26, 19);
            this.AGV1_route_list.Name = "AGV1_route_list";
            this.AGV1_route_list.Size = new System.Drawing.Size(75, 308);
            this.AGV1_route_list.TabIndex = 5;
            // 
            // AGV1_btn_go
            // 
            this.AGV1_btn_go.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AGV1_btn_go.Location = new System.Drawing.Point(111, 97);
            this.AGV1_btn_go.Name = "AGV1_btn_go";
            this.AGV1_btn_go.Size = new System.Drawing.Size(87, 39);
            this.AGV1_btn_go.TabIndex = 8;
            this.AGV1_btn_go.Text = "AGV1";
            this.AGV1_btn_go.UseVisualStyleBackColor = true;
            this.AGV1_btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_AGV1_totalRoute);
            this.groupBox3.Controls.Add(this.lbl_AGV1_totalY);
            this.groupBox3.Controls.Add(this.lbl_AGV1_totalX);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.AGV1_route_list);
            this.groupBox3.Controls.Add(this.AGV1_btn_go);
            this.groupBox3.Location = new System.Drawing.Point(16, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 347);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Route History";
            // 
            // lbl_AGV1_totalRoute
            // 
            this.lbl_AGV1_totalRoute.AutoSize = true;
            this.lbl_AGV1_totalRoute.Location = new System.Drawing.Point(174, 67);
            this.lbl_AGV1_totalRoute.Name = "lbl_AGV1_totalRoute";
            this.lbl_AGV1_totalRoute.Size = new System.Drawing.Size(13, 13);
            this.lbl_AGV1_totalRoute.TabIndex = 8;
            this.lbl_AGV1_totalRoute.Text = "0";
            // 
            // lbl_AGV1_totalY
            // 
            this.lbl_AGV1_totalY.AutoSize = true;
            this.lbl_AGV1_totalY.Location = new System.Drawing.Point(185, 41);
            this.lbl_AGV1_totalY.Name = "lbl_AGV1_totalY";
            this.lbl_AGV1_totalY.Size = new System.Drawing.Size(13, 13);
            this.lbl_AGV1_totalY.TabIndex = 8;
            this.lbl_AGV1_totalY.Text = "0";
            // 
            // lbl_AGV1_totalX
            // 
            this.lbl_AGV1_totalX.AutoSize = true;
            this.lbl_AGV1_totalX.Location = new System.Drawing.Point(185, 19);
            this.lbl_AGV1_totalX.Name = "lbl_AGV1_totalX";
            this.lbl_AGV1_totalX.Size = new System.Drawing.Size(13, 13);
            this.lbl_AGV1_totalX.TabIndex = 8;
            this.lbl_AGV1_totalX.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total Route:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Y route:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total X route:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Start Position";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Target Position";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AGV2_btn_go);
            this.groupBox1.Controls.Add(this.lbl_AGV2_totalRoute);
            this.groupBox1.Controls.Add(this.lbl_AGV2_totalY);
            this.groupBox1.Controls.Add(this.lbl_AGV2_totalX);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.AGV2_route_list);
            this.groupBox1.Location = new System.Drawing.Point(291, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 347);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Route History";
            // 
            // AGV2_btn_go
            // 
            this.AGV2_btn_go.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AGV2_btn_go.Location = new System.Drawing.Point(106, 99);
            this.AGV2_btn_go.Name = "AGV2_btn_go";
            this.AGV2_btn_go.Size = new System.Drawing.Size(92, 37);
            this.AGV2_btn_go.TabIndex = 9;
            this.AGV2_btn_go.Text = "AGV2";
            this.AGV2_btn_go.UseVisualStyleBackColor = true;
            this.AGV2_btn_go.Click += new System.EventHandler(this.AGV2_btn_go_Click);
            // 
            // lbl_AGV2_totalRoute
            // 
            this.lbl_AGV2_totalRoute.AutoSize = true;
            this.lbl_AGV2_totalRoute.Location = new System.Drawing.Point(174, 67);
            this.lbl_AGV2_totalRoute.Name = "lbl_AGV2_totalRoute";
            this.lbl_AGV2_totalRoute.Size = new System.Drawing.Size(13, 13);
            this.lbl_AGV2_totalRoute.TabIndex = 8;
            this.lbl_AGV2_totalRoute.Text = "0";
            // 
            // lbl_AGV2_totalY
            // 
            this.lbl_AGV2_totalY.AutoSize = true;
            this.lbl_AGV2_totalY.Location = new System.Drawing.Point(185, 41);
            this.lbl_AGV2_totalY.Name = "lbl_AGV2_totalY";
            this.lbl_AGV2_totalY.Size = new System.Drawing.Size(13, 13);
            this.lbl_AGV2_totalY.TabIndex = 8;
            this.lbl_AGV2_totalY.Text = "0";
            // 
            // lbl_AGV2_totalX
            // 
            this.lbl_AGV2_totalX.AutoSize = true;
            this.lbl_AGV2_totalX.Location = new System.Drawing.Point(185, 19);
            this.lbl_AGV2_totalX.Name = "lbl_AGV2_totalX";
            this.lbl_AGV2_totalX.Size = new System.Drawing.Size(13, 13);
            this.lbl_AGV2_totalX.TabIndex = 8;
            this.lbl_AGV2_totalX.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(107, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Total Route:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(108, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Total Y route:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(107, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Total X route:";
            // 
            // AGV2_route_list
            // 
            this.AGV2_route_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AGV2_route_list.FormattingEnabled = true;
            this.AGV2_route_list.ItemHeight = 16;
            this.AGV2_route_list.Location = new System.Drawing.Point(26, 19);
            this.AGV2_route_list.Name = "AGV2_route_list";
            this.AGV2_route_list.Size = new System.Drawing.Size(74, 308);
            this.AGV2_route_list.TabIndex = 5;
            // 
            // AGV2_start_x
            // 
            this.AGV2_start_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AGV2_start_x.Location = new System.Drawing.Point(372, 38);
            this.AGV2_start_x.Name = "AGV2_start_x";
            this.AGV2_start_x.Size = new System.Drawing.Size(30, 20);
            this.AGV2_start_x.TabIndex = 4;
            this.AGV2_start_x.Text = "10";
            this.AGV2_start_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AGV2_start_y
            // 
            this.AGV2_start_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AGV2_start_y.Location = new System.Drawing.Point(408, 38);
            this.AGV2_start_y.Name = "AGV2_start_y";
            this.AGV2_start_y.Size = new System.Drawing.Size(30, 20);
            this.AGV2_start_y.TabIndex = 5;
            this.AGV2_start_y.Text = "8";
            this.AGV2_start_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(380, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "x0";
            // 
            // AGV2_target_x
            // 
            this.AGV2_target_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AGV2_target_x.Location = new System.Drawing.Point(372, 84);
            this.AGV2_target_x.Name = "AGV2_target_x";
            this.AGV2_target_x.Size = new System.Drawing.Size(30, 20);
            this.AGV2_target_x.TabIndex = 6;
            this.AGV2_target_x.Text = "4";
            this.AGV2_target_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AGV2_target_y
            // 
            this.AGV2_target_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AGV2_target_y.Location = new System.Drawing.Point(408, 84);
            this.AGV2_target_y.Name = "AGV2_target_y";
            this.AGV2_target_y.Size = new System.Drawing.Size(30, 20);
            this.AGV2_target_y.TabIndex = 7;
            this.AGV2_target_y.Text = "2";
            this.AGV2_target_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(380, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "x1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(417, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "y0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(417, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(18, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "y1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(288, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 13);
            this.label20.TabIndex = 7;
            this.label20.Text = "Start Position";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(288, 87);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 13);
            this.label21.TabIndex = 7;
            this.label21.Text = "Target Position";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Graph";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(546, 84);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(586, 458);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 702);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AGV2_target_y);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.AGV2_target_x);
            this.Controls.Add(this.AGV1_target_y);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.AGV1_target_x);
            this.Controls.Add(this.AGV2_start_y);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AGV2_start_x);
            this.Controls.Add(this.AGV1_start_y);
            this.Controls.Add(this.AGV1_start_x);
            this.Name = "Form1";
            this.Text = "ga_Algortihm";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AGV1_start_x;
        private System.Windows.Forms.TextBox AGV1_start_y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AGV1_target_y;
        private System.Windows.Forms.TextBox AGV1_target_x;
        private System.Windows.Forms.ListBox AGV1_route_list;
        private System.Windows.Forms.Button AGV1_btn_go;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_AGV1_totalY;
        private System.Windows.Forms.Label lbl_AGV1_totalX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_AGV1_totalRoute;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_AGV2_totalRoute;
        private System.Windows.Forms.Label lbl_AGV2_totalY;
        private System.Windows.Forms.Label lbl_AGV2_totalX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox AGV2_route_list;
        private System.Windows.Forms.TextBox AGV2_start_x;
        private System.Windows.Forms.TextBox AGV2_start_y;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox AGV2_target_x;
        private System.Windows.Forms.TextBox AGV2_target_y;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button AGV2_btn_go;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

