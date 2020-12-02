using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransportApp_projekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp_projekt.Tests
{
	[TestClass()]
	public class Form1Tests
	{
		[TestMethod()]
		public void GetConnectionsTest()
		{
			var app = new Form1();
			string von = "a";
			string nach = "b";

			app.GetConnections(von, nach);
			
			Assert.IsTrue(app.connectionsView.Items.Count > 0);
		}

		[TestMethod()]
		public void onChange_Search_StationsTest()
		{
			var app = new Form1();
			string von = "a";
			string nach = "b";
			
			app.von_ComboBox.Text = von;
			app.nach_ComboBox.Text = nach;
			app.onChange_Search_Stations(app.von_ComboBox, EventArgs.Empty);
			app.onChange_Search_Stations(app.nach_ComboBox, EventArgs.Empty);
			var vonVorschlag = app.von_ComboBox.Items[0];
			var nachVorschlag = app.nach_ComboBox.Items[0];

			Assert.AreEqual(vonVorschlag.ToString(), "Aarau");
			Assert.AreEqual(nachVorschlag.ToString(), "Bern");
		}
	}
}