
namespace TransportApp_projekt
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.verbindungenTab = new System.Windows.Forms.TabPage();
			this.searchBtn = new System.Windows.Forms.Button();
			this.nach_Label = new System.Windows.Forms.Label();
			this.von_Label = new System.Windows.Forms.Label();
			this.nach_TextBox = new System.Windows.Forms.TextBox();
			this.von_TextBox = new System.Windows.Forms.TextBox();
			this.stationenTab = new System.Windows.Forms.TabPage();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.verlaufTab = new System.Windows.Forms.TabPage();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.datetimeClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.listView1 = new System.Windows.Forms.ListView();
			this.von_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Nach_columnsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.duration_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.arrival_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.departure_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.platform_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabControl1.SuspendLayout();
			this.verbindungenTab.SuspendLayout();
			this.stationenTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.verlaufTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.verbindungenTab);
			this.tabControl1.Controls.Add(this.stationenTab);
			this.tabControl1.Controls.Add(this.verlaufTab);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(429, 450);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.Tab_change);
			this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
			// 
			// verbindungenTab
			// 
			this.verbindungenTab.Controls.Add(this.listView1);
			this.verbindungenTab.Controls.Add(this.searchBtn);
			this.verbindungenTab.Controls.Add(this.nach_Label);
			this.verbindungenTab.Controls.Add(this.von_Label);
			this.verbindungenTab.Controls.Add(this.nach_TextBox);
			this.verbindungenTab.Controls.Add(this.von_TextBox);
			this.verbindungenTab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.verbindungenTab.Location = new System.Drawing.Point(4, 22);
			this.verbindungenTab.Name = "verbindungenTab";
			this.verbindungenTab.Padding = new System.Windows.Forms.Padding(3);
			this.verbindungenTab.Size = new System.Drawing.Size(421, 424);
			this.verbindungenTab.TabIndex = 0;
			this.verbindungenTab.Text = "Verbindungen";
			this.verbindungenTab.UseVisualStyleBackColor = true;
			// 
			// searchBtn
			// 
			this.searchBtn.Location = new System.Drawing.Point(96, 106);
			this.searchBtn.Name = "searchBtn";
			this.searchBtn.Size = new System.Drawing.Size(75, 23);
			this.searchBtn.TabIndex = 4;
			this.searchBtn.Text = "Suchen";
			this.searchBtn.UseVisualStyleBackColor = true;
			this.searchBtn.Click += new System.EventHandler(this.Search_Click);
			// 
			// nach_Label
			// 
			this.nach_Label.AutoSize = true;
			this.nach_Label.Location = new System.Drawing.Point(54, 83);
			this.nach_Label.Name = "nach_Label";
			this.nach_Label.Size = new System.Drawing.Size(36, 13);
			this.nach_Label.TabIndex = 3;
			this.nach_Label.Text = "Nach:";
			// 
			// von_Label
			// 
			this.von_Label.AutoSize = true;
			this.von_Label.Location = new System.Drawing.Point(54, 56);
			this.von_Label.Name = "von_Label";
			this.von_Label.Size = new System.Drawing.Size(29, 13);
			this.von_Label.TabIndex = 2;
			this.von_Label.Text = "Von:";
			// 
			// nach_TextBox
			// 
			this.nach_TextBox.Location = new System.Drawing.Point(96, 80);
			this.nach_TextBox.Name = "nach_TextBox";
			this.nach_TextBox.Size = new System.Drawing.Size(173, 20);
			this.nach_TextBox.TabIndex = 1;
			// 
			// von_TextBox
			// 
			this.von_TextBox.Location = new System.Drawing.Point(96, 53);
			this.von_TextBox.Name = "von_TextBox";
			this.von_TextBox.Size = new System.Drawing.Size(173, 20);
			this.von_TextBox.TabIndex = 0;
			// 
			// stationenTab
			// 
			this.stationenTab.Controls.Add(this.dataGridView2);
			this.stationenTab.Controls.Add(this.button1);
			this.stationenTab.Controls.Add(this.label2);
			this.stationenTab.Controls.Add(this.textBox2);
			this.stationenTab.Location = new System.Drawing.Point(4, 22);
			this.stationenTab.Name = "stationenTab";
			this.stationenTab.Padding = new System.Windows.Forms.Padding(3);
			this.stationenTab.Size = new System.Drawing.Size(421, 424);
			this.stationenTab.TabIndex = 1;
			this.stationenTab.Text = "Stationen";
			this.stationenTab.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToOrderColumns = true;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			this.dataGridView2.Location = new System.Drawing.Point(63, 88);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(291, 150);
			this.dataGridView2.TabIndex = 11;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Von-Nach";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Zeit";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(279, 59);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "Suchen";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(60, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Station:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(109, 61);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(173, 20);
			this.textBox2.TabIndex = 6;
			// 
			// verlaufTab
			// 
			this.verlaufTab.Controls.Add(this.dataGridView3);
			this.verlaufTab.Location = new System.Drawing.Point(4, 22);
			this.verlaufTab.Name = "verlaufTab";
			this.verlaufTab.Padding = new System.Windows.Forms.Padding(3);
			this.verlaufTab.Size = new System.Drawing.Size(421, 424);
			this.verlaufTab.TabIndex = 2;
			this.verlaufTab.Text = "Verlauf";
			this.verlaufTab.UseVisualStyleBackColor = true;
			// 
			// dataGridView3
			// 
			this.dataGridView3.AllowUserToAddRows = false;
			this.dataGridView3.AllowUserToDeleteRows = false;
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datetimeClm,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.dataGridView3.Location = new System.Drawing.Point(34, 138);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.ReadOnly = true;
			this.dataGridView3.Size = new System.Drawing.Size(345, 150);
			this.dataGridView3.TabIndex = 6;
			this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
			// 
			// datetimeClm
			// 
			this.datetimeClm.HeaderText = "Gesucht";
			this.datetimeClm.Name = "datetimeClm";
			this.datetimeClm.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Von-Nach";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Zeit";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.von_columnHeader,
            this.Nach_columnsHeader,
            this.duration_columnHeader,
            this.arrival_columnHeader,
            this.departure_columnHeader,
            this.platform_columnHeader});
			this.listView1.Location = new System.Drawing.Point(8, 150);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(405, 97);
			this.listView1.TabIndex = 5;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// von_columnHeader
			// 
			this.von_columnHeader.Text = "Von";
			// 
			// Nach_columnsHeader
			// 
			this.Nach_columnsHeader.Text = "Nach";
			// 
			// duration_columnHeader
			// 
			this.duration_columnHeader.Text = "Dauer";
			// 
			// arrival_columnHeader
			// 
			this.arrival_columnHeader.Text = "Ankunft";
			// 
			// departure_columnHeader
			// 
			this.departure_columnHeader.Text = "Abfahrt";
			// 
			// platform_columnHeader
			// 
			this.platform_columnHeader.Text = "Gleiss";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(429, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.verbindungenTab.ResumeLayout(false);
			this.verbindungenTab.PerformLayout();
			this.stationenTab.ResumeLayout(false);
			this.stationenTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.verlaufTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage verbindungenTab;
		private System.Windows.Forms.TabPage stationenTab;
		private System.Windows.Forms.TabPage verlaufTab;
		private System.Windows.Forms.Button searchBtn;
		private System.Windows.Forms.Label nach_Label;
		private System.Windows.Forms.Label von_Label;
		private System.Windows.Forms.TextBox nach_TextBox;
		private System.Windows.Forms.TextBox von_TextBox;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.DataGridViewTextBoxColumn datetimeClm;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader von_columnHeader;
		private System.Windows.Forms.ColumnHeader Nach_columnsHeader;
		private System.Windows.Forms.ColumnHeader duration_columnHeader;
		private System.Windows.Forms.ColumnHeader arrival_columnHeader;
		private System.Windows.Forms.ColumnHeader departure_columnHeader;
		private System.Windows.Forms.ColumnHeader platform_columnHeader;
	}
}

