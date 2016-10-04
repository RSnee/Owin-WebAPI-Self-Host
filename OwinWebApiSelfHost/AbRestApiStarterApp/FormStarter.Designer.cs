namespace AbRestApiStarterApp
{
  partial class FormStarter
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.labelBaseAdress = new System.Windows.Forms.Label();
      this.lbStatus = new System.Windows.Forms.Label();
      this.btnStart = new System.Windows.Forms.Button();
      this.btnStop = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.txtBoxPort = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.cmbBoxOk = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtBoxMessage = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtBoxId = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.labelBaseAdress);
      this.groupBox1.Controls.Add(this.lbStatus);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(294, 60);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Server status";
      // 
      // labelBaseAdress
      // 
      this.labelBaseAdress.AutoSize = true;
      this.labelBaseAdress.Location = new System.Drawing.Point(21, 40);
      this.labelBaseAdress.Name = "labelBaseAdress";
      this.labelBaseAdress.Size = new System.Drawing.Size(51, 13);
      this.labelBaseAdress.TabIndex = 3;
      this.labelBaseAdress.Text = "http:/....1";
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
      // btnStart
      // 
      this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnStart.Location = new System.Drawing.Point(12, 223);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(146, 23);
      this.btnStart.TabIndex = 0;
      this.btnStart.Text = "Start server";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // btnStop
      // 
      this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnStop.Location = new System.Drawing.Point(164, 223);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new System.Drawing.Size(142, 23);
      this.btnStop.TabIndex = 1;
      this.btnStop.Text = "Stop server";
      this.btnStop.UseVisualStyleBackColor = true;
      this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.txtBoxPort);
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Location = new System.Drawing.Point(12, 78);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(294, 51);
      this.groupBox2.TabIndex = 6;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Server settings";
      // 
      // txtBoxPort
      // 
      this.txtBoxPort.Location = new System.Drawing.Point(60, 23);
      this.txtBoxPort.Name = "txtBoxPort";
      this.txtBoxPort.Size = new System.Drawing.Size(51, 20);
      this.txtBoxPort.TabIndex = 3;
      this.txtBoxPort.Text = "9090";
      this.txtBoxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(26, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Port";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.cmbBoxOk);
      this.groupBox3.Controls.Add(this.label4);
      this.groupBox3.Controls.Add(this.txtBoxMessage);
      this.groupBox3.Controls.Add(this.label3);
      this.groupBox3.Controls.Add(this.txtBoxId);
      this.groupBox3.Controls.Add(this.label2);
      this.groupBox3.Location = new System.Drawing.Point(12, 135);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(294, 76);
      this.groupBox3.TabIndex = 7;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "PostHandler settings";
      // 
      // cmbBoxOk
      // 
      this.cmbBoxOk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbBoxOk.FormattingEnabled = true;
      this.cmbBoxOk.Items.AddRange(new object[] {
            "true",
            "false"});
      this.cmbBoxOk.Location = new System.Drawing.Point(179, 22);
      this.cmbBoxOk.Name = "cmbBoxOk";
      this.cmbBoxOk.Size = new System.Drawing.Size(109, 21);
      this.cmbBoxOk.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(152, 29);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(21, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Ok";
      // 
      // txtBoxMessage
      // 
      this.txtBoxMessage.Location = new System.Drawing.Point(60, 49);
      this.txtBoxMessage.Name = "txtBoxMessage";
      this.txtBoxMessage.Size = new System.Drawing.Size(228, 20);
      this.txtBoxMessage.TabIndex = 5;
      this.txtBoxMessage.Text = "Hello REST-World!";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 52);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(50, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Message";
      // 
      // txtBoxId
      // 
      this.txtBoxId.Location = new System.Drawing.Point(60, 26);
      this.txtBoxId.Name = "txtBoxId";
      this.txtBoxId.Size = new System.Drawing.Size(86, 20);
      this.txtBoxId.TabIndex = 3;
      this.txtBoxId.Text = "0815";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 29);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(16, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Id";
      // 
      // FormStarter
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(322, 258);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnStop);
      this.Controls.Add(this.btnStart);
      this.Name = "FormStarter";
      this.Text = "AbRestApiStarterApp";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label labelBaseAdress;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Label lbStatus;
    private System.Windows.Forms.Button btnStop;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox txtBoxPort;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.ComboBox cmbBoxOk;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtBoxMessage;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtBoxId;
    private System.Windows.Forms.Label label2;
  }
}

