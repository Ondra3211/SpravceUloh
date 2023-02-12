using System.Diagnostics;
using System.Text.RegularExpressions;

namespace SpravceUloh
{
    public partial class SpravceUloh : Form
    {
        List<int> procList = new List<int>();

        public SpravceUloh()
        {
            InitializeComponent();
            Config.readConfig();
            chckKill.Checked = Config.killProcess;
            chckObnovit.Checked = Config.autoUpdate;

            obnovitProc();
            
        }

        private void obnovitProc()
        {
            lstProc.Items.Clear();
            procList.Clear();

            foreach (Process proc in Process.GetProcesses())
            {
                string patt = Regex.Escape(txtHledat.Text);
                Match match = Regex.Match(proc.ProcessName, patt, RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    string procName = proc.ProcessName + ".exe" + " (" + proc.Id + ")";

                    if (proc.Responding == false)
                    {
                        procName += " (Neodpovídá)";
                    }

                    if (proc.MainWindowTitle != "")
                    {
                        procName = proc.MainWindowTitle + " - " + procName;
                    }

                    lstProc.Items.Add(procName);
                    procList.Add(proc.Id);
                }
            }
        }

        private void txtHledat_TextChanged(object sender, EventArgs e)
        {
            obnovitProc();
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            int procIndex = lstProc.SelectedIndex;
            if (procIndex == -1) return;

            int procId = procList[procIndex];
 
            Process proc = Process.GetProcessById(procId);
            try
            {
                if (chckKill.Checked)
                {
                    proc.Kill();
                } else
                {
                    proc.CloseMainWindow();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obnovitProc();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            obnovitProc();
            timer.Stop();
        }

        private void timerAuto_Tick(object sender, EventArgs e)
        {
            if (Process.GetProcesses().Length != procList.Count)
            {
                obnovitProc();
            }
        }

        private void chckObnovit_CheckedChanged(object sender, EventArgs e)
        {
            if (chckObnovit.Checked)
            {
                timerAuto.Start();
            } else
            {
                timerAuto.Stop();
            }
        }

        private void SpravceUloh_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config.autoUpdate = chckObnovit.Checked;
            Config.killProcess = chckKill.Checked;
            Config.makeConfig();
        }
    }
}