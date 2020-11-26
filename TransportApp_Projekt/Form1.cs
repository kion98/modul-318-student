using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace TransportApp_projekt
{
	public partial class Form1 : Form
	{
		private readonly ITransport transport = new Transport();

		public Form1()
		{
			InitializeComponent();


		}

		private void Form1_Load(object sender, EventArgs e)
		{
			var result = transport.GetStations("Luz");
			Console.WriteLine(result.StationList.First().Name);
		}

		private void Search_Click(object sender, EventArgs e)
		{

			var connections = transport.GetConnections(von_TextBox.Text, nach_TextBox.Text);
		}
	

		private void Tab_change(object sender, TabControlCancelEventArgs e)
		{
			Console.WriteLine(e.TabPage.Name);
		}

		private void tabControl1_Selected(object sender, TabControlEventArgs e)
		{

		}



		private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
