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
    public partial class FrmMaster : Form
    {
        MasterView _m;
        public FrmMaster(MasterView m)
        {
            _m = m;
            InitializeComponent();
            this.bindingSource.DataSource = m;
            this.dateTimePicker.Value = new DateTime(_m.Date.Year,_m.Date.Month,_m.Date.Day);
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker.Value.Year == _m.Date.Year
                && dateTimePicker.Value.Month==_m.Date.Month
                &&dateTimePicker.Value.Day==_m.Date.Day)return;
            _m.Date=
                new DateOnly(dateTimePicker.Value.Year
                , dateTimePicker.Value.Month
                , dateTimePicker.Value.Day);
        }
    }
}
