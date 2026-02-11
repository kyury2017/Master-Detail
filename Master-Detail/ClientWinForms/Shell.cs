using System.ComponentModel;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using ClientWinForms.Http;
using Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ClientWinForms
{
    public partial class Shell : Form
    {
        HttpContext c = new HttpContext();
        List<Model.MasterView?>? bList = new List<Model.MasterView?>();
        public Shell()
        {
            InitializeComponent();
            //this.bindingSource.DataSource = bList;
        }
        private void Busy(bool busy)
        {
            if (busy)
            {
                this.Cursor = Cursors.WaitCursor;
                this.toolStripStatusValue.Text = "Пожождите...";
            }
            else
            {
                this.Cursor = Cursors.Default;
                this.toolStripStatusValue.Text = "Готов";

            }
        }
        private void toolStripBtnReresh_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Busy(true);
            try
            {
                bList = c.LoadMaster();
                this.bindingSource.DataSource = bList;//c.LoadMaster().Result;
                this.bindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Master-Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Busy(false);
            }
        }

        private void toolStripBtnDocAdd_Click(object sender, EventArgs e)
        {
            MasterView m = new MasterView()
            {
                Id = 0,
                Date = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                Sum = 0,
            };
            FrmMaster f = new FrmMaster(m);
            f.Text += " - Новый";
            if (f.ShowDialog() == DialogResult.Cancel) return;
            Cursor = Cursors.WaitCursor;
            Busy(true);
            try
            {
                this.bindingSource.DataSource = c.AddMaster(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Master-Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Busy(false);
            }
        }

        private void toolStripBtnDocEdit_Click(object sender, EventArgs e)
        {
            var m = this.bindingSource.Current as MasterView;
            if (m is null) return;
            var mCopy = new MasterView()
            {
                Id = m.Id,
                Date = m.Date,
                Sum = m.Sum,
                Note = m.Note,
                Number = m.Number,
            };
            FrmMaster f = new FrmMaster(mCopy);
            f.Text += " - Изменение";
            if (f.ShowDialog() == DialogResult.Cancel) return;
            Cursor = Cursors.WaitCursor;
            Busy(true);
            try
            {
                this.bindingSource.DataSource = c.UpdateMaster(mCopy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Master-Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Busy(false);
            }
        }

        private void toolStripBtnDocDel_Click(object sender, EventArgs e)
        {
            var m = this.bindingSource.Current as MasterView;
            if (m is null) return;
            var mCopy = new MasterView()
            {
                Id = m.Id,
                Date = m.Date,
                Sum = m.Sum,
                Note = m.Note,
                Number = m.Number,
            };
            FrmMaster f = new FrmMaster(mCopy);
            f.Text += " - Удаление";

            if (f.ShowDialog() == DialogResult.Cancel) return;
            Cursor = Cursors.WaitCursor;
            Busy(true);
            try
            {
                this.bindingSource.DataSource = c.DeleteMaster(mCopy.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Master-Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Busy(false);
            }
        }

        private void toolStripBtnSpecAdd_Click(object sender, EventArgs e)
        {
            var m = this.bindingSource.Current as MasterView;
            if (m is null) return;
            DetailView d = new DetailView()
            {
                Id = 0,
                MasterViewId = m.Id,
                Sum = 0,
            };
            FrmDetail f = new FrmDetail(d);
            f.Text += " - Новый";
            if (f.ShowDialog() == DialogResult.Cancel) return;
            Cursor = Cursors.WaitCursor;
            Busy(true);
            try
            {
                this.bindingSource.DataSource = c.AddDetail(d);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Master-Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Busy(false);
            }
        }

        private void toolStripBtnSpecEdit_Click(object sender, EventArgs e)
        {
            var m = this.bindingSource.Current as MasterView;
            if (m is null) return;
            var d = this.detailsBindingSource.Current as DetailView;
            if (d is null) return;
            var dCopy = new DetailView()
            {
                Id = d.Id,
                MasterViewId = m.Id,
                Name = d.Name,
                Sum = d.Sum,
            };
            FrmDetail f = new FrmDetail(dCopy);
            f.Text += " - Изменение";
            if (f.ShowDialog() == DialogResult.Cancel) return;
            Cursor = Cursors.WaitCursor;
            Busy(true);
            try
            {
                this.bindingSource.DataSource = c.UpdateDetail(dCopy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Master-Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Busy(false);
            }
        }

        private void toolStripBtnSpecDel_Click(object sender, EventArgs e)
        {
            var d = this.detailsBindingSource.Current as DetailView;
            if (d is null) return;
            var dCopy = new DetailView()
            {
                Id = d.Id,
                MasterViewId = d.MasterViewId,
                 Name = d.Name,
                Sum = d.Sum,
            };
            FrmDetail f = new FrmDetail(dCopy);
            f.Text += " - Удаление";

            if (f.ShowDialog() == DialogResult.Cancel) return;
            Cursor = Cursors.WaitCursor;
            Busy(true);
            try
            {
                this.bindingSource.DataSource = c.DeleteDetail(dCopy.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Master-Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Busy(false);
            }
        }
    }
}
