namespace DataCollection
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
            Btn_Open = new Button();
            comboBox_SerialPort = new ComboBox();
            label1 = new Label();
            listBox_RawData = new ListBox();
            Btn_Test = new Button();
            Lbl_Count = new Label();
            Lbl_BufCount = new Label();
            SuspendLayout();
            // 
            // Btn_Open
            // 
            Btn_Open.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Open.Location = new Point(329, 17);
            Btn_Open.Name = "Btn_Open";
            Btn_Open.Size = new Size(124, 41);
            Btn_Open.TabIndex = 0;
            Btn_Open.Text = "Open";
            Btn_Open.UseVisualStyleBackColor = true;
            Btn_Open.Click += Btn_Open_Click;
            // 
            // comboBox_SerialPort
            // 
            comboBox_SerialPort.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_SerialPort.FormattingEnabled = true;
            comboBox_SerialPort.Location = new Point(172, 20);
            comboBox_SerialPort.Name = "comboBox_SerialPort";
            comboBox_SerialPort.Size = new Size(151, 33);
            comboBox_SerialPort.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(154, 23);
            label1.TabIndex = 2;
            label1.Text = "Serial Port：";
            // 
            // listBox_RawData
            // 
            listBox_RawData.FormattingEnabled = true;
            listBox_RawData.ItemHeight = 20;
            listBox_RawData.Location = new Point(12, 119);
            listBox_RawData.Name = "listBox_RawData";
            listBox_RawData.Size = new Size(636, 644);
            listBox_RawData.TabIndex = 3;
            // 
            // Btn_Test
            // 
            Btn_Test.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Test.Location = new Point(489, 16);
            Btn_Test.Name = "Btn_Test";
            Btn_Test.Size = new Size(124, 41);
            Btn_Test.TabIndex = 4;
            Btn_Test.Text = "Test";
            Btn_Test.UseVisualStyleBackColor = true;
            Btn_Test.Click += Btn_Test_Click;
            // 
            // Lbl_Count
            // 
            Lbl_Count.AutoSize = true;
            Lbl_Count.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Count.Location = new Point(12, 82);
            Lbl_Count.Name = "Lbl_Count";
            Lbl_Count.Size = new Size(76, 23);
            Lbl_Count.TabIndex = 5;
            Lbl_Count.Text = "count:";
            // 
            // Lbl_BufCount
            // 
            Lbl_BufCount.AutoSize = true;
            Lbl_BufCount.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_BufCount.Location = new Point(190, 82);
            Lbl_BufCount.Name = "Lbl_BufCount";
            Lbl_BufCount.Size = new Size(120, 23);
            Lbl_BufCount.TabIndex = 6;
            Lbl_BufCount.Text = "buf count:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 776);
            Controls.Add(Lbl_BufCount);
            Controls.Add(Lbl_Count);
            Controls.Add(Btn_Test);
            Controls.Add(listBox_RawData);
            Controls.Add(label1);
            Controls.Add(comboBox_SerialPort);
            Controls.Add(Btn_Open);
            Name = "Form1";
            Text = "震動傳感器數據搜集";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Open;
        private ComboBox comboBox_SerialPort;
        private Label label1;
        private ListBox listBox_RawData;
        private Button Btn_Test;
        private Label Lbl_Count;
        private Label Lbl_BufCount;
    }
}
