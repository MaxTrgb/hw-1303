using System;
using System.Collections.Generic;
//using System.IO;
//using System.Text.Json;
using System.Windows.Forms;

namespace _0403classTask2
{
    //public class Note
    //{
    //    public string Name { get; set; }
    //    public string Text { get; set; }
    //    public string Date { get; set; }
    //}

    internal class NoteModel
    {
        public void AddNoteToListView(ListView listView, string noteName, string noteText, string date)
        {

            ListViewItem item = new ListViewItem(noteName);
            item.SubItems.Add(noteText);
            item.SubItems.Add(date);


            listView.Items.Add(item);
        }
        public void DeleteNoteFromListView(ListView listView, int index)
        {
            if (index >= 0 && index < listView.Items.Count)
            {
                listView.Items.RemoveAt(index);
            }
        }

        //public void SaveNotesToJson(ListView listView, string filePath)
        //{
        //    List<Note> notes = new List<Note>();

            
        //    foreach (ListViewItem item in listView.Items)
        //    {
        //        string noteName = item.SubItems[0].Text;
        //        string noteText = item.SubItems[1].Text;
        //        string date = item.SubItems[2].Text;

        //        Note note = new Note
        //        {
        //            Name = noteName,
        //            Text = noteText,
        //            Date = date
        //        };

        //        notes.Add(note);
        //    }

        //    string json = JsonSerializer.Serialize(notes);
        //    File.WriteAllText(filePath, json);
        //}
    }
}


