
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
			this.button1 = new System.Windows.Forms.Button();
			this.nach_Label = new System.Windows.Forms.Label();
			this.von_Label = new System.Windows.Forms.Label();
			this.nach_TextBox = new System.Windows.Forms.TextBox();
			this.von_TextBox = new System.Windows.Forms.TextBox();
			this.stationenTab = new System.Windows.Forms.TabPage();
			this.verlaufTab = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.verbindungenTab.SuspendLayout();
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
			this.tabControl1.Size = new System.Drawing.Size(328, 450);
			this.tabControl1.TabIndex = 0;
			// 
			// verbindungenTab
			// 
			this.verbindungenTab.Controls.Add(this.button1);
			this.verbindungenTab.Controls.Add(this.nach_Label);
			this.verbindungenTab.Controls.Add(this.von_Label);
			this.verbindungenTab.Controls.Add(this.nach_TextBox);
			this.verbindungenTab.Controls.Add(this.von_TextBox);
			this.verbindungenTab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.verbindungenTab.Location = new System.Drawing.Point(4, 22);
			this.verbindungenTab.Name = "verbindungenTab";
			this.verbindungenTab.Padding = new System.Windows.Forms.Padding(3);
			this.verbindungenTab.Size = new System.Drawing.Size(320, 424);
			this.verbindungenTab.TabIndex = 0;
			this.verbindungenTab.Text = "Verbindungen";
			this.verbindungenTab.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(96, 106);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
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
			this.stationenTab.Location = new System.Drawing.Point(4, 22);
			this.stationenTab.Name = "stationenTab";
			this.stationenTab.Padding = new System.Windows.Forms.Padding(3);
			this.stationenTab.Size = new System.Drawing.Size(320, 424);
			this.stationenTab.TabIndex = 1;
			this.stationenTab.Text = "Stationen";
			this.stationenTab.UseVisualStyleBackColor = true;
			// 
			// verlaufTab
			// 
			this.verlaufTab.Location = new System.Drawing.Point(4, 22);
			this.verlaufTab.Name = "verlaufTab";
			this.verlaufTab.Padding = new System.Windows.Forms.Padding(3);
			this.verlaufTab.Size = new System.Drawing.Size(320, 424);
			this.verlaufTab.TabIndex = 2;
			this.verlaufTab.Text = "Verlauf";
			this.verlaufTab.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(328, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.verbindungenTab.ResumeLayout(false);
			this.verbindungenTab.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage verbindungenTab;
		private System.Windows.Forms.TabPage stationenTab;
		private System.Windows.Forms.TabPage verlaufTab;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label nach_Label;
		private System.Windows.Forms.Label von_Label;
		private System.Windows.Forms.TextBox nach_TextBox;
		private System.Windows.Forms.TextBox von_TextBox;
	}
}

