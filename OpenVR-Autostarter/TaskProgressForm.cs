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

        private void TaskProgressForm_Load(object sender, EventArgs e)
        {

        }

        public void setInfoText(string text)
        {
            labelInfoText.Text = text;
        }
    }
}
