using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace lojadalala
{
  partial class AboutCrediario : Form
  {
    public AboutCrediario(FormPrincipal parent)
    {
      InitializeComponent();
      this.MdiParent = parent;
    }

    private void okButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
