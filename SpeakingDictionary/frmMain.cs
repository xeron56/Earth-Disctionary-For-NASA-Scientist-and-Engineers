using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Speech.Synthesis;
using System.IO;

namespace SpeakingDictionary
{
    public partial class frmMain : Form
    {

        SpeechSynthesizer reader;

        public frmMain()
        {
            InitializeComponent();
            this.Text = "Dictionary of Earth Science-for NASA SCIENTIST Engineer ";
            lblAppTitle.Text = this.Text.ToUpper();
            LoadDB();
            LoadCategory(cmbTopic);
            reader = new SpeechSynthesizer();
            btnPause.Enabled = false;
            btnResume.Enabled = false;
            btnStop.Enabled = false;
        }

        #region class members

        string conString = "Data Source=" + System.Environment.CurrentDirectory + "\\db\\DictionaryDB.sdf";
        //string conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MD. SHAHIDUL ISLAM\Desktop\SpeakingDictionary\TblDictionaries.mdf;Integrated Security=True";

        //string conString = "Data Source=" + System.Environment.CurrentDirectory + "\\db\\DictionaryDB.mdf";
        string tname = "tblDictionary";
        string sql = "SELECT * FROM tblDictionary";
        string filter = " ORDER BY term";

        SqlCeConnection connection;
        SqlCeDataAdapter adapter;
        DataSet data;

        int maxRows = 0;
        int inc = 0;

        #endregion

        #region class methods

        private void SpeakReader()
        {
            reader.Dispose();
            if ((txtWord.Text != "") && (txtMeaning.Text != ""))
            {
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(txtWord.Text + ". " + txtMeaning.Text);
                lblStatus.Text = "SPEAKING";
                btnPause.Enabled = true;
                btnStop.Enabled = true;
                btnResume.Enabled = false;
                btnSpeak.Enabled = false;
                grbNavigation.Enabled = false;
                grbSearch.Enabled = false;
                grbOptions.Enabled = false;
                reader.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(reader_SpeakCompleted);
            }
        }

        void reader_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            lblStatus.Text = "IDLE";
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            btnResume.Enabled = false;
            btnSpeak.Enabled = true;
            grbOptions.Enabled = true;
            grbNavigation.Enabled = true;
            grbSearch.Enabled = true;
        }

        private void PauseReader()
        {
            if (reader != null)
            {
                reader.Pause();
                lblStatus.Text = "PAUSED";
                btnResume.Enabled = true;
                btnPause.Enabled = false;
            }
        }

