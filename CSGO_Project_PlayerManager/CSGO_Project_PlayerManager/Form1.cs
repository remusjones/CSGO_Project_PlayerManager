/* Template: http://forums.dotnetfoundation.org/t/file-headers-and-copyright-statements/1276
 * Copyright (c) .NET Foundation. All rights reserved.  
 * Licensed under the MIT License. See LICENSE file in the project root for full license information.  
 * 
 * This is the official list of the CSGO_Project_PlayerManager project contributors.
 * Names of the original copyright holders (individuals or organizations)
 * should be listed with a '*' in the first column. People who have 
 * contributed from an organization can be listed under the organization
 * that actually holds the copyright for their contributions (see the 
 * Microsoft organization for an example). Those individuals should have
 * their names indented and be marked with a '-'
 * For use within CSGO Project
 * 
 * Developer
 * - Remus Jones
 */

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


namespace CSGO_Project_PlayerManager
{
    public partial class Form1 : Form
    {
        // current settings
        public Image portrait;
        public string portraitDir;
        public string name;
        public string currentTeam;
        public float accuracy;
        public float stamina;
        public int contractCost;
        string dir;

        bool selectedXMLdir = false;

        // Store the teams we wish to use, this could possibly be fetched from a list to simplify.
        List<string> teamList = new List<string> { "Bustralis", "Virtus.show" ,"Skay", "Nati Sincere", "HeavenRaisers",
                                                    "Mortals","G3","Gnatic","NiPS","Cloud99","Solid","RatEsports","Pinguin","Ramagades" };

        public Form1()
        {
            InitializeComponent();
            // set the dropdown list array.
            TeamDropDown.DataSource = teamList;
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            name = _Name.Text;
        }

        private void TeamDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTeam = TeamDropDown.SelectedItem.ToString();
        }

        private void Accuracy_TextChanged(object sender, EventArgs e)
        {
            accuracy = float.Parse(Accuracy.Text);
        }

        private void Stamina_TextChanged(object sender, EventArgs e)
        {
            stamina = float.Parse(Stamina.Text);
        }

        private void Cost_TextChanged(object sender, EventArgs e)
        {
            contractCost = int.Parse(Cost.Text);
        }

        private void CreatePlayer_Click(object sender, EventArgs e)
        {
            // create a new player
            // enrich the player with the data we have selected.
            Player p = new Player();
            p.portraitdir = portraitDir;
            p.name = name;
            p.currentTeam = currentTeam;
            p.accuracy = accuracy;
            p.stamina = stamina;
            p.contractCost = contractCost;
            // try to serialize the player to the directory.
            try
            {
                if (selectedXMLdir)
                    p.SerializePlayer(dir);
            }
            // if there is an error, throw an error box with the exception.
            catch(Exception err)
            {
                MessageBox.Show(err.ToString(), "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XMLSelect_Click(object sender, EventArgs e)
        {
            // create a file box.
            var openFileDialog1 = new System.Windows.Forms.OpenFileDialog();

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
                // set the dir to what the user has selected.
                dir = openFileDialog1.FileName;
        }

        private void PortraitSelect_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new System.Windows.Forms.OpenFileDialog();

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // try to open the image from the file.
                try
                {
                    // store image from the file
                    portrait = Image.FromFile(openFileDialog1.FileName);
                    // set the image
                    PortraitDisplay.Image = portrait;
                    // allow image to fit inside picture box.
                    PortraitDisplay.SizeMode = PictureBoxSizeMode.Zoom;
                    // set the dir.
                    portraitDir = openFileDialog1.FileName;


                }
                catch (Exception err)
                {
                    // if there is an error, throw a message box with the error.
                    MessageBox.Show(err.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // set the dir.
                string dir = openFileDialog1.FileName;
            }
        }
        // juan decimal place only pls, it only a float and it breaks otherwise :o
        private void Accuracy_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check if the input is infact a numeric value.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Stamina_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check if the input is infact a numeric value.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check if the input is infact a numeric value.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
