using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlaceholderTextBox;

namespace CapaPresentacion
{
    public partial class txt : TextBox
    {
        public txt()
        {
            InitializeComponent();
            this.AutoSize = false;
        }

        public txt(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
