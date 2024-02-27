using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LoopButton
{
  public partial class FrmMain : Form
  {

    private List<Button> buttons = new List<Button>();
    private List<string> buttonDirectionH = new List<string>();
    private List<string> buttonDirectionV = new List<string>();

    private bool firstMovement = true;

    private Button CreateButton(string text, int x, int y)
    {
      Button btn = new Button();
      btn.Text = text;
      btn.Width = 160;
      btn.Height = 40;
      btn.Location = new Point(x, y);
      return btn;
    }

    string BtnMainHDirection = "right";
    string BtnMainVDirection = "bottom";
    private void MoveButton(Button btn, int index = 0, bool isList = false)
    {
      if ((btn.Location.X + btn.Width) >= Width)
      {
        if (!isList)
        {
          BtnMainHDirection = "left";
        }
        else
        {
          buttonDirectionH[index] = "left";
        }
      }
      else if ((btn.Location.X + btn.Width) <= 0)
      {
        if (!isList) BtnMainHDirection = "right";
        else buttonDirectionH[index] = "right";
      }
      if ((btn.Location.Y + btn.Height) >= Height)
      {
        if (!isList)
        {
          BtnMainVDirection = "top";
          if (firstMovement)
          {
            buttons.Add(CreateButton("btn1", 10, 80));
            buttons.Add(CreateButton("btn2", 180, 80));
            buttons.Add(CreateButton("btn3", 350, 80));
            buttonDirectionH.Add("right");
            buttonDirectionH.Add("right");
            buttonDirectionH.Add("right");
            buttonDirectionV.Add("bottom");
            buttonDirectionV.Add("bottom");
            buttonDirectionV.Add("bottom");
            foreach (Button b in buttons)
            {
              Controls.Add(b);
            }
            firstMovement = false;
          }
        }
        else buttonDirectionV[index] = "top";
      }
      else if ((btn.Location.Y + btn.Height) <= 0)
      {
        if (!isList) BtnMainVDirection = "bottom";
        else buttonDirectionV[index] = "bottom";
      }
      if (!isList)
      {
        if (BtnMainHDirection == "right")
        {
          btn.Location = new Point(btn.Location.X + 10, btn.Location.Y);
        }
        else if (BtnMainHDirection == "left")
        {
          btn.Location = new Point(btn.Location.X - 10, btn.Location.Y);
        }
        if (BtnMainVDirection == "bottom")
        {
          btn.Location = new Point(btn.Location.X, btn.Location.Y + 10);
        }
        else if (BtnMainVDirection == "top")
        {
          btn.Location = new Point(btn.Location.X, btn.Location.Y - 10);
        }
      }
      else
      {
        if (buttonDirectionH[index] == "right")
        {
          btn.Location = new Point(btn.Location.X + 10, btn.Location.Y);
        }
        else if (buttonDirectionH[index] == "left")
        {
          btn.Location = new Point(btn.Location.X - 10, btn.Location.Y);
        }
        if (buttonDirectionV[index] == "bottom")
        {
          btn.Location = new Point(btn.Location.X, btn.Location.Y + 10);
        }
        else if (buttonDirectionV[index] == "top")
        {
          btn.Location = new Point(btn.Location.X, btn.Location.Y - 10);
        }
      }
    }

    private void Limit()
    {
      if (BtnMain != null)
      {
        MoveButton(BtnMain);
      }
      if (buttons.Count > 0)
      {
        for (int i = 0;i < buttons.Count; i++)
        {
          MoveButton(buttons[i], i, true);
        }
      }
    }

    public FrmMain()
    {
      InitializeComponent();
      MainFrame.Start();
    }

    private void BtnMain_MouseHover(object sender, EventArgs e)
    {
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
    }

    private void BtnMain_Click(object sender, EventArgs e)
    {
    }

    private void MainFrame_Tick(object sender, EventArgs e)
    {
      Limit();
    }
  }
}
