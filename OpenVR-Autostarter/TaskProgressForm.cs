using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenVR_Autostarter
{
    public partial class TaskProgressForm : Form
    {
        public TaskProgressForm()
        {
            InitializeComponent();
        }

        public void SetInfoText(string text)
        {
            labelInfoText.Text = text;
        }
    }
}
