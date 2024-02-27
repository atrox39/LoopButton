namespace LoopButton
{
  partial class FrmMain
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.BtnMain = new System.Windows.Forms.Button();
      this.MainFrame = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // BtnMain
      // 
      this.BtnMain.Location = new System.Drawing.Point(12, 12);
      this.BtnMain.Name = "BtnMain";
      this.BtnMain.Size = new System.Drawing.Size(160, 40);
      this.BtnMain.TabIndex = 0;
      this.BtnMain.Text = "Hover Me";
      this.BtnMain.UseVisualStyleBackColor = true;
      this.BtnMain.MouseHover += new System.EventHandler(this.BtnMain_MouseHover);
      // 
      // MainFrame
      // 
      this.MainFrame.Tick += new System.EventHandler(this.MainFrame_Tick);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.BtnMain);
      this.Name = "FrmMain";
      this.Text = "Loop Button";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button BtnMain;
    private System.Windows.Forms.Timer MainFrame;
  }
}

