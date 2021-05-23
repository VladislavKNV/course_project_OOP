using System;
using System.Linq;
using course_project_v0._0._2.DataBase;
using System.Windows;
namespace course_project_v0._0._2.View
{
	public partial class TicketWPF : Window
	{
		public TicketWPF(string _login, int _sessionID, bool _admin, int _ID)
		{
			ID = _ID;
			LOGIN = _login;
			SESSID = _sessionID;
			Admin = _admin;

			InitializeComponent();
			Info();
			TicketsSingleton();
		}
		public bool Admin;
		public int ID;
		public int SESSID;
		public string LOGIN;
		public int USERID;
		public string TICKETID;
		public DateTime DATE;
		public TimeSpan TIME;
		public int PRICE;
		public int NumberOfFreeSeats;
		public string FILMNAME;
		public bool valid = true;

		public void TicketsSingleton()
		{
			using (SQL_course_work cw = new SQL_course_work())
			{
				var forBD = cw.Database.SqlQuery<Ticket>($"select * from Ticket where Ticket.sessionID = '{SESSID}'");
				foreach (var check in forBD)
				{
					if (check.row == 1)
					{
						if (check.place == 1)
						{
							Singleton singleton = new Singleton();
							r1p1.Background = singleton.bgColor;
						}
						if (check.place == 2)
						{
							Singleton singleton = new Singleton();
							r1p2.Background = singleton.bgColor;
						}
						if (check.place == 3)
						{
							Singleton singleton = new Singleton();
							r1p3.Background = singleton.bgColor;
						}
						if (check.place == 4)
						{
							Singleton singleton = new Singleton();
							r1p4.Background = singleton.bgColor;
						}
						if (check.place == 5)
						{
							Singleton singleton = new Singleton();
							r1p5.Background = singleton.bgColor;
						}
						if (check.place == 6)
						{
							Singleton singleton = new Singleton();
							r1p6.Background = singleton.bgColor;
						}
						if (check.place == 7)
						{
							Singleton singleton = new Singleton();
							r1p7.Background = singleton.bgColor;
						}
						if (check.place == 8)
						{
							Singleton singleton = new Singleton();
							r1p8.Background = singleton.bgColor;
						}
						if (check.place == 9)
						{
							Singleton singleton = new Singleton();
							r1p9.Background = singleton.bgColor;
						}
						if (check.place == 10)
						{
							Singleton singleton = new Singleton();
							r1p10.Background = singleton.bgColor;
						}
						if (check.place == 11)
						{
							Singleton singleton = new Singleton();
							r1p11.Background = singleton.bgColor;
						}
						if (check.place == 12)
						{
							Singleton singleton = new Singleton();
							r1p12.Background = singleton.bgColor;
						}
						if (check.place == 13)
						{
							Singleton singleton = new Singleton();
							r1p13.Background = singleton.bgColor;
						}
						if (check.place == 14)
						{
							Singleton singleton = new Singleton();
							r1p14.Background = singleton.bgColor;
						}
						if (check.place == 15)
						{
							Singleton singleton = new Singleton();
							r1p15.Background = singleton.bgColor;
						}
						if (check.place == 16)
						{
							Singleton singleton = new Singleton();
							r1p16.Background = singleton.bgColor;
						}
						if (check.place == 17)
						{
							Singleton singleton = new Singleton();
							r1p17.Background = singleton.bgColor;
						}
						if (check.place == 18)
						{
							Singleton singleton = new Singleton();
							r1p18.Background = singleton.bgColor;
						}
					}
					if (check.row == 2)
					{
						if (check.place == 1)
						{
							Singleton singleton = new Singleton();
							r2p1.Background = singleton.bgColor;
						}
						if (check.place == 2)
						{
							Singleton singleton = new Singleton();
							r2p2.Background = singleton.bgColor;
						}
						if (check.place == 3)
						{
							Singleton singleton = new Singleton();
							r2p3.Background = singleton.bgColor;
						}
						if (check.place == 4)
						{
							Singleton singleton = new Singleton();
							r2p4.Background = singleton.bgColor;
						}
						if (check.place == 5)
						{
							Singleton singleton = new Singleton();
							r2p5.Background = singleton.bgColor;
						}
						if (check.place == 6)
						{
							Singleton singleton = new Singleton();
							r2p6.Background = singleton.bgColor;
						}
						if (check.place == 7)
						{
							Singleton singleton = new Singleton();
							r2p7.Background = singleton.bgColor;
						}
						if (check.place == 8)
						{
							Singleton singleton = new Singleton();
							r2p8.Background = singleton.bgColor;
						}
						if (check.place == 9)
						{
							Singleton singleton = new Singleton();
							r2p9.Background = singleton.bgColor;
						}
						if (check.place == 10)
						{
							Singleton singleton = new Singleton();
							r2p10.Background = singleton.bgColor;
						}
						if (check.place == 11)
						{
							Singleton singleton = new Singleton();
							r2p11.Background = singleton.bgColor;
						}
						if (check.place == 12)
						{
							Singleton singleton = new Singleton();
							r2p12.Background = singleton.bgColor;
						}
						if (check.place == 13)
						{
							Singleton singleton = new Singleton();
							r2p13.Background = singleton.bgColor;
						}
						if (check.place == 14)
						{
							Singleton singleton = new Singleton();
							r2p14.Background = singleton.bgColor;
						}
						if (check.place == 15)
						{
							Singleton singleton = new Singleton();
							r2p15.Background = singleton.bgColor;
						}
						if (check.place == 16)
						{
							Singleton singleton = new Singleton();
							r2p16.Background = singleton.bgColor;
						}
						if (check.place == 17)
						{
							Singleton singleton = new Singleton();
							r2p17.Background = singleton.bgColor;
						}
						if (check.place == 18)
						{
							Singleton singleton = new Singleton();
							r2p18.Background = singleton.bgColor;
						}
					}
					if (check.row == 3)
					{
						if (check.place == 1)
						{
							Singleton singleton = new Singleton();
							r3p1.Background = singleton.bgColor;
						}
						if (check.place == 2)
						{
							Singleton singleton = new Singleton();
							r3p2.Background = singleton.bgColor;
						}
						if (check.place == 3)
						{
							Singleton singleton = new Singleton();
							r3p3.Background = singleton.bgColor;
						}
						if (check.place == 4)
						{
							Singleton singleton = new Singleton();
							r3p4.Background = singleton.bgColor;
						}
						if (check.place == 5)
						{
							Singleton singleton = new Singleton();
							r3p5.Background = singleton.bgColor;
						}
						if (check.place == 6)
						{
							Singleton singleton = new Singleton();
							r3p6.Background = singleton.bgColor;
						}
						if (check.place == 7)
						{
							Singleton singleton = new Singleton();
							r3p7.Background = singleton.bgColor;
						}
						if (check.place == 8)
						{
							Singleton singleton = new Singleton();
							r3p8.Background = singleton.bgColor;
						}
						if (check.place == 9)
						{
							Singleton singleton = new Singleton();
							r3p9.Background = singleton.bgColor;
						}
						if (check.place == 10)
						{
							Singleton singleton = new Singleton();
							r3p10.Background = singleton.bgColor;
						}
						if (check.place == 11)
						{
							Singleton singleton = new Singleton();
							r3p11.Background = singleton.bgColor;
						}
						if (check.place == 12)
						{
							Singleton singleton = new Singleton();
							r3p12.Background = singleton.bgColor;
						}
						if (check.place == 13)
						{
							Singleton singleton = new Singleton();
							r3p13.Background = singleton.bgColor;
						}
						if (check.place == 14)
						{
							Singleton singleton = new Singleton();
							r3p14.Background = singleton.bgColor;
						}
						if (check.place == 15)
						{
							Singleton singleton = new Singleton();
							r3p15.Background = singleton.bgColor;
						}
						if (check.place == 16)
						{
							Singleton singleton = new Singleton();
							r3p16.Background = singleton.bgColor;
						}
						if (check.place == 17)
						{
							Singleton singleton = new Singleton();
							r3p17.Background = singleton.bgColor;
						}
						if (check.place == 18)
						{
							Singleton singleton = new Singleton();
							r3p18.Background = singleton.bgColor;
						}
					}
					if (check.row == 4)
					{
						if (check.place == 1)
						{
							Singleton singleton = new Singleton();
							r4p1.Background = singleton.bgColor;
						}
						if (check.place == 2)
						{
							Singleton singleton = new Singleton();
							r4p2.Background = singleton.bgColor;
						}
						if (check.place == 3)
						{
							Singleton singleton = new Singleton();
							r4p3.Background = singleton.bgColor;
						}
						if (check.place == 4)
						{
							Singleton singleton = new Singleton();
							r4p4.Background = singleton.bgColor;
						}
						if (check.place == 5)
						{
							Singleton singleton = new Singleton();
							r4p5.Background = singleton.bgColor;
						}
						if (check.place == 6)
						{
							Singleton singleton = new Singleton();
							r4p6.Background = singleton.bgColor;
						}
						if (check.place == 7)
						{
							Singleton singleton = new Singleton();
							r4p7.Background = singleton.bgColor;
						}
						if (check.place == 8)
						{
							Singleton singleton = new Singleton();
							r4p8.Background = singleton.bgColor;
						}
						if (check.place == 9)
						{
							Singleton singleton = new Singleton();
							r4p9.Background = singleton.bgColor;
						}
						if (check.place == 10)
						{
							Singleton singleton = new Singleton();
							r4p10.Background = singleton.bgColor;
						}
						if (check.place == 11)
						{
							Singleton singleton = new Singleton();
							r4p11.Background = singleton.bgColor;
						}
						if (check.place == 12)
						{
							Singleton singleton = new Singleton();
							r4p12.Background = singleton.bgColor;
						}
						if (check.place == 13)
						{
							Singleton singleton = new Singleton();
							r4p13.Background = singleton.bgColor;
						}
						if (check.place == 14)
						{
							Singleton singleton = new Singleton();
							r4p14.Background = singleton.bgColor;
						}
						if (check.place == 15)
						{
							Singleton singleton = new Singleton();
							r4p15.Background = singleton.bgColor;
						}
						if (check.place == 16)
						{
							Singleton singleton = new Singleton();
							r4p16.Background = singleton.bgColor;
						}
						if (check.place == 17)
						{
							Singleton singleton = new Singleton();
							r4p17.Background = singleton.bgColor;
						}
						if (check.place == 18)
						{
							Singleton singleton = new Singleton();
							r4p18.Background = singleton.bgColor;
						}
					}
					if (check.row == 5)
					{
						if (check.place == 1)
						{
							Singleton singleton = new Singleton();
							r5p1.Background = singleton.bgColor;
						}
						if (check.place == 2)
						{
							Singleton singleton = new Singleton();
							r5p2.Background = singleton.bgColor;
						}
						if (check.place == 3)
						{
							Singleton singleton = new Singleton();
							r5p3.Background = singleton.bgColor;
						}
						if (check.place == 4)
						{
							Singleton singleton = new Singleton();
							r5p4.Background = singleton.bgColor;
						}
						if (check.place == 5)
						{
							Singleton singleton = new Singleton();
							r5p5.Background = singleton.bgColor;
						}
						if (check.place == 6)
						{
							Singleton singleton = new Singleton();
							r5p6.Background = singleton.bgColor;
						}
						if (check.place == 7)
						{
							Singleton singleton = new Singleton();
							r5p7.Background = singleton.bgColor;
						}
						if (check.place == 8)
						{
							Singleton singleton = new Singleton();
							r5p8.Background = singleton.bgColor;
						}
						if (check.place == 9)
						{
							Singleton singleton = new Singleton();
							r5p9.Background = singleton.bgColor;
						}
						if (check.place == 10)
						{
							Singleton singleton = new Singleton();
							r5p10.Background = singleton.bgColor;
						}
						if (check.place == 11)
						{
							Singleton singleton = new Singleton();
							r5p11.Background = singleton.bgColor;
						}
						if (check.place == 12)
						{
							Singleton singleton = new Singleton();
							r5p12.Background = singleton.bgColor;
						}
						if (check.place == 13)
						{
							Singleton singleton = new Singleton();
							r5p13.Background = singleton.bgColor;
						}
						if (check.place == 14)
						{
							Singleton singleton = new Singleton();
							r5p14.Background = singleton.bgColor;
						}
						if (check.place == 15)
						{
							Singleton singleton = new Singleton();
							r5p15.Background = singleton.bgColor;
						}
						if (check.place == 16)
						{
							Singleton singleton = new Singleton();
							r5p16.Background = singleton.bgColor;
						}
						if (check.place == 17)
						{
							Singleton singleton = new Singleton();
							r5p17.Background = singleton.bgColor;
						}
						if (check.place == 18)
						{
							Singleton singleton = new Singleton();
							r5p18.Background = singleton.bgColor;
						}
					}
				}
			}
		}
		public void Info()
		{
			using (SQL_course_work cw = new SQL_course_work())
			{
				var forBD = cw.Database.SqlQuery<UsersBD>($"select * from UsersBD");
				foreach (var check in forBD)
				{
					if (LOGIN.Trim() == check.login.Trim())
					{
						USERID = check.userID;
					}
				}

				var forBDs = cw.Database.SqlQuery<Session>($"select * from Session where Session.sessionID = '{SESSID}'");
				foreach (var check in forBDs)
				{
					if (SESSID == check.sessionID)
					{
						var forFilm = cw.Database.SqlQuery<Film>($"select * from Film where Film.filmID = '{check.filmID}'");
						foreach (var i in forFilm)
						{
							FILMNAME = i.filmName.Trim();
							PRICE = check.price_for_place;
							DATE = check.date;
							TIME = check.time;
							NumberOfFreeSeats = check.number_of_free_seats;
						}
					}
				}
			}
		}
		private void Button_Click_Back(object sender, RoutedEventArgs e)
		{
			try
			{
				Close();
				SessionWPF session = new SessionWPF(ID, Admin, LOGIN, DATE);
				session.Show();
			}
			catch(Exception)
			{
				MessageBox.Show("Нет подключения к интернету ");
			}
		}
		private void Button_Buy_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				using (SQL_course_work cw = new SQL_course_work())
				{
					var forBD = cw.Database.SqlQuery<Ticket>($"select * from Ticket where Ticket.sessionID = '{SESSID}'");
					foreach (var check in forBD)
					{
						if (check.row == Convert.ToInt32(ComboBoxRow.Text) && check.place == Convert.ToInt32(ComboBoxPlace.Text))
						{
							valid = false;
						}
					}
					if (valid == true)
					{
						NumberOfFreeSeats--;
						Ticket ticket = new Ticket()
						{
							//
							sessionID = SESSID,
							userID = USERID,
							filmName = FILMNAME.Trim(),
							price = PRICE,
							date = DATE,
							time = TIME,
							row = Convert.ToInt32(ComboBoxRow.Text),
							place = Convert.ToInt32(ComboBoxPlace.Text)

						};
						cw.Ticket.Add(ticket);
						cw.SaveChanges();
						TicketsSingleton();
						MessageBox.Show("Запись прошла успешно.");
						SQL_course_work context = new SQL_course_work();
						var customer = context.Session
							.Where(c => c.sessionID == SESSID)
							.FirstOrDefault();
						customer.number_of_free_seats = NumberOfFreeSeats;
						context.SaveChanges();
					}
					else
					{
						MessageBox.Show("Место занято.");
					}

				}
			}
			catch(Exception)
			{
				MessageBox.Show("Ошибка");
			}
		}
	}
}
