namespace WebApiOwinSelfHostStarter
  {
  partial class FormStart
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.labelBase2 = new System.Windows.Forms.Label();
      this.labelBase1 = new System.Windows.Forms.Label();
      this.btnStart = new System.Windows.Forms.Button();
      this.lbStatus = new System.Windows.Forms.Label();
      this.btnStop = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.labelBase2);
      this.groupBox1.Controls.Add(this.labelBase1);
      this.groupBox1.Controls.Add(this.btnStart);
      this.groupBox1.Controls.Add(this.lbStatus);
      this.groupBox1.Controls.Add(this.btnStop);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(294, 108);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Server status";
      // 
      // labelBase2
      // 
      this.labelBase2.AutoSize = true;
      this.labelBase2.Location = new System.Drawing.Point(21, 60);
      this.labelBase2.Name = "labelBase2";
      this.labelBase2.Size = new System.Drawing.Size(51, 13);
      this.labelBase2.TabIndex = 4;
      this.labelBase2.Text = "http:/....2";
      // 
      // labelBase1
      // 
      this.labelBase1.AutoSize = true;
      this.labelBase1.Location = new System.Drawing.Point(21, 40);
      this.labelBase1.Name = "labelBase1";
      this.labelBase1.Size = new System.Drawing.Size(51, 13);
      this.labelBase1.TabIndex = 3;
      this.labelBase1.Text = "http:/....1";
      // 
      // btnStart
      // 
      this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnStart.Location = new System.Drawing.Point(6, 79);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(138, 23);
      this.btnStart.TabIndex = 0;
      this.btnStart.Text = "Start server";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // lbStatus
      // 
      this.lbStatus.AutoSize = true;
      this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbStatus.Location = new System.Drawing.Point(6, 22);
      this.lbStatus.Name = "lbStatus";
      this.lbStatus.Size = new System.Drawing.Size(53, 13);
      this.lbStatus.TabIndex = 2;
      this.lbStatus.Text = "status...";
      // 
      // btnStop
      // 
      this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnStop.Location = new System.Drawing.Point(150, 79);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new System.Drawing.Size(138, 23);
      this.btnStop.TabIndex = 1;
      this.btnStop.Text = "Stop server";
      this.btnStop.UseVisualStyleBackColor = true;
      this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.button1.Location = new System.Drawing.Point(18, 126);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(138, 23);
      this.button1.TabIndex = 5;
      this.button1.Text = "Start server 2";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // FormStart
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(318, 174);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.groupBox1);
      this.Name = "FormStart";
      this.Text = "REST-Server Launcher";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

      }

    #endregion
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Label lbStatus;
    private System.Windows.Forms.Button btnStop;
    private System.Windows.Forms.Label labelBase2;
    private System.Windows.Forms.Label labelBase1;
    private System.Windows.Forms.Button button1;
    }
  }

