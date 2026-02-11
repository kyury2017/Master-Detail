using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWinForms
{
    public partial class FrmDetail : Form
    {
        DetailView _d;
        public FrmDetail(DetailView d)
        {
            _d = d;
            InitializeComponent();
            this.bindingSource.DataSource= _d;
        }
    }
}
