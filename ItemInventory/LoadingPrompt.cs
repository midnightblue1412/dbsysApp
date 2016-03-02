using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemInventory
{
    public partial class LoadingPrompt : Form
    {
        public LoadingPrompt()
        {
            InitializeComponent();
        }

        public LoadingPrompt(string message)
        {
            InitializeComponent();
            disp_message.Text = message;
        }
    }
}
