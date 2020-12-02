
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
			this.nach_ComboBox = new System.Windows.Forms.ComboBox();
			this.von_ComboBox = new System.Windows.Forms.ComboBox();
			this.connectionsView = new System.Windows.Forms.ListView();
			this.von_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Nach_columnsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.duration_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.departure_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.arrival_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.platform_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.searchBtn = new System.Windows.Forms.Button();
			this.nach_Label = new System.Windows.Forms.Label();
			this.von_Label = new System.Windows.Forms.Label();
			this.stationenTab = new System.Windows.Forms.TabPage();
			this.station_ComboBox = new System.Windows.Forms.ComboBox();
			this.stationsView = new System.Windows.Forms.ListView();
			this.time_ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.trainName_ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.toStation_ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.verlaufTab = new System.Windows.Forms.TabPage();
			this.historyView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
			// 
			// verbindungenTab
			// 
			this.verbindungenTab.Controls.Add(this.nach_ComboBox);
			this.verbindungenTab.Controls.Add(this.von_ComboBox);
			this.verbindungenTab.Controls.Add(this.connectionsView);
			this.verbindungenTab.Controls.Add(this.searchBtn);
			this.verbindungenTab.Controls.Add(this.nach_Label);
			this.verbindungenTab.Controls.Add(this.von_Label);
			this.verbindungenTab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.verbindungenTab.Location = new System.Drawing.Point(4, 22);
			this.verbindungenTab.Name = "verbindungenTab";
			this.verbindungenTab.Padding = new System.Windows.Forms.Padding(3);
			this.verbindungenTab.Size = new System.Drawing.Size(421, 424);
			this.verbindungenTab.TabIndex = 0;
			this.verbindungenTab.Text = "Verbindungen";
			this.verbindungenTab.UseVisualStyleBackColor = true;
			// 
			// nach_ComboBox
			// 
			this.nach_ComboBox.FormattingEnabled = true;
			this.nach_ComboBox.Location = new System.Drawing.Point(96, 80);
			this.nach_ComboBox.Name = "nach_ComboBox";
			this.nach_ComboBox.Size = new System.Drawing.Size(173, 21);
			this.nach_ComboBox.TabIndex = 7;
			this.nach_ComboBox.TextUpdate += new System.EventHandler(this.onChange_Search_Stations);
			// 
			// von_ComboBox
			// 
			this.von_ComboBox.FormattingEnabled = true;
			this.von_ComboBox.Location = new System.Drawing.Point(96, 53);
			this.von_ComboBox.Name = "von_ComboBox";
			this.von_ComboBox.Size = new System.Drawing.Size(173, 21);
			this.von_ComboBox.TabIndex = 6;
			this.von_ComboBox.TextUpdate += new System.EventHandler(this.onChange_Search_Stations);
			// 
			// connectionsView
			// 
			this.connectionsView.AllowColumnReorder = true;
			this.connectionsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.connectionsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.von_columnHeader,
            this.Nach_columnsHeader,
            this.duration_columnHeader,
            this.departure_columnHeader,
            this.arrival_columnHeader,
            this.platform_columnHeader});
			this.connectionsView.Location = new System.Drawing.Point(8, 152);
			this.connectionsView.Name = "connectionsView";
			this.connectionsView.Size = new System.Drawing.Size(405, 264);
			this.connectionsView.TabIndex = 5;
			this.connectionsView.UseCompatibleStateImageBehavior = false;
			this.connectionsView.View = System.Windows.Forms.View.Details;
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
			// departure_columnHeader
			// 
			this.departure_columnHeader.Text = "Abfahrt";
			// 
			// arrival_columnHeader
			// 
			this.arrival_columnHeader.Text = "Ankunft";
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
			// stationenTab
			// 
			this.stationenTab.Controls.Add(this.station_ComboBox);
			this.stationenTab.Controls.Add(this.stationsView);
			this.stationenTab.Controls.Add(this.button1);
			this.stationenTab.Controls.Add(this.label2);
			this.stationenTab.Location = new System.Drawing.Point(4, 22);
			this.stationenTab.Name = "stationenTab";
			this.stationenTab.Padding = new System.Windows.Forms.Padding(3);
			this.stationenTab.Size = new System.Drawing.Size(421, 424);
			this.stationenTab.TabIndex = 1;
			this.stationenTab.Text = "Stationen";
			this.stationenTab.UseVisualStyleBackColor = true;
			// 
			// station_ComboBox
			// 
			this.station_ComboBox.FormattingEnabled = true;
			this.station_ComboBox.Location = new System.Drawing.Point(109, 61);
			this.station_ComboBox.Name = "station_ComboBox";
			this.station_ComboBox.Size = new System.Drawing.Size(164, 21);
			this.station_ComboBox.TabIndex = 13;
			this.station_ComboBox.TextUpdate += new System.EventHandler(this.onChange_Search_Stations);
			// 
			// stationsView
			// 
			this.stationsView.AllowColumnReorder = true;
			this.stationsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.stationsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.time_ColumnHeader,
            this.trainName_ColumnHeader,
            this.toStation_ColumnHeader});
			this.stationsView.Location = new System.Drawing.Point(8, 164);
			this.stationsView.Name = "stationsView";
			this.stationsView.Size = new System.Drawing.Size(405, 252);
			this.stationsView.TabIndex = 12;
			this.stationsView.UseCompatibleStateImageBehavior = false;
			this.stationsView.View = System.Windows.Forms.View.Details;
			// 
			// time_ColumnHeader
			// 
			this.time_ColumnHeader.Text = "Zeit";
			this.time_ColumnHeader.Width = 50;
			// 
			// trainName_ColumnHeader
			// 
			this.trainName_ColumnHeader.Text = "Zug";
			this.trainName_ColumnHeader.Width = 100;
			// 
			// toStation_ColumnHeader
			// 
			this.toStation_ColumnHeader.Text = "Nach";
			this.toStation_ColumnHeader.Width = 201;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(279, 59);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "Suchen";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.onClick_Stationboard_search);
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
			// verlaufTab
			// 
			this.verlaufTab.Controls.Add(this.historyView);
			this.verlaufTab.Location = new System.Drawing.Point(4, 22);
			this.verlaufTab.Name = "verlaufTab";
			this.verlaufTab.Padding = new System.Windows.Forms.Padding(3);
			this.verlaufTab.Size = new System.Drawing.Size(421, 424);
			this.verlaufTab.TabIndex = 2;
			this.verlaufTab.Text = "Verlauf";
			this.verlaufTab.UseVisualStyleBackColor = true;
			// 
			// historyView
			// 
			this.historyView.AllowColumnReorder = true;
			this.historyView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.historyView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.historyView.Location = new System.Drawing.Point(8, 6);
			this.historyView.Name = "historyView";
			this.historyView.Size = new System.Drawing.Size(405, 410);
			this.historyView.TabIndex = 6;
			this.historyView.UseCompatibleStateImageBehavior = false;
			this.historyView.View = System.Windows.Forms.View.Details;
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
			this.columnHeader4.Text = "Abfahrt";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Ankunft";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Gleiss";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(429, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "TransportApp";
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
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.ListView connectionsView;
		private System.Windows.Forms.ColumnHeader von_columnHeader;
		private System.Windows.Forms.ColumnHeader Nach_columnsHeader;
		private System.Windows.Forms.ColumnHeader duration_columnHeader;
		private System.Windows.Forms.ColumnHeader arrival_columnHeader;
		private System.Windows.Forms.ColumnHeader departure_columnHeader;
		private System.Windows.Forms.ColumnHeader platform_columnHeader;
		private System.Windows.Forms.ListView stationsView;
		public System.Windows.Forms.ComboBox von_ComboBox;
		public System.Windows.Forms.ComboBox nach_ComboBox;
		private System.Windows.Forms.ComboBox station_ComboBox;
		private System.Windows.Forms.ColumnHeader time_ColumnHeader;
		private System.Windows.Forms.ColumnHeader trainName_ColumnHeader;
		private System.Windows.Forms.ColumnHeader toStation_ColumnHeader;
		private System.Windows.Forms.ListView historyView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
	}
}

