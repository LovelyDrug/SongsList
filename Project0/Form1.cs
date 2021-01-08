using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project0
{
    public partial class Form1 : Form
    {
        public string name = String.Empty;
        public string singer = String.Empty;
        public string duration = String.Empty;
        public string album = String.Empty;
        public ListViewItem[] music = new ListViewItem[0];
        public Form1()
        {
            InitializeComponent();
        }
        //вызов формы добавления
        private void addButton_Click(object sender, EventArgs e)
        {
            string[] albums = new string[comboBoxAlbums.Items.Count];
            for(int i = 0; i<comboBoxAlbums.Items.Count; i++)
            {
                albums[i] = comboBoxAlbums.Items[i].ToString();
            }
            AddForm dialogForm = new AddForm(albums);
            if (dialogForm.ShowDialog() == DialogResult.OK)
                Application.Run(new AddForm(albums));
            name = dialogForm.nameOfSong;
            singer = dialogForm.singerOfSong;
            duration = dialogForm.durationOfSong;
            album = dialogForm.albumOfSong;
            if (!albums.Contains(album))
                comboBoxAlbums.Items.Add(album);
            if (name == "" || singer == "" || duration == "00:00:00")
                MessageBox.Show("You missed smth.");
            else if (name != "" && singer != "" && duration != "00:00:00")
            {
                if(name != " " && singer != " ")
                {
                    ListViewItem songItem = new ListViewItem(new string[] { "" + name, singer, duration, album });
                    musicList.Items.Add(songItem);
                } 
            }
        }
        //алгоритм сохранения в текстовый файл
        private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Text files(*.txt)|*.txt";
                saveFile.InitialDirectory = Path.Combine(new FileInfo(Application.ExecutablePath).DirectoryName);
                if (saveFile.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = saveFile.FileName;
                using (StreamWriter write = new StreamWriter(filename))
                {
                    for (int i = 0; i < musicList.Items.Count; i++)
                    {
                        await write.WriteLineAsync(musicList.Items[i].Text);
                        await write.WriteLineAsync(musicList.Items[i].SubItems[1].Text);
                        await write.WriteLineAsync(musicList.Items[i].SubItems[2].Text);
                        await write.WriteLineAsync(musicList.Items[i].SubItems[3].Text);
                    }
                }
                music = new ListViewItem[musicList.Items.Count];
                for (int i = 0; i < musicList.Items.Count; i++)
                {
                    music[i] = musicList.Items[i];
                }
        }
        //алгоритм открытия и считывания данных с текстового файла
        private async void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text files(*.txt)|*.txt";
            openFile.InitialDirectory = Path.Combine(new FileInfo(Application.ExecutablePath).DirectoryName);
            if (openFile.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFile.FileName;
            musicList.Items.Clear();
            using (StreamReader read = new StreamReader(filename))
            {
                while (!read.EndOfStream)
                {
                    ListViewItem listItem = new ListViewItem(new string[] {await read.ReadLineAsync(), await read.ReadLineAsync(), await read.ReadLineAsync(), await read.ReadLineAsync() });
                    musicList.Items.Add(listItem);
                }
            }
            int counter = 0;
            for (int i = 0; i < musicList.Items.Count; i++)
            {
                for (int j = 0; j < comboBoxAlbums.Items.Count; j++)
                    if (musicList.Items[i].SubItems[3].Text ==  comboBoxAlbums.Items[j].ToString())
                        counter++;
                if(counter==0)
                    comboBoxAlbums.Items.Add(musicList.Items[i].SubItems[3].Text);
            }
            music = new ListViewItem[musicList.Items.Count];
            for (int i = 0; i < musicList.Items.Count; i++)
            {
                music[i] = musicList.Items[i];
            }
            allAlbums.Checked = true;
        }
        //выбор элемента списка
        private void musicList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                for (int i = 0; i < musicList.Items.Count; i++)
                    if (musicList.Items[i].Bounds.Contains(e.Location))
                    {
                        musicList.ContextMenuStrip = contextMenuStrip1;
                        break;
                    }
        }
        //вызов формы редактирования из контекстного меню
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] albums = new string[comboBoxAlbums.Items.Count];
            for (int i = 0; i < comboBoxAlbums.Items.Count; i++)
            {
                albums[i] = comboBoxAlbums.Items[i].ToString();
            }
            AddForm dialogForm = new AddForm(albums);
            if (dialogForm.ShowDialog() == DialogResult.OK)
                Application.Run(new AddForm(albums));
            name = dialogForm.nameOfSong;
            singer = dialogForm.singerOfSong;
            duration = dialogForm.durationOfSong;
            album = dialogForm.albumOfSong;
            if (!albums.Contains(album))
                comboBoxAlbums.Items.Add(album);
            if (name == "" || singer == "" || duration == "00:00:00")
                MessageBox.Show("Wrong data.");
            if (name != "" && singer != "" && duration != "00:00:00")
            {
                ListViewItem songItem = new ListViewItem(new string[] { "" + name, singer, duration, album });
                musicList.Items.Insert(musicList.SelectedItems[0].Index, songItem);
                musicList.SelectedItems[0].Remove();
            }
        }
        //вызов формы удаления из контекстного меню
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveForm dialogForm = new RemoveForm(musicList.SelectedItems[0]);
            if (dialogForm.ShowDialog() == DialogResult.OK)
                Application.Run(new RemoveForm(musicList.SelectedItems[0]));
            bool choice = dialogForm.checking;
            if (choice)
                musicList.SelectedItems[0].Remove();
        }
        //вызов формы поиска
        private void findButton_Click(object sender, EventArgs e)
        {
            SearchForm find = new SearchForm(music);
            if (find.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new SearchForm(music));
            }
            if (find.res[0] == null)
                MessageBox.Show("There is no such songs.");
            else if (find.res[0] != null)
            {
                ListViewItem[] ect = find.res;
                musicList.Items.Clear();
                for (int i = 0; i < ect.Length; i++)
                {
                    try { musicList.Items.Add(ect[i]); }
                    catch (Exception ex) { }
                }
            }
        }
        //отображение всех элементов в списке
        private void allAlbums_Click(object sender, EventArgs e)
        {
            if (allAlbums.Checked == true)
            {
                musicList.Items.Clear();
                for (int i = 0; i < music.Length; i++)
                {
                    musicList.Items.Add(music[i]);
                }
            }
        }
        //отображение элементов по выбору альбома
        private void byAlbum_Click(object sender, EventArgs e)
        {
            if (comboBoxAlbums.Text == "")
            {
                MessageBox.Show("Select the album to show.");
                allAlbums.Checked = true;
                byAlbum.Checked = false;
            }
            else if (byAlbum.Checked == true)
            {
                string al = comboBoxAlbums.Text;
                musicList.Items.Clear();
                for (int i = 0; i < music.Length; i++)
                {
                    if (music[i].SubItems[3].Text == al)
                        musicList.Items.Add(music[i]);
                }
            }
        }
        //при изменении альбома в парараметрах отображения,
        //список меняется в соответствии параметрпм
        private void comboBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (byAlbum.Checked == true)
            {
                string al = comboBoxAlbums.Text;
                musicList.Items.Clear();
                for (int i = 0; i < music.Length; i++)
                {
                    if (music[i].SubItems[3].Text == al)
                        musicList.Items.Add(music[i]);
                }
            }
        }
    }
}
