// Decompiled with JetBrains decompiler
// Type: RealHCF_Builder.frmMain
// Assembly: RealHCF Builder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 848789C7-2401-4BD3-A543-CA0682BA649A
// Assembly location: C:\Users\Rasib\Desktop\RealHCF_Builder (admin access).exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RealHCF_Builder
{
  public class frmMain : Form
  {
    private SSToolInfo exeInfo = new SSToolInfo();
    private IContainer components = (IContainer) null;
    private Label lblName;
    private TextBox txtName;
    private Label lblCopyright;
    private TextBox txtCopyright;
    private Label lblExpiry;
    private NumericUpDown nudExpiry;
    private Label lblIcon;
    private Button btnIcon;
    private Label lblLogo;
    private Button btnLogo;
    private PictureBox picLogo;
    private Button btnCompile;
    private Button btnApplications;
    private Label lblApplications;
    private Label lblAbout;

    public frmMain() => this.InitializeComponent();

    private void showError(string msg)
    {
      int num = (int) MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }

    private void btnApplications_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Load Applications zip file.";
      openFileDialog1.Filter = "ZIP Files (*.zip)|*.zip";
      openFileDialog1.CheckFileExists = true;
      using (OpenFileDialog openFileDialog2 = openFileDialog1)
      {
        bool flag = true;
        if (openFileDialog2.ShowDialog() == DialogResult.OK && (flag = openFileDialog2.FileName.EndsWith(".zip")))
          this.exeInfo.ApplicationsPath = openFileDialog2.FileName;
        if (flag)
          return;
        this.showError("Invalid extension");
      }
    }

    private void btnIcon_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select application icon.";
      openFileDialog1.Filter = "Icons (*.ico)|*.ico";
      openFileDialog1.CheckFileExists = true;
      using (OpenFileDialog openFileDialog2 = openFileDialog1)
      {
        bool flag = true;
        if (openFileDialog2.ShowDialog() == DialogResult.OK && (flag = openFileDialog2.FileName.EndsWith(".ico")))
          this.exeInfo.IconPath = openFileDialog2.FileName;
        if (flag)
          return;
        this.showError("Invalid extension");
      }
    }

    private void btnLogo_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Load logo.";
      openFileDialog1.Filter = "PNG Image Files (*.png)|*.png";
      openFileDialog1.CheckFileExists = true;
      using (OpenFileDialog openFileDialog2 = openFileDialog1)
      {
        bool flag = true;
        if (openFileDialog2.ShowDialog() == DialogResult.OK && (flag = openFileDialog2.FileName.EndsWith(".png")))
        {
          this.exeInfo.LogoPath = openFileDialog2.FileName;
          this.picLogo.Image = Image.FromFile(openFileDialog2.FileName);
        }
        if (flag)
          return;
        this.showError("Invalid extension");
      }
    }

    private void btnCompile_Click(object sender, EventArgs e)
    {
      if (this.exeInfo.ApplicationsPath == null)
        this.showError("You must select an icon.");
      else if (this.exeInfo.LogoPath == null)
        this.showError("You must select a logo.");
      else if (this.exeInfo.IconPath == null)
      {
        this.showError("You must select an icon.");
      }
      else
      {
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        saveFileDialog1.Title = "Choose a path to export the exe file.";
        saveFileDialog1.Filter = "Windows Executable Files (*.exe)|*.exe";
        using (SaveFileDialog saveFileDialog2 = saveFileDialog1)
        {
          if (saveFileDialog2.ShowDialog() != DialogResult.OK)
            return;
          this.exeInfo.Name = this.txtName.Text;
          this.exeInfo.Copyright = this.txtCopyright.Text;
          this.exeInfo.Expiry = (int) this.nudExpiry.Value;
          this.exeInfo.Compile(saveFileDialog2.FileName);
        }
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMain));
      this.lblName = new Label();
      this.txtName = new TextBox();
      this.lblCopyright = new Label();
      this.txtCopyright = new TextBox();
      this.lblExpiry = new Label();
      this.nudExpiry = new NumericUpDown();
      this.lblIcon = new Label();
      this.btnIcon = new Button();
      this.lblLogo = new Label();
      this.btnLogo = new Button();
      this.picLogo = new PictureBox();
      this.btnCompile = new Button();
      this.btnApplications = new Button();
      this.lblApplications = new Label();
      this.lblAbout = new Label();
      this.nudExpiry.BeginInit();
      ((ISupportInitialize) this.picLogo).BeginInit();
      this.SuspendLayout();
      this.lblName.AutoSize = true;
      this.lblName.Location = new Point(12, 10);
      this.lblName.Name = "lblName";
      this.lblName.Size = new Size(95, 19);
      this.lblName.TabIndex = 0;
      this.lblName.Text = "Instance name:";
      this.txtName.Location = new Point(16, 33);
      this.txtName.Name = "txtName";
      this.txtName.Size = new Size(261, 25);
      this.txtName.TabIndex = 1;
      this.lblCopyright.AutoSize = true;
      this.lblCopyright.Location = new Point(12, 74);
      this.lblCopyright.Name = "lblCopyright";
      this.lblCopyright.Size = new Size(117, 19);
      this.lblCopyright.TabIndex = 2;
      this.lblCopyright.Text = "Instance copyright:";
      this.txtCopyright.Location = new Point(16, 96);
      this.txtCopyright.Name = "txtCopyright";
      this.txtCopyright.Size = new Size(261, 25);
      this.txtCopyright.TabIndex = 3;
      this.lblExpiry.AutoSize = true;
      this.lblExpiry.Location = new Point(12, 146);
      this.lblExpiry.Name = "lblExpiry";
      this.lblExpiry.Size = new Size(152, 19);
      this.lblExpiry.TabIndex = 4;
      this.lblExpiry.Text = "Expiry Time (in Minutes):";
      this.nudExpiry.Location = new Point(16, 169);
      this.nudExpiry.Maximum = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        0
      });
      this.nudExpiry.Name = "nudExpiry";
      this.nudExpiry.Size = new Size(120, 25);
      this.nudExpiry.TabIndex = 5;
      this.nudExpiry.Value = new Decimal(new int[4]
      {
        20,
        0,
        0,
        0
      });
      this.lblIcon.AutoSize = true;
      this.lblIcon.Location = new Point(12, 215);
      this.lblIcon.Name = "lblIcon";
      this.lblIcon.Size = new Size(36, 19);
      this.lblIcon.TabIndex = 6;
      this.lblIcon.Text = "Icon:";
      this.btnIcon.Location = new Point(16, 237);
      this.btnIcon.Name = "btnIcon";
      this.btnIcon.Size = new Size(51, 25);
      this.btnIcon.TabIndex = 7;
      this.btnIcon.Text = "...";
      this.btnIcon.UseVisualStyleBackColor = true;
      this.btnIcon.Click += new EventHandler(this.btnIcon_Click);
      this.lblLogo.AutoSize = true;
      this.lblLogo.Location = new Point(70, 215);
      this.lblLogo.Name = "lblLogo";
      this.lblLogo.Size = new Size(42, 19);
      this.lblLogo.TabIndex = 8;
      this.lblLogo.Text = "Logo:";
      this.btnLogo.Location = new Point(74, 237);
      this.btnLogo.Name = "btnLogo";
      this.btnLogo.Size = new Size(51, 25);
      this.btnLogo.TabIndex = 9;
      this.btnLogo.Text = "...";
      this.btnLogo.UseVisualStyleBackColor = true;
      this.btnLogo.Click += new EventHandler(this.btnLogo_Click);
      this.picLogo.Location = new Point(213, 215);
      this.picLogo.Name = "picLogo";
      this.picLogo.Size = new Size(64, 64);
      this.picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
      this.picLogo.TabIndex = 10;
      this.picLogo.TabStop = false;
      this.btnCompile.Location = new Point(155, 292);
      this.btnCompile.Name = "btnCompile";
      this.btnCompile.Size = new Size(122, 30);
      this.btnCompile.TabIndex = 11;
      this.btnCompile.Text = "Compile";
      this.btnCompile.UseVisualStyleBackColor = true;
      this.btnCompile.Click += new EventHandler(this.btnCompile_Click);
      this.btnApplications.Location = new Point(226, 167);
      this.btnApplications.Name = "btnApplications";
      this.btnApplications.Size = new Size(51, 25);
      this.btnApplications.TabIndex = 13;
      this.btnApplications.Text = "...";
      this.btnApplications.UseVisualStyleBackColor = true;
      this.btnApplications.Click += new EventHandler(this.btnApplications_Click);
      this.lblApplications.AutoSize = true;
      this.lblApplications.Location = new Point(194, 146);
      this.lblApplications.Name = "lblApplications";
      this.lblApplications.Size = new Size(83, 19);
      this.lblApplications.TabIndex = 12;
      this.lblApplications.Text = "Applications:";
      this.lblAbout.AutoSize = true;
      this.lblAbout.Font = new Font("Segoe UI Light", 7f);
      this.lblAbout.Location = new Point(14, 298);
      this.lblAbout.Name = "lblAbout";
      this.lblAbout.Size = new Size(131, 24);
      this.lblAbout.TabIndex = 14;
      this.lblAbout.Text = "Affilated SaiCo Gaming LTD\r\nCopyright © EVASE 2021.";
      this.AutoScaleDimensions = new SizeF(7f, 17f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(289, 333);
      this.Controls.Add((Control) this.lblAbout);
      this.Controls.Add((Control) this.btnApplications);
      this.Controls.Add((Control) this.lblApplications);
      this.Controls.Add((Control) this.btnCompile);
      this.Controls.Add((Control) this.picLogo);
      this.Controls.Add((Control) this.btnLogo);
      this.Controls.Add((Control) this.lblLogo);
      this.Controls.Add((Control) this.btnIcon);
      this.Controls.Add((Control) this.lblIcon);
      this.Controls.Add((Control) this.nudExpiry);
      this.Controls.Add((Control) this.lblExpiry);
      this.Controls.Add((Control) this.txtCopyright);
      this.Controls.Add((Control) this.lblCopyright);
      this.Controls.Add((Control) this.txtName);
      this.Controls.Add((Control) this.lblName);
      this.Font = new Font("Segoe UI Light", 10f);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(3, 4, 3, 4);
      this.MaximizeBox = false;
      this.MaximumSize = new Size(305, 372);
      this.MinimumSize = new Size(305, 372);
      this.Name = nameof (frmMain);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "SaiCo Tool Builder (Admin)";
      this.nudExpiry.EndInit();
      ((ISupportInitialize) this.picLogo).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
