﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpecialControls {
  public class DisTextBox : OpacityTextBox {

    private string disText;

    public string DisText {
      get {
        return disText;
      }
      set {
        disText = value;
        Text = value;
      }
    }

    public DisTextBox() {
      Click += new EventHandler(DisTextBox_Click);
      Leave += new EventHandler(DisTextBox_Leave);
      ForeColor = System.Drawing.Color.Gray;
    }

    private void DisTextBox_Leave(object sender, EventArgs e) {
      if (Text == "") {
        Text = disText;
        ForeColor = System.Drawing.Color.Gray;
      }
    }

    private void DisTextBox_Click(object sender, EventArgs e) {
      if (ForeColor == System.Drawing.Color.Gray) {
        Clear();
        ForeColor = System.Drawing.Color.Black;
      }
    }

    public bool NotDisText {
      get {
        return (Text != disText);
      }
    }
  }
}