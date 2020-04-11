using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace LeytnerSystem
{
    public partial class Form1 : Form
    {
        public class Question
        {
            public String Text { get; set; }
            public String Answer { get; set; }
            public int WA { get; set; }
            public Question(String text, String ans, int was)
            {
                Text = text;
                Answer = ans;
                WA = was;
            }
        }
        private int CompareFunc(Question x, Question y)
        {
            if (x.WA > y.WA)
            {
                return -1;
            }
            else if (x.WA == y.WA)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        int cur = -1;
        String pathTo = "";
        List<Question> q = new List<Question>();
        public Form1()
        {
            InitializeComponent();
            ansText.Visible = false;
            comText.Visible = false;
            ansBox.Enabled = false;
            ansBut.Enabled = false;
            nextBut.Enabled = false;
        }

        private void ansBut_Click(object sender, EventArgs e)
        {
            if(!ansBox.Text.Equals(ansText.Text))
            {
                comText.ForeColor = Color.Red;
                comText.Text = "Неправильно!";
                q[cur].WA++;
            }
            else
            {
                comText.ForeColor = Color.Green;
                comText.Text = "Правильный ответ!";
                if (q[cur].WA != 0)
                {
                    q[cur].WA--;
                }
            }
            ansText.Visible = true;
            comText.Visible = true;
            ansBut.Enabled = false;
            ansBox.Enabled = false;
            nextBut.Enabled = true;
        }

        private void nextBut_Click(object sender, EventArgs e)
        {
            cur++;
            if(cur >= q.Count)
            {
                q.Sort(CompareFunc);
                cur = 0;
            }
            questText.Text = q[cur].Text;
            ansText.Text = q[cur].Answer;
            ansBut.Enabled = true;
            ansBox.Enabled = true;
            nextBut.Enabled = false;
            ansBox.Text = "";
            ansText.Visible = false;
            comText.Visible = false;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "json файлы (*.json)|*.json";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    String path = openFileDialog.FileName;
                    pathTo = path;
                    q.Clear();
                    string textFromFile;
                    using (FileStream fstream = File.OpenRead(path))
                    {
                        var reader = new StreamReader(fstream, Encoding.UTF8);
                        textFromFile = reader.ReadToEnd();
                    }
                    q = JsonConvert.DeserializeObject<Question[]>(textFromFile).ToList();
                    q.Sort(CompareFunc);
                    nextBut_Click(null, null);
                }
            }
        }

        private void saveState(object sender, FormClosingEventArgs e)
        {
            if (pathTo != "")
            {
                File.Delete(pathTo);
                using (FileStream fstream = File.OpenWrite(pathTo))
                {
                    var reader = new StreamWriter(fstream, Encoding.UTF8);
                    string json = JsonConvert.SerializeObject(q);
                    reader.Write(json);
                    reader.Close();
                }
            }
        }
    }
}
