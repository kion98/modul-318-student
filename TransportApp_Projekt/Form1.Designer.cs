
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
			this.conectionsView = new System.Windows.Forms.ListView();
			this.von_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Nach_columnsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.duration_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.arrival_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.departure_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.platform_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.searchBtn = new System.Windows.Forms.Button();
			this.nach_Label = new System.Windows.Forms.Label();
			this.von_Label = new System.Windows.Forms.Label();
			this.nach_TextBox = new System.Windows.Forms.TextBox();
			this.von_TextBox = new System.Windows.Forms.TextBox();
			this.stationenTab = new System.Windows.Forms.TabPage();
			this.listView2 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.verlaufTab = new System.Windows.Forms.TabPage();
			this.listView3 = new System.Windows.Forms.ListView();
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabControl1.SuspendLayout();
			this.verbindungenTab.SuspendLayout();
			this.stationenTab.SuspendLayout();
			this.verlaufTab.SuspendLayout();
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
			this.verbindungenTab.Controls.Add(this.conectionsView);
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
			// conectionsView
			// 
			this.conectionsView.AllowColumnReorder = true;
			this.conectionsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.conectionsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.von_columnHeader,
            this.Nach_columnsHeader,
            this.duration_columnHeader,
            this.departure_columnHeader,
            this.arrival_columnHeader,
            this.platform_columnHeader});
			this.conectionsView.Location = new System.Drawing.Point(8, 152);
			this.conectionsView.Name = "conectionsView";
			this.conectionsView.Size = new System.Drawing.Size(405, 264);
			this.conectionsView.TabIndex = 5;
			this.conectionsView.UseCompatibleStateImageBehavior = false;
			this.conectionsView.View = System.Windows.Forms.View.Details;
			this.conectionsView.SelectedIndexChanged += new System.EventHandler(this.conectionsView_SelectedIndexChanged);
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
			this.arrival_columnHeader.DisplayIndex = 3;
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
			this.stationenTab.Controls.Add(this.listView2);
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
			// listView2
			// 
			this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.listView2.Location = new System.Drawing.Point(8, 164);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(405, 97);
			this.listView2.TabIndex = 12;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Von";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Nach";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Dauer";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Ankunft";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Abfahrt";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Gleiss";
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
			this.verlaufTab.Controls.Add(this.listView3);
			this.verlaufTab.Location = new System.Drawing.Point(4, 22);
			this.verlaufTab.Name = "verlaufTab";
			this.verlaufTab.Padding = new System.Windows.Forms.Padding(3);
			this.verlaufTab.Size = new System.Drawing.Size(421, 424);
			this.verlaufTab.TabIndex = 2;
			this.verlaufTab.Text = "Verlauf";
			this.verlaufTab.UseVisualStyleBackColor = true;
			// 
			// listView3
			// 
			this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
			this.listView3.Location = new System.Drawing.Point(6, 51);
			this.listView3.Name = "listView3";
			this.listView3.Size = new System.Drawing.Size(405, 97);
			this.listView3.TabIndex = 6;
			this.listView3.UseCompatibleStateImageBehavior = false;
			this.listView3.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Von";
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Nach";
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Dauer";
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Ankunft";
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "Abfahrt";
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Gleiss";
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
			this.verlaufTab.ResumeLayout(false);
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
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ListView conectionsView;
		private System.Windows.Forms.ColumnHeader von_columnHeader;
		private System.Windows.Forms.ColumnHeader Nach_columnsHeader;
		private System.Windows.Forms.ColumnHeader duration_columnHeader;
		private System.Windows.Forms.ColumnHeader arrival_columnHeader;
		private System.Windows.Forms.ColumnHeader departure_columnHeader;
		private System.Windows.Forms.ColumnHeader platform_columnHeader;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ListView listView3;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader12;
	}
}

