using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace xml_laba
{
    public partial class MainWindow : Form
    {
        private string path = "XMLDataBase.xml";
        public MainWindow()
        {
            InitializeComponent();
            buildBox(BDeveloper, BReleaseDate, BMainGenre, BGameMode, BEngine, BMetascore);

            #region init
            BDeveloper.Enabled = false;
            BReleaseDate.Enabled = false;
            BMainGenre.Enabled = false;
            BEngine.Enabled = false;
            BMetascore.Enabled = false;
            BGameMode.Enabled = false;
            BLINQ.Checked = true;
            #endregion init
        }
        private void buildBox(ComboBox BDeveloper, ComboBox BReleaseDate, ComboBox BMainGenre, ComboBox BGameMode, ComboBox BEngine, ComboBox BMetascore)
        {
            IParse p = new LinqToXML();
            List<Searching> res = p.AnalyzeFile(new Searching(), path);
            List<string> developer   = new List<string>();
            List<string> releaseDate = new List<string>();
            List<string> mainGenre   = new List<string>();
            List<string> gameMode    = new List<string>();
            List<string> engine      = new List<string>();
            List<string> metascore   = new List<string>();
            foreach (Searching e in res)
            {
                if (!developer.  Contains(e.developer))   { developer.Add(e.developer); }
                if (!releaseDate.Contains(e.releaseDate)) { releaseDate.Add(e.releaseDate); }
                if (!mainGenre.  Contains(e.mainGenre))   { mainGenre.Add(e.mainGenre); }
                if (!gameMode.   Contains(e.gameMode))    { gameMode.Add(e.gameMode); }
                if (!engine.     Contains(e.engine))      { engine.Add(e.engine); }
                if (!metascore.  Contains(e.metascore))   { metascore.Add(e.metascore); }
            }
            developer   = developer.  OrderBy(x => x).ToList();
            releaseDate = releaseDate.OrderBy(x => x).ToList();
            mainGenre   = mainGenre.  OrderBy(x => x).ToList();
            gameMode    = gameMode.   OrderBy(x => x).ToList();
            engine      = engine.     OrderBy(x => x).ToList();
            metascore   = metascore.  OrderBy(x => x).ToList();

            BDeveloper.  Items.AddRange(developer.ToArray());
            BReleaseDate.Items.AddRange(releaseDate.ToArray());
            BMainGenre.  Items.AddRange(mainGenre.ToArray());
            BGameMode.   Items.AddRange(gameMode.ToArray());
            BEngine.     Items.AddRange(engine.ToArray());
            BMetascore.  Items.AddRange(metascore.ToArray());
        }

        private Searching MemSearch()
        {
            string[] info = new string[7];
            if (Developer.Checked) info[0]   = Convert.ToString(BDeveloper.Text);
            if (ReleaseDate.Checked) info[1] = Convert.ToString(BReleaseDate.Text);
            if (MainGenre.Checked) info[2]   = Convert.ToString(BMainGenre.Text);
            if (GameMode.Checked) info[3]    = Convert.ToString(BGameMode.Text);
            if (Engine.Checked) info[4]      = Convert.ToString(BEngine.Text);
            if (Metascore.Checked) info[5]   = Convert.ToString(BMetascore.Text);
            Searching MemeSearch = new Searching(info);
            return MemeSearch;
        }
        private void ParsingForXML()
        {
            Searching MTemplate = MemSearch();
            List<Searching> res;
            
            if (BSAX.Checked)
            {
                IParse parse = new SAX();
                res = parse.AnalyzeFile(MTemplate, path);
                Output(res);
            }
            else if (BDOM.Checked)
            {
                IParse parse = new DOM();
                res = parse.AnalyzeFile(MTemplate, path);
                Output(res);
            }
            else if (BLINQ.Checked)
            {
                IParse parse = new LinqToXML();
                res = parse.AnalyzeFile(MTemplate, path);
                Output(res);
            }
        }
        private void Output(List<Searching> res)
        {
            w.Clear();
            foreach(Searching e in res)
            {
                w.AppendText("Name Of The Game: " + e.nameOfTheGame + " \n");
                w.AppendText("Developer: "        + e.developer + " \n");
                w.AppendText("Release Date: "     + e.releaseDate + " \n");
                w.AppendText("Main Genre: "       + e.mainGenre + " \n");
                w.AppendText("Game Mode: "        + e.gameMode + " \n");
                w.AppendText("Engine: "           + e.engine + " \n");
                w.AppendText("Metascore: "        + e.metascore + " \n");
                w.AppendText(" \n");
            }
        }
        private void IntoHTML()
        {
            XslCompiledTransform xsl = new XslCompiledTransform();
            xsl.Load("XSLDataBase.xsl");
            string input = path;
            string result = @"HTMLGameDataBase.html";
            xsl.Transform(input, result);
            MessageBox.Show("Done!");
        }
        private void Clear()
        {
            w.Clear();
            BDOM.Checked  = false;
            BLINQ.Checked = false;
            BSAX.Checked  = false;

            BDeveloper.Text   = null;
            BReleaseDate.Text = null;
            BMainGenre.Text   = null;
            BGameMode.Text    = null;
            BEngine.Text      = null;
            BMetascore.Text   = null;

            Developer.Checked   = false;
            ReleaseDate.Checked = false;
            MainGenre.Checked   = false;
            GameMode.Checked    = false;
            Engine.Checked      = false;
            Metascore.Checked   = false;
        }      
        #region CheckBoxes
        private void Developer_CheckedChanged(object sender, EventArgs e)
        {
            if (Developer.Checked)
            {
                BDeveloper.Enabled = true;
            }
            else
            {
                BDeveloper.Enabled = false;
                BDeveloper.Text = null;
            }
        }

        private void ReleaseDate_CheckedChanged(object sender, EventArgs e)
        {
            if (ReleaseDate.Checked) 
            { 
                BReleaseDate.Enabled = true; 
            }
            else
            { 
                BReleaseDate.Enabled = false;
                BReleaseDate.Text = null;
            }
        }

        private void MainGenre_CheckedChanged(object sender, EventArgs e)
        {
            if (MainGenre.Checked)
            {
                BMainGenre.Enabled = true;
            }
            else
            {
                BMainGenre.Enabled = false;
                BMainGenre.Text = null;
            }
        }

        private void GameMode_CheckedChanged(object sender, EventArgs e)
        {
            if (GameMode.Checked)
            {
                BGameMode.Enabled = true;
            }
            else
            {
                BGameMode.Enabled = false;
                BGameMode.Text = null;
            }
        }

        private void Engine_CheckedChanged(object sender, EventArgs e)
        {
            if (Engine.Checked)
            {
                BEngine.Enabled = true;
            }
            else
            {
                BEngine.Enabled = false;
                BEngine.Text = null;
            }
        }

        private void Metascore_CheckedChanged(object sender, EventArgs e)
        {
            if (Metascore.Checked)
            {
                BMetascore.Enabled = true;
            }
            else
            {
                BMetascore.Enabled = false;
                BMetascore.Text = null;
            }
        }
        #endregion CheckBoxes
        #region Buttons
        private void searchButton_Click(object sender, EventArgs e)
        {
            ParsingForXML();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void transformButton_Click(object sender, EventArgs e)
        {
            IntoHTML();
        }
        private void helpButton_Click(object sender, EventArgs e)
        {
            Form h = new Help();
            h.Show();
        }
        #endregion Buttons

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close the program?","Exit",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {             
                Application.Exit();                
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