        private void ResumeReader()
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Paused)
                {
                    reader.Resume();
                    lblStatus.Text = "SPEAKING";
                }
                btnResume.Enabled = false;
                btnPause.Enabled = true;
            }
        }

        private void StopReader()
        {
            if (reader != null)
            {
                reader.Dispose();
                lblStatus.Text = "IDLE";
                btnPause.Enabled = false;
                btnResume.Enabled = false;
                btnStop.Enabled = false;
                grbOptions.Enabled = true;
                grbNavigation.Enabled = true;
                grbSearch.Enabled = true;
            }
        }

        private void ConfirmExit()
        {
            if (MessageBox.Show("Are you sure you want to terminate the system?", "Terminate System!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Minimize()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void LoadDB()
        {
                connection = new SqlCeConnection(conString);
                data = new DataSet();
                adapter = new SqlCeDataAdapter(sql + filter, connection);
                adapter.Fill(data, tname);
                maxRows = data.Tables[tname].Rows.Count;
                NavigateRecords();
        }

        private void LoadCategory(ComboBox cmbName)
        {
            SqlCeDataAdapter adapter = new SqlCeDataAdapter("SELECT DISTINCT category FROM tblDictionary", connection);
            int maxItems = 0;
            int item = 0;
            DataSet DS = new DataSet();
            DataRow DR;
            adapter.Fill(DS, tname);
            maxItems = DS.Tables[tname].Rows.Count;
            cmbTopic.Items.Clear();
            cmbTopic.Items.Add("All");
            for (item = 0; item < maxItems; item++)
            {
                DR = DS.Tables[tname].Rows[item];
                cmbName.Items.Add(DR.ItemArray.GetValue(0).ToString());
            }
        }

        private void NavigateRecords()
        {
            if (maxRows > 0)
            {
                DataRow dRow = data.Tables[tname].Rows[inc];
                txtWord.Text = dRow.ItemArray.GetValue(0).ToString();
                txtMeaning.Text = dRow.ItemArray.GetValue(1).ToString();
                txtTopic.Text = dRow.ItemArray.GetValue(2).ToString();
                lblCount.Text = (inc + 1) + " of " + (maxRows);
            }
            else
            {
                txtWord.Clear();
                txtMeaning.Clear();
                lblCount.Text = (maxRows) + " of " + (maxRows);
            }
        }

        private void Next()
        {
            if (inc != maxRows - 1)
            {
                inc++;
                NavigateRecords();
            }
        }

        private void Previous()
        {
            if (inc > 0)
            {
                inc--;
                NavigateRecords();
            }
        }

        private void Last()
        {
            if (inc != (maxRows - 1))
            {
                inc = maxRows - 1;
                NavigateRecords();
            }
        }

        private void First()
        {
            if (inc != 0)
            {
                inc = 0;
                NavigateRecords();
            }
        }

        private void New()
        {
            txtWord.Clear();
            txtMeaning.Clear();
            txtWord.Enabled = true;
            txtTopic.Enabled = true;
            txtMeaning.Enabled = true;
            txtWord.Focus();
            btnSave.Enabled = true;
            lblCount.Text = (maxRows + 1) + " of " + (maxRows + 1);
            btnFirst.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnLast.Enabled = false;
            btnSearch.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            LoadCategory(txtTopic);
        }

        private void Edit()
        {
            txtWord.Enabled = true;
            txtTopic.Enabled = true;
            txtMeaning.Enabled = true;
            txtWord.Focus();
            btnSave.Enabled = false;
            btnFirst.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnLast.Enabled = false;
            btnSearch.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            LoadCategory(txtTopic);
        }

        private void UpdateDB()
        {
            SqlCeCommandBuilder cb = new SqlCeCommandBuilder(adapter);
            cb.DataAdapter.Update(data.Tables[tname]);
        }

        private void Save()
        {
            if ((txtWord.Text != "") && (txtTopic.Text != "") && (txtMeaning.Text != ""))
            {
                DataRow dRow = data.Tables[tname].NewRow();

                dRow[0] = txtWord.Text;
                dRow[1] = txtMeaning.Text;
                dRow[2] = txtTopic.Text;

                data.Tables[tname].Rows.Add(dRow);

                try
                {
                    UpdateDB();

                    MessageBox.Show("Word successfully saved!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadCategory(cmbTopic);
                    maxRows = maxRows + 1;
                    inc = maxRows - 1;
                }
                catch (Exception)
                {
                    MessageBox.Show("Word already exist in the database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadDB();
                    Cancel();
                }
                ResetButtons();
            }
            else
            {
                MessageBox.Show("Fields should not be empty!", "New", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtWord.Focus();
            }
        }

        private void UpdateWord()
        {
            if ((txtWord.Text != "") && (txtTopic.Text != "") && (txtMeaning.Text != ""))
            {
                DataRow dRow = data.Tables[tname].Rows[inc];

                dRow[0] = txtWord.Text;
                dRow[1] = txtMeaning.Text;
                dRow[2] = txtTopic.Text;

                try
                {
                    UpdateDB();

                    MessageBox.Show("Word successfully updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ResetButtons();
                }
                catch (Exception)
                {
                    MessageBox.Show("Word already exist in the database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cancel();
                    LoadDB();
                }
                LoadCategory(cmbTopic);
            }
            else
            {
                MessageBox.Show("Fields should not be empty!", "New", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtWord.Focus();
            }
        }

        private void Delete()
        {
            if (MessageBox.Show("Are you sure you want to delete this word?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data.Tables[tname].Rows[inc].Delete();
                UpdateDB();
                Search();
                maxRows = data.Tables[tname].Rows.Count;
                NavigateRecords();
                MessageBox.Show("Word successfully deleted!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void Search()
        {
            if (cmbTopic.Text == "All")
            {
                filter = " WHERE term LIKE '%" + txtSearch.Text + "%' ORDER BY term";
            }
            else
            {
                filter = " WHERE term LIKE '%" + txtSearch.Text + "%' AND category = '" + cmbTopic.Text + "' ORDER BY term";
            }

            data = new DataSet();
            adapter = new SqlCeDataAdapter(sql + filter, connection);
            adapter.Fill(data, tname);
            maxRows = data.Tables[tname].Rows.Count;
            inc = 0;
            NavigateRecords();
        }

        private void Cancel()
        {
            LoadDB();
            ResetButtons();
            LoadCategory(cmbTopic);
        }

        private void ResetButtons()
        {
            btnFirst.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnLast.Enabled = true;
            btnSearch.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            txtWord.Enabled = false;
            txtTopic.Enabled = false;
            txtMeaning.Enabled = false;
        }

        #endregion

        #region class events

        private void btnExit_Click(object sender, EventArgs e)
        {
            ConfirmExit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            Minimize();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Previous();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            First();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            Last();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateWord();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            SpeakReader();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            PauseReader();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            ResumeReader();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopReader();
        }
        #endregion
    }
}
