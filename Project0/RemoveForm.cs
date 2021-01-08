using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project0
{
    public partial class RemoveForm : Form
    {
        public bool checking;
        public RemoveForm(ListViewItem item)
        {
            InitializeComponent();
            question.Text = "Are you sure you want to delete the record:\n" + item.Text + " - " + item.SubItems[1].Text + 
                " (" + item.SubItems[2].Text + ") - " + item.SubItems[3].Text + " ?";
            this.AcceptButton = okRemove;
            this.CancelButton = cancelRemove;
        }
        //потверждение удаления
        private void okRemove_Click(object sender, EventArgs e)
        {
            checking = true;
            Close();
        }
        //отклонение удаления
        private void cancelRemove_Click(object sender, EventArgs e)
        {
            checking = false;
            Close();
        }
    }
}
