using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpRPC
{
    public partial class MessageShow : Form
    {
        public static MessageShow instance;
        public MessageShow()
        {
            InitializeComponent();
            instance = this;
        }

        public void Show(string msg)
        {
            message.Text = msg;
        }
    }
}
