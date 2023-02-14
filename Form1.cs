using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoF2Editor
{
    public partial class Form1 : Form
    {
        private Rom romData;
        private string selectedRom;
        private bool justLoadedRom;            // prevents the program to do some things when it loads rom data
        private int previousMonsterIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setFieldsState(false);
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.DialogResult result = this.openFileOpenRom.ShowDialog(this);
                if (result.Equals(System.Windows.Forms.DialogResult.OK))
                {
                    selectedRom = this.openFileOpenRom.FileName;
                    this.Text = "BoF2 Editor - " + selectedRom;
                    //File.Copy(selectedRom, "BoF2Aux.sfc");
                    this.romData = new Rom(selectedRom);
                    this.Text = "BoF2 Editor - " + selectedRom;
                    justLoadedRom = true;
                    setFieldsState(true);


                    loadMonsterList();
                    cbMonsterList.SelectedIndex = 0;
                    previousMonsterIndex = 0;

                    justLoadedRom = false;

                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error loading rom: " + x.ToString());
            }
        }


        /*****************************************************
         * 
         * loadMonsterList
         * 
        *****************************************************/

        private void loadMonsterList()
        {
            cbMonsterList.Items.Clear();
            for (var i = 0; i < Rom.maxMonsters; i++)
            {
                cbMonsterList.Items.Insert(i, this.romData.monsterName[i]);

            }
        }



        /*****************************************************
         * 
         * cbMonsterList_SelectedIndexChanged
         * 
        *****************************************************/

        private void cbMonsterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int monsterIndex = this.cbMonsterList.SelectedIndex;
            if (!justLoadedRom)
            {
                saveMonsterFields();
            }
            loadMonsterFields();

            previousMonsterIndex = this.cbMonsterList.SelectedIndex;
        }



        /*****************************************************
         * 
         * setFieldsState
         * 
        *****************************************************/

        private void setFieldsState(bool value)
        {
            this.cbMonsterList.Enabled = value;
            this.numMonsterHp.Enabled = value;
            this.numMonsterExp.Enabled = value;
            this.numMonsterAtk.Enabled = value;
            this.numMonsterDef.Enabled = value;
            this.numMonsterAgi.Enabled = value;
            this.numMonsterLuk.Enabled = value;
            this.numMonsterMp.Enabled = value;
            this.numMonsterZenny.Enabled = value;
            this.numMonsterDropRate.Enabled = value;
            this.numMonsterItemSet.Enabled = value;
            this.btnMonsterTwiceExp.Enabled = value;
            this.btnMonsterTwiceZenny.Enabled = value;
        }



        /*****************************************************
         * 
         * loadMonsterFields
         * 
        *****************************************************/

        private void loadMonsterFields()
        {
            int monsterIndex = this.cbMonsterList.SelectedIndex;
            System.Diagnostics.Debug.WriteLine(monsterIndex);

            numMonsterHp.Value = this.romData.monsterMaxHP[monsterIndex];
            numMonsterMp.Value = this.romData.monsterMaxMP[monsterIndex];
            numMonsterAtk.Value = this.romData.monsterAtk[monsterIndex];
            numMonsterDef.Value = this.romData.monsterDef[monsterIndex];
            numMonsterAgi.Value = this.romData.monsterAgi[monsterIndex];
            numMonsterLuk.Value = this.romData.monsterLuk[monsterIndex];
            numMonsterExp.Value = this.romData.monsterExp[monsterIndex];
            numMonsterZenny.Value = this.romData.monsterZenny[monsterIndex];
            numMonsterDropRate.Value = this.romData.monsterDropRate[monsterIndex];
            numMonsterItemSet.Value = this.romData.monsterItemSet[monsterIndex];

            txtMonsterBytes.Text = this.romData.getByteStr(monsterIndex);
        }



        /*****************************************************
         * 
         * saveMonsterFields
         * 
        *****************************************************/


        private void saveMonsterFields()
        {
            int monsterIndex = previousMonsterIndex;

            this.romData.monsterMaxHP[monsterIndex] = Convert.ToInt32(numMonsterHp.Value);
            this.romData.monsterMaxMP[monsterIndex] = Convert.ToInt32(numMonsterMp.Value);

            this.romData.monsterAtk[monsterIndex] = Convert.ToInt32(numMonsterAtk.Value);
            this.romData.monsterDef[monsterIndex] = Convert.ToInt32(numMonsterDef.Value);
            this.romData.monsterAgi[monsterIndex] = Convert.ToInt32(numMonsterAgi.Value);
            this.romData.monsterLuk[monsterIndex] = Convert.ToInt32(numMonsterLuk.Value);
            this.romData.monsterExp[monsterIndex] = Convert.ToInt32(numMonsterExp.Value);
            this.romData.monsterZenny[monsterIndex] = Convert.ToInt32(numMonsterZenny.Value);
            this.romData.monsterDropRate[monsterIndex] = Convert.ToInt32(numMonsterDropRate.Value);
            this.romData.monsterItemSet[monsterIndex] = Convert.ToInt32(numMonsterItemSet.Value);

        }


        /*****************************************************
         * 
         * saveToolStripMenuItem_Click
         * 
        *****************************************************/

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveMonsterFields();
            this.romData.SaveData(selectedRom);
            MessageBox.Show("Saved!");
        }




        /*****************************************************
         * 
         * btnMonsterTwiceExp_Click
         * 
        *****************************************************/
        private void btnMonsterTwiceExp_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You're about to double the experience given by EVERY ENEMY in the game. Proceed?",
                "BoF 2 Monster Editor",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.romData.doubleExp();
                MessageBox.Show("Done!");
                loadMonsterFields();
            }

        }

        private void btnMonsterTwiceZenny_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You're about to double the zenny given by EVERY ENEMY in the game. Proceed?",
                "BoF 2 Monster Editor",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.romData.doubleZenny();
                MessageBox.Show("Done!");
                loadMonsterFields();
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.gamefaqs.com/snes/563530-breath-of-fire-ii/faqs/5436");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutWindow = new AboutBox1();
            aboutWindow.Show();
        }
    }
}
