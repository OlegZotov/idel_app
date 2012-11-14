﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpecialControls {
  public class OpacityTextBox : TextBox {
    public OpacityTextBox() {
      Margin = new Padding(ConstControls.CONTROL_INDENT_SMALL);
    }

    public enum ControlIndent { None, Small, Middle, Big, VeryBig };

    private ControlIndent indent = ControlIndent.None;
    public ControlIndent Indent {
      get {
        return indent;
      }
      set {
        indent = value;
        if (indent == ControlIndent.None) {
          this.Margin = new Padding(0);
          return;
        }
        if (indent == ControlIndent.Small) {
          this.Margin = new Padding(ConstControls.CONTROL_INDENT_SMALL);
          return;
        }
        if (indent == ControlIndent.Middle) {
          this.Margin = new Padding(ConstControls.CONTROL_INDENT_MIDDLE);
          return;
        }
        if (indent == ControlIndent.Big) {
          this.Margin = new Padding(ConstControls.CONTROL_INDENT_BIG);
        }
        if (indent == ControlIndent.VeryBig) {
          this.Margin = new Padding(ConstControls.CONTROL_INDENT_VERY_BIG);
        }
      }
    }
  }
}