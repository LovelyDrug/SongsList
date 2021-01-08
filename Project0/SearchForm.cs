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
    public partial class SearchForm : Form
    {
        //массивы для сортировки и хранения нужных
        //элементов списка
        public ListViewItem[] res = new ListViewItem[0];
        public ListViewItem[] work = new ListViewItem[0];
        //инициализация формы поиска с перенесением
        //списка для сортировки
        public SearchForm(ListViewItem[] music)
        {
            InitializeComponent();
            work = new ListViewItem[music.Length];
            res = new ListViewItem[music.Length];
            for (int i = 0; i<music.Length; i++)
            {
                work[i] = music[i];
            }
            this.AcceptButton = okFind;
            this.CancelButton = cancelButton;
        }
        //если элемент списка проходит проверку по одному из параметров
        //добавляется в новый массив для переноса в основную форму
        private void okFind_Click(object sender, EventArgs e)
        {
            if (textBoxValue.Text == "" || (radioButtonName.Checked == false && radioButtonSinger.Checked == false))
            {
                MessageBox.Show("You didn`t choose type of search or didn`t write smth.");
                return;
            }
            else if(radioButtonName.Checked==true)
            {
                int index = 0;
                for (int i = 0; i < work.Length; i++)
                {
                    if (textBoxValue.Text == work[i].Text)
                    {
                        res[index] = work[i];
                        index++;
                    }
                }
            }
            else if(radioButtonSinger.Checked==true)
            {
                int index = 0;
                for (int i = 0; i < work.Length; i++)
                {
                    if (textBoxValue.Text == work[i].SubItems[1].Text)
                    {
                        res[index] = work[i];
                        index++;
                    }
                }
            }
            Close();
        }
        //кнопка закрытия формы
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
