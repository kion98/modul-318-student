﻿using System;
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
		GetConnections(von_ComboBox.Text, nach_ComboBox.Text);
		}

		public void GetConnections(string Von, string Nach)
		{
			connectionsView.Items.Clear();
			try { 
			var connections = transport.GetConnections(Von, Nach).ConnectionList;
			ListViewItem[] listItems = new ListViewItem[connections.Count];
			int itemIndex = 0;

			foreach (var connection in connections)
			{
				string von = connection.From.Station.Name;
				string nach = connection.To.Station.Name;
				string dauer = TimeSpan.Parse(
					connection.Duration.Substring(3)
					).TotalMinutes.ToString();
				string abfahrt = DateTime.Parse(
					connection.From.Departure
					).ToShortTimeString();
				string ankunft = DateTime.Parse(
					connection.To.Arrival
					).ToShortTimeString();
				string gleiss = connection.From.Platform;

				ListViewItem item = new ListViewItem(von);
				item.SubItems.Add(nach);
				item.SubItems.Add(dauer);
				item.SubItems.Add(abfahrt);
				item.SubItems.Add(ankunft);
				item.SubItems.Add(gleiss);

				listItems[itemIndex] = item;
				itemIndex++;
			}
			
			connectionsView.Items.AddRange(listItems);
		}catch
			{
				MessageBox.Show
					(
					"Konnte keine Verbindung finden.",
					"Fehler",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
					);
			}
		}

		public void onChange_Search_Stations(object sender, EventArgs e)
		{
			
			ComboBox comboBox = (ComboBox)sender;
			comboBox.Items.Clear();
			var vorschlaege = transport.GetStations(comboBox.Text).StationList;


			foreach (Station vorschlag in vorschlaege)
			{
				if (!string.IsNullOrEmpty(vorschlag.Name))
				{
					comboBox.Items.Add(vorschlag.Name);
				}
			}
			comboBox.SelectionStart = comboBox.Text.Length;
		}
		private void onClick_Stationboard_search(object sender, EventArgs e)
		{
			stationsView.Items.Clear();
			try { 
			var stationboard = transport.GetStationBoard(station_ComboBox.Text, "");
			var stationentries = stationboard.Entries;

			station_ComboBox.Text = stationboard.Station.Name;
			ListViewItem[] items = new ListViewItem[stationentries.Count];

			for (int i = 0; i < stationentries.Count; i++)
			{
				var route = stationentries[i];
				string zeit = route.Stop.Departure.ToShortTimeString();
				string zug = route.Name;
				string nach = route.To;

				ListViewItem item = new ListViewItem(zeit);
				item.SubItems.Add(zug);
				item.SubItems.Add(nach);

				items[i] = item;
			}
			stationsView.Items.AddRange(items);
		}
			catch 
			{
				MessageBox.Show
					(
					"Konnte keine Verbindung finden.",
					"Fehler",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
					);
			}
		}
	}
}
