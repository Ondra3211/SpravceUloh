namespace SpravceUloh
{
    partial class SpravceUloh
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lstProc = new System.Windows.Forms.ListBox();
            this.btnKill = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNadpis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHledat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chckObnovit = new System.Windows.Forms.CheckBox();
            this.chckKill = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerAuto = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lstProc, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnKill, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtHledat, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.button1, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 5, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(536, 421);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lstProc
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lstProc, 3);
            this.lstProc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstProc.FormattingEnabled = true;
            this.lstProc.ItemHeight = 15;
            this.lstProc.Location = new System.Drawing.Point(23, 93);
            this.lstProc.Name = "lstProc";
            this.tableLayoutPanel1.SetRowSpan(this.lstProc, 3);
            this.lstProc.Size = new System.Drawing.Size(270, 255);
            this.lstProc.TabIndex = 0;
            // 
            // btnKill
            // 
            this.btnKill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnKill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKill.FlatAppearance.BorderSize = 0;
            this.btnKill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKill.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKill.ForeColor = System.Drawing.Color.White;
            this.btnKill.Location = new System.Drawing.Point(319, 93);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(194, 81);
            this.btnKill.TabIndex = 1;
            this.btnKill.Text = "Ukončit";
            this.btnKill.UseVisualStyleBackColor = false;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 5);
            this.panel1.Controls.Add(this.lblNadpis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(23, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 44);
            this.panel1.TabIndex = 2;
            // 
            // lblNadpis
            // 
            this.lblNadpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNadpis.AutoSize = true;
            this.lblNadpis.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNadpis.ForeColor = System.Drawing.Color.White;
            this.lblNadpis.Location = new System.Drawing.Point(134, -2);
            this.lblNadpis.Name = "lblNadpis";
            this.lblNadpis.Size = new System.Drawing.Size(213, 45);
            this.lblNadpis.TabIndex = 0;
            this.lblNadpis.Text = "Správce úloh";
            this.lblNadpis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hledat:";
            // 
            // txtHledat
            // 
            this.txtHledat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHledat.Location = new System.Drawing.Point(23, 379);
            this.txtHledat.Name = "txtHledat";
            this.txtHledat.Size = new System.Drawing.Size(194, 23);
            this.txtHledat.TabIndex = 4;
            this.txtHledat.TextChanged += new System.EventHandler(this.txtHledat_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(319, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 81);
            this.button1.TabIndex = 5;
            this.button1.Text = "Obnovit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chckObnovit);
            this.panel2.Controls.Add(this.chckKill);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(319, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 81);
            this.panel2.TabIndex = 6;
            // 
            // chckObnovit
            // 
            this.chckObnovit.AutoSize = true;
            this.chckObnovit.ForeColor = System.Drawing.Color.White;
            this.chckObnovit.Location = new System.Drawing.Point(3, 28);
            this.chckObnovit.Name = "chckObnovit";
            this.chckObnovit.Size = new System.Drawing.Size(154, 19);
            this.chckObnovit.TabIndex = 1;
            this.chckObnovit.Text = "Automaticky obnovovat";
            this.chckObnovit.UseVisualStyleBackColor = true;
            this.chckObnovit.CheckedChanged += new System.EventHandler(this.chckObnovit_CheckedChanged);
            // 
            // chckKill
            // 
            this.chckKill.AutoSize = true;
            this.chckKill.ForeColor = System.Drawing.Color.White;
            this.chckKill.Location = new System.Drawing.Point(3, 3);
            this.chckKill.Name = "chckKill";
            this.chckKill.Size = new System.Drawing.Size(116, 19);
            this.chckKill.TabIndex = 0;
            this.chckKill.Text = "Vynutit ukončení";
            this.chckKill.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerAuto
            // 
            this.timerAuto.Interval = 1000;
            this.timerAuto.Tick += new System.EventHandler(this.timerAuto_Tick);
            // 
            // SpravceUloh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 421);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SpravceUloh";
            this.Text = "Správce úloh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpravceUloh_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListBox lstProc;
        private Button btnKill;
        private Panel panel1;
        private Label lblNadpis;
        private Label label1;
        private TextBox txtHledat;
        private Button button1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerAuto;
        private Panel panel2;
        private CheckBox chckObnovit;
        private CheckBox chckKill;
    }
}