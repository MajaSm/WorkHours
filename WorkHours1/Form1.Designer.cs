
namespace WorkHours1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Startlabel = new System.Windows.Forms.Label();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.Endlabel = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.Submitbutton = new System.Windows.Forms.Button();
            this.RemainingHourslabel = new System.Windows.Forms.Label();
            this.RemainingHoursTextBox = new System.Windows.Forms.TextBox();
            this.WorkDonelabel = new System.Windows.Forms.Label();
            this.dateTimeWorkDone = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.RemainingHoursToCurrentTimetextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfAllHoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Startlabel
            // 
            this.Startlabel.AutoSize = true;
            this.Startlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Startlabel.Location = new System.Drawing.Point(98, 57);
            this.Startlabel.Name = "Startlabel";
            this.Startlabel.Size = new System.Drawing.Size(59, 25);
            this.Startlabel.TabIndex = 0;
            this.Startlabel.Text = "Start:";
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeStart.Location = new System.Drawing.Point(163, 57);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.ShowUpDown = true;
            this.dateTimeStart.Size = new System.Drawing.Size(138, 30);
            this.dateTimeStart.TabIndex = 1;
            this.dateTimeStart.Value = new System.DateTime(2021, 10, 15, 9, 0, 0, 0);
            this.dateTimeStart.ValueChanged += new System.EventHandler(this.dateTimeStart_ValueChanged);
            // 
            // Endlabel
            // 
            this.Endlabel.AutoSize = true;
            this.Endlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Endlabel.Location = new System.Drawing.Point(382, 60);
            this.Endlabel.Name = "Endlabel";
            this.Endlabel.Size = new System.Drawing.Size(53, 25);
            this.Endlabel.TabIndex = 2;
            this.Endlabel.Text = "End:";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeEnd.Location = new System.Drawing.Point(442, 57);
            this.dateTimeEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.ShowUpDown = true;
            this.dateTimeEnd.Size = new System.Drawing.Size(140, 30);
            this.dateTimeEnd.TabIndex = 1;
            this.dateTimeEnd.Value = new System.DateTime(2021, 10, 15, 17, 0, 0, 0);
            this.dateTimeEnd.ValueChanged += new System.EventHandler(this.dateTimeEnd_ValueChanged);
            // 
            // Submitbutton
            // 
            this.Submitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submitbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Submitbutton.Location = new System.Drawing.Point(269, 234);
            this.Submitbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Submitbutton.Name = "Submitbutton";
            this.Submitbutton.Size = new System.Drawing.Size(192, 39);
            this.Submitbutton.TabIndex = 4;
            this.Submitbutton.Text = "CALCULATE TIME";
            this.Submitbutton.UseVisualStyleBackColor = true;
            this.Submitbutton.Click += new System.EventHandler(this.Submitbutton_Click);
            // 
            // RemainingHourslabel
            // 
            this.RemainingHourslabel.AutoSize = true;
            this.RemainingHourslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingHourslabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemainingHourslabel.Location = new System.Drawing.Point(82, 325);
            this.RemainingHourslabel.Name = "RemainingHourslabel";
            this.RemainingHourslabel.Size = new System.Drawing.Size(231, 25);
            this.RemainingHourslabel.TabIndex = 5;
            this.RemainingHourslabel.Text = "Remaining hours at work:";
            // 
            // RemainingHoursTextBox
            // 
            this.RemainingHoursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingHoursTextBox.Location = new System.Drawing.Point(426, 325);
            this.RemainingHoursTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemainingHoursTextBox.Name = "RemainingHoursTextBox";
            this.RemainingHoursTextBox.Size = new System.Drawing.Size(204, 30);
            this.RemainingHoursTextBox.TabIndex = 6;
            // 
            // WorkDonelabel
            // 
            this.WorkDonelabel.AutoSize = true;
            this.WorkDonelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkDonelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WorkDonelabel.Location = new System.Drawing.Point(264, 123);
            this.WorkDonelabel.Name = "WorkDonelabel";
            this.WorkDonelabel.Size = new System.Drawing.Size(197, 25);
            this.WorkDonelabel.TabIndex = 7;
            this.WorkDonelabel.Text = "Work done(in hours):";
            // 
            // dateTimeWorkDone
            // 
            this.dateTimeWorkDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeWorkDone.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeWorkDone.Location = new System.Drawing.Point(289, 170);
            this.dateTimeWorkDone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeWorkDone.Name = "dateTimeWorkDone";
            this.dateTimeWorkDone.ShowUpDown = true;
            this.dateTimeWorkDone.Size = new System.Drawing.Size(146, 30);
            this.dateTimeWorkDone.TabIndex = 1;
            this.dateTimeWorkDone.Value = new System.DateTime(2021, 10, 15, 0, 0, 0, 0);
            this.dateTimeWorkDone.ValueChanged += new System.EventHandler(this.dateTimeWorkDone_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(82, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Remaining hours to current time:";
            // 
            // RemainingHoursToCurrentTimetextBox
            // 
            this.RemainingHoursToCurrentTimetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingHoursToCurrentTimetextBox.Location = new System.Drawing.Point(426, 386);
            this.RemainingHoursToCurrentTimetextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemainingHoursToCurrentTimetextBox.Name = "RemainingHoursToCurrentTimetextBox";
            this.RemainingHoursToCurrentTimetextBox.Size = new System.Drawing.Size(204, 30);
            this.RemainingHoursToCurrentTimetextBox.TabIndex = 9;
            this.RemainingHoursToCurrentTimetextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfAllHoursToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // listOfAllHoursToolStripMenuItem
            // 
            this.listOfAllHoursToolStripMenuItem.Name = "listOfAllHoursToolStripMenuItem";
            this.listOfAllHoursToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.listOfAllHoursToolStripMenuItem.Text = "Open list of hours";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(722, 446);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.RemainingHoursToCurrentTimetextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeWorkDone);
            this.Controls.Add(this.WorkDonelabel);
            this.Controls.Add(this.RemainingHoursTextBox);
            this.Controls.Add(this.RemainingHourslabel);
            this.Controls.Add(this.Submitbutton);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.Endlabel);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.Startlabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "WorkHours";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Startlabel;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label Endlabel;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Button Submitbutton;
        private System.Windows.Forms.Label RemainingHourslabel;
        private System.Windows.Forms.TextBox RemainingHoursTextBox;
        private System.Windows.Forms.Label WorkDonelabel;
        private System.Windows.Forms.DateTimePicker dateTimeWorkDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RemainingHoursToCurrentTimetextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfAllHoursToolStripMenuItem;
    }
}

