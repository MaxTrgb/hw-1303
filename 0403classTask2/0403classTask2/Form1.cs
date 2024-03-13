using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0403classTask2
{
    public partial class Form1 : Form
    {
        private NoteModel noteModel;
        public Form1()
        {
            InitializeComponent();
            noteModel = new NoteModel();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string noteName = textBox1.Text;
            string noteText = textBox2.Text;
            string date = textBox3.Text;
          
            noteModel.AddNoteToListView(listView1, noteName, noteText, date);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int selectedIndex = listView1.SelectedItems[0].Index;

                noteModel.DeleteNoteFromListView(listView1, selectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a note to delete.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //noteModel.SaveNotesToJson(listView1, "notes.json");
            //MessageBox.Show("Notes saved to notes.json");
        }
    }
}
