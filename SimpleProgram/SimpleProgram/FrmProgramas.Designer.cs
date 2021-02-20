
namespace UI
{
    partial class FrmProgramas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbProgramas1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtNomePrograma = new MetroFramework.Controls.MetroTextBox();
            this.lblNomePrograma = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.tbProgramas1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbProgramas1
            // 
            this.tbProgramas1.Controls.Add(this.metroTabPage1);
            this.tbProgramas1.Controls.Add(this.metroTabPage2);
            this.tbProgramas1.Controls.Add(this.metroTabPage3);
            this.tbProgramas1.Controls.Add(this.metroTabPage4);
            this.tbProgramas1.Location = new System.Drawing.Point(23, 63);
            this.tbProgramas1.Name = "tbProgramas1";
            this.tbProgramas1.SelectedIndex = 3;
            this.tbProgramas1.Size = new System.Drawing.Size(778, 566);
            this.tbProgramas1.TabIndex = 0;
            this.tbProgramas1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroListView1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(770, 524);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Todos";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroListView1
            // 
            this.metroListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.metroListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.metroListView1.Location = new System.Drawing.Point(0, 0);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(770, 524);
            this.metroListView1.TabIndex = 2;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 380;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Total de Horas";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 381;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroComboBox1);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.metroButton1);
            this.metroTabPage2.Controls.Add(this.txtNomePrograma);
            this.metroTabPage2.Controls.Add(this.lblNomePrograma);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(770, 524);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Cadastrar";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(-4, 465);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(107, 53);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Cadastrar";
            this.metroButton1.UseSelectable = true;
            // 
            // txtNomePrograma
            // 
            // 
            // 
            // 
            this.txtNomePrograma.CustomButton.Image = null;
            this.txtNomePrograma.CustomButton.Location = new System.Drawing.Point(359, 1);
            this.txtNomePrograma.CustomButton.Name = "";
            this.txtNomePrograma.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomePrograma.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomePrograma.CustomButton.TabIndex = 1;
            this.txtNomePrograma.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomePrograma.CustomButton.UseSelectable = true;
            this.txtNomePrograma.CustomButton.Visible = false;
            this.txtNomePrograma.Lines = new string[0];
            this.txtNomePrograma.Location = new System.Drawing.Point(3, 47);
            this.txtNomePrograma.MaxLength = 32767;
            this.txtNomePrograma.Name = "txtNomePrograma";
            this.txtNomePrograma.PasswordChar = '\0';
            this.txtNomePrograma.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomePrograma.SelectedText = "";
            this.txtNomePrograma.SelectionLength = 0;
            this.txtNomePrograma.SelectionStart = 0;
            this.txtNomePrograma.ShortcutsEnabled = true;
            this.txtNomePrograma.Size = new System.Drawing.Size(381, 23);
            this.txtNomePrograma.TabIndex = 3;
            this.txtNomePrograma.UseSelectable = true;
            this.txtNomePrograma.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomePrograma.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNomePrograma
            // 
            this.lblNomePrograma.AutoSize = true;
            this.lblNomePrograma.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNomePrograma.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNomePrograma.Location = new System.Drawing.Point(3, 19);
            this.lblNomePrograma.Name = "lblNomePrograma";
            this.lblNomePrograma.Size = new System.Drawing.Size(182, 25);
            this.lblNomePrograma.TabIndex = 2;
            this.lblNomePrograma.Text = "Nome do Programa:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(140, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Dia da semana:";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta"});
            this.metroComboBox1.Location = new System.Drawing.Point(4, 120);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(192, 30);
            this.metroComboBox1.TabIndex = 6;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(770, 524);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Atualizar";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(770, 524);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Controle";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // FrmProgramas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 642);
            this.Controls.Add(this.tbProgramas1);
            this.Name = "FrmProgramas";
            this.Text = "Programas";
            this.Load += new System.EventHandler(this.FrmProgramas_Load);
            this.tbProgramas1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tbProgramas1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTextBox txtNomePrograma;
        private MetroFramework.Controls.MetroLabel lblNomePrograma;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
    }
}