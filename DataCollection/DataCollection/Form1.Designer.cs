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
            SuspendLayout();
            // 
            // Btn_Open
            // 
            Btn_Open.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Open.Location = new Point(329, 16);
            Btn_Open.Name = "Btn_Open";
            Btn_Open.Size = new Size(124, 39);
            Btn_Open.TabIndex = 0;
            Btn_Open.Text = "Open";
            Btn_Open.UseVisualStyleBackColor = true;
            Btn_Open.Click += Btn_Open_Click;
            // 
            // comboBox_SerialPort
            // 
            comboBox_SerialPort.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_SerialPort.FormattingEnabled = true;
            comboBox_SerialPort.Location = new Point(172, 19);
            comboBox_SerialPort.Name = "comboBox_SerialPort";
            comboBox_SerialPort.Size = new Size(151, 33);
            comboBox_SerialPort.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(154, 23);
            label1.TabIndex = 2;
            label1.Text = "Serial Port：";
            // 
            // listBox_RawData
            // 
            listBox_RawData.FormattingEnabled = true;
            listBox_RawData.ItemHeight = 19;
            listBox_RawData.Location = new Point(12, 113);
            listBox_RawData.Name = "listBox_RawData";
            listBox_RawData.Size = new Size(636, 612);
            listBox_RawData.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 737);
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
    }
}
