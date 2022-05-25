namespace SLT_data_balance
{
    partial class main_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.std_usage = new System.Windows.Forms.TextBox();
            this.tot_usage = new System.Windows.Forms.TextBox();
            this.package = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add_package_button = new System.Windows.Forms.Button();
            this.add_package_help = new System.Windows.Forms.ToolTip(this.components);
            this.calculate_button = new System.Windows.Forms.Button();
            this.main_page_error_provider = new System.Windows.Forms.ErrorProvider(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.day_remaining = new System.Windows.Forms.TextBox();
            this.night_remaining = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.main_page_error_provider)).BeginInit();
            this.SuspendLayout();
            // 
            // std_usage
            // 
            this.std_usage.Location = new System.Drawing.Point(130, 44);
            this.std_usage.Name = "std_usage";
            this.std_usage.PlaceholderText = "Standard Usage";
            this.std_usage.Size = new System.Drawing.Size(121, 23);
            this.std_usage.TabIndex = 0;
            this.std_usage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.std_usage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.std_usage_KeyPress);
            // 
            // tot_usage
            // 
            this.tot_usage.Location = new System.Drawing.Point(130, 86);
            this.tot_usage.Name = "tot_usage";
            this.tot_usage.PlaceholderText = "Total Usage";
            this.tot_usage.Size = new System.Drawing.Size(121, 23);
            this.tot_usage.TabIndex = 1;
            this.tot_usage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tot_usage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tot_usage_KeyPress);
            // 
            // package
            // 
            this.package.Cursor = System.Windows.Forms.Cursors.Hand;
            this.package.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.package.FormattingEnabled = true;
            this.package.Items.AddRange(new object[] {
            "Package 1",
            "Package 2",
            "Package 3",
            "Package 4"});
            this.package.Location = new System.Drawing.Point(130, 127);
            this.package.MaxDropDownItems = 20;
            this.package.Name = "package";
            this.package.Size = new System.Drawing.Size(121, 23);
            this.package.TabIndex = 2;
            this.package.MouseClick += new System.Windows.Forms.MouseEventHandler(this.package_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Standard Usage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Usage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "SLT Package";
            // 
            // add_package_button
            // 
            this.add_package_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.add_package_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_package_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.add_package_button.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.add_package_button.Location = new System.Drawing.Point(259, 127);
            this.add_package_button.Name = "add_package_button";
            this.add_package_button.Size = new System.Drawing.Size(22, 23);
            this.add_package_button.TabIndex = 3;
            this.add_package_button.Text = "+";
            this.add_package_button.UseVisualStyleBackColor = false;
            // 
            // calculate_button
            // 
            this.calculate_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculate_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calculate_button.Location = new System.Drawing.Point(81, 178);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(129, 44);
            this.calculate_button.TabIndex = 4;
            this.calculate_button.Text = "&Cacluate";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // main_page_error_provider
            // 
            this.main_page_error_provider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.main_page_error_provider.ContainerControl = this;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Day Remaining";
            // 
            // day_remaining
            // 
            this.day_remaining.Location = new System.Drawing.Point(130, 253);
            this.day_remaining.Name = "day_remaining";
            this.day_remaining.ReadOnly = true;
            this.day_remaining.Size = new System.Drawing.Size(121, 23);
            this.day_remaining.TabIndex = 9;
            this.day_remaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // night_remaining
            // 
            this.night_remaining.Location = new System.Drawing.Point(130, 282);
            this.night_remaining.Name = "night_remaining";
            this.night_remaining.ReadOnly = true;
            this.night_remaining.Size = new System.Drawing.Size(121, 23);
            this.night_remaining.TabIndex = 11;
            this.night_remaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Night Remaining";
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.IndianRed;
            this.clear_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clear_button.FlatAppearance.BorderSize = 0;
            this.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clear_button.Location = new System.Drawing.Point(130, 318);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(121, 23);
            this.clear_button.TabIndex = 12;
            this.clear_button.Text = "C&lear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // main_form
            // 
            this.AcceptButton = this.calculate_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 378);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.night_remaining);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.day_remaining);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.add_package_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.package);
            this.Controls.Add(this.tot_usage);
            this.Controls.Add(this.std_usage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SLT Data Balance";
            ((System.ComponentModel.ISupportInitialize)(this.main_page_error_provider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox std_usage;
        private TextBox tot_usage;
        private ComboBox package;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button add_package_button;
        private ToolTip add_package_help;
        private Button calculate_button;
        private ErrorProvider main_page_error_provider;
        private NotifyIcon notifyIcon1;
        private ColorDialog colorDialog1;
        private TextBox night_remaining;
        private Label label5;
        private TextBox day_remaining;
        private Label label4;
        private Button clear_button;
    }
}