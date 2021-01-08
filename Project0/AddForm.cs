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
    public partial class AddForm : Form
    {
        public string nameOfSong = String.Empty;
        public string singerOfSong = String.Empty;
        public string durationOfSong = String.Empty;
        public string albumOfSong = String.Empty;
        //инциализация формы добавления\редактирования 
        //с удобным полем времени и добавлении вариантов заполения альбомов
        public AddForm(string[] albums)
        {
            InitializeComponent();
            musicTime.Format = DateTimePickerFormat.Time;
            musicTime.ShowUpDown = true;
            musicTime.Text = "00:00:00";
            for (int i = 0; i < albums.Length; i++)
            {
                AlbumBox.Items.Add(albums[i]);
            }
        }
        //перенесение данных в основную форму с проверкой
        //на пустое поле альбома
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            nameOfSong = NameBox.Text;
            singerOfSong = SingerBox.Text;
            durationOfSong = musicTime.Text;
            if (AlbumBox.Text == "")    
                    albumOfSong = "Single";
            else
                albumOfSong = AlbumBox.Text;
            Close();
        }
        //если выбран один из вариантов уже существующих
        //альбомов, то он остаётся выбраным
        private void AlbumBox_TextChanged(object sender, EventArgs e)
        {
            albumOfSong = AlbumBox.Text;
        }
    }
}
