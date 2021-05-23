using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using course_project_v0._0._2.DataBase;

namespace course_project_v0._0._2.View
{
	public partial class BasketWPF : Window
	{
		public BasketWPF(string _login, bool _admin)
		{
			LOGIN = _login;
			ADMIN = _admin;
			InitializeComponent();
			InfoForListBox();
			LoginUser.Text = LOGIN;
		}
		private void Button_Click_Back(object sender, RoutedEventArgs e)
		{
			try
			{
				this.Close();
				MainWindow mainWindow = new MainWindow(ADMIN, LOGIN);
				mainWindow.Show();
			}
			catch(Exception)
			{
				MessageBox.Show("Нет подключения к интернету");
			}
		}

		public string LOGIN;
		public bool ADMIN;
		private ObservableCollection<AppViewTickets> infoforTickets;
		public void InfoForListBox()
		{
			using (SQL_course_work cw = new SQL_course_work())
			{
				var info = cw.Ticket.ToList();
				infoforTickets = new ObservableCollection<AppViewTickets>();
				var forBD = cw.Database.SqlQuery<UsersBD>($"select * from UsersBD where UsersBD.login = '{LOGIN}'");
				foreach (var check in forBD)
				{
					foreach (var i in info)
					{
						if (check.userID == i.userID)
						{
							var forFilm = cw.Database.SqlQuery<Film>($"select * from Film where Film.filmName = '{i.filmName}'");
							foreach (var n in forFilm)
							{
								if (n.filmName == i.filmName)
								{
									AppViewTickets allTicket = new AppViewTickets();
									allTicket.InfoForTickets(i.ticketID, i.sessionID, i.userID, i.filmName, i.price, i.date, i.time, i.row, i.place, n.poster);
									infoforTickets.Add(allTicket);
								}
								
							}
						}
					}
				}
				ListBoxTicket.ItemsSource = infoforTickets;
			}
		}
		private void Button_Del_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				var contentListBox = ListBoxTicket.SelectedItem as AppViewTickets;
				if (contentListBox != null)
				{
					int checked_value = Convert.ToInt32(contentListBox.TicketID);
					SQL_course_work context = new SQL_course_work();
					Ticket customer = context.Ticket
					 .Where(c => c.ticketID == checked_value)
					 .FirstOrDefault();

					context.Ticket.Remove(customer);
					context.SaveChanges();
				}
				InfoForListBox();
			}
			catch(Exception)
			{

			}
		}
	}
}
