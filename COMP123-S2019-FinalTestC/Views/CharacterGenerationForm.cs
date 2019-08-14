using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

/*
 * STUDENT NAME:manal hagos
 * STUDENT ID:301027317
 * DESCRIPTION: This is the main form for the application
 */

namespace COMP123_S2019_FinalTestC.Views
{
    public partial class CharacterGenerationForm : COMP123_S2019_FinalTestC.Views.MasterForm
    {
        public CharacterGenerationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the BackButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        /// <summary>
        /// This is the event handler for the NextButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
            IdentityPage.FirstName.txt;
        }
        List<string> SkillsList;
        private Random randomNumbers = new Random();
        program.Character

        public static System.Reflection.Assembly LoadFile(string path);
        public static string LoadSkills()
        {
            return Program.Skill;
        }

        private void loadSkills(object sender, EventArgs e)
        {
            return Program.Skill;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutBox.Show();
        }
        public static GenerateNames()
        {

        }
    }
}
