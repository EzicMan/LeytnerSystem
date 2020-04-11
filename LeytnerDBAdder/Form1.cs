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

namespace LeytnerDBAdder
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
        List<Question> q = new List<Question>();
        String path = "";
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox1.Enabled = false;
            qBox.Enabled = false;
            ansBox.Enabled = false;
            addBut.Enabled = false;
            delBut.Enabled = false;
            сохранитьToolStripMenuItem.Enabled = false;
            сохранитьКакToolStripMenuItem.Enabled = false;
            сброситьToolStripMenuItem1.Enabled = false;
        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "json файлы (*.json)|*.json";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    q.Clear();
                    comboBox1.Enabled = true;
                    qBox.Enabled = true;
                    ansBox.Enabled = true;
                    addBut.Enabled = true;
                    сохранитьToolStripMenuItem.Enabled = true;
                    сохранитьКакToolStripMenuItem.Enabled = true;
                    сброситьToolStripMenuItem1.Enabled = true;
                    path = openFileDialog.FileName;
                    string textFromFile;
                    using (FileStream fstream = File.OpenRead(path))
                    {
                        var reader = new StreamReader(fstream, Encoding.UTF8);
                        textFromFile = reader.ReadToEnd();
                    }
                    q = JsonConvert.DeserializeObject<Question[]>(textFromFile).ToList();
                    loadStart();
                }
            }
        }
        private void loadStart()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("<Новый>");
            comboBox1.SelectedIndex = 0;
            foreach (Question i in q){
                comboBox1.Items.Add(i.Text);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex != 0)
            {
                addBut.Text = "Изменить";
                qBox.Text = q[comboBox1.SelectedIndex - 1].Text;
                ansBox.Text = q[comboBox1.SelectedIndex - 1].Answer;
                delBut.Enabled = true;
            }
            else
            {
                addBut.Text = "Добавить";
                qBox.Text = "";
                ansBox.Text = "";
                delBut.Enabled = false;
            }
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            q.Clear();
            path = "";
            сохранитьToolStripMenuItem.Enabled = true;
            сохранитьКакToolStripMenuItem.Enabled = true;
            сброситьToolStripMenuItem1.Enabled = true;
            comboBox1.Enabled = true;
            qBox.Enabled = true;
            ansBox.Enabled = true;
            addBut.Enabled = true;
            loadStart();
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex != 0)
            {
                int cur = comboBox1.SelectedIndex;
                q[cur - 1] = new Question(qBox.Text, ansBox.Text, q[cur-1].WA);
                comboBox1.Items[cur] = qBox.Text;
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.Items.Add(qBox.Text);
                q.Add(new Question(qBox.Text, ansBox.Text, 0));
                qBox.Text = "";
                ansBox.Text = "";
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path == "")
            {
                сохранитьКакToolStripMenuItem_Click(null, null);
            }
            else
            {
                File.Delete(path);
                using (FileStream fstream = File.OpenWrite(path))
                {
                    var reader = new StreamWriter(fstream, Encoding.UTF8);
                    string json = JsonConvert.SerializeObject(q);
                    reader.Write(json);
                    reader.Close();
                }
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "json files (*.json)|*.json";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                File.Delete(path);
                using (FileStream fstream = File.OpenWrite(path))
                {
                    var reader = new StreamWriter(fstream, Encoding.UTF8);
                    string json = JsonConvert.SerializeObject(q);
                    reader.Write(json);
                    reader.Close();
                }
            }
        }

        private void delBut_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex != 0)
            {
                int cur = comboBox1.SelectedIndex;
                comboBox1.SelectedIndex = 0;
                q.RemoveAt(cur - 1);
                comboBox1.Items.RemoveAt(cur);
                
            }
        }

        private void сброситьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach(Question qu in q)
            {
                qu.WA = 0;
            }
            сохранитьToolStripMenuItem_Click(null, null);
        }
    }
}
