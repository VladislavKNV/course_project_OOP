using System;
using System.Linq;
using course_project_v0._0._2.DataBase;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Text;

namespace course_project_v0._0._2.View
{
	public partial class SessionWPF : Window
	{
		public int FilmID;
		public SessionWPF(int ID, bool admin, string login, DateTime _date)
		{
			InitializeComponent();
			FilmID = ID;
			ADMIN = admin;
			LOGIN = login;
			DateSession = _date;
			InfoForFilms();
			AddPost();
			InfoForListBox();
		}

		public DateTime DateSession;
		public string NameF;
		public int Year;
		public string Plot;
		public string Genres;
		public float Rating;
		public string Countries;
		public string Director;
		public string Actors;
		public int Duration;
		public string PremiereDate;
		public byte[] Poster;
		public bool ADMIN;
		public string LOGIN;
		public int IDSession;
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
				MessageBox.Show("Ошибка");
			}
		}
		public void InfoForFilms()
		{
			using (SQL_course_work cw = new SQL_course_work())
			{
				var forBD = cw.Database.SqlQuery<Film>($"select * from film where Film.filmID = '{FilmID}'");
				foreach (var check in forBD)
				{
					NameF = check.filmName;
					Year = (int)check.year;
					Plot = check.plotDescription;
					Genres = check.genres;
					Rating = (float)check.rating;
					Countries = check.countries;
					Director = check.director;
					Actors = check.actors;
					Duration = (int)check.duration;
					PremiereDate = check.premiereDate;
					Poster = check.poster;
				}
			}
			FilmName.Text = NameF;
			FilmYear.Text = $"{Year}";
			FilmPlot.Text = Plot;
			FilmGenres.Text = Genres;
			FilmRating.Text = $"{Rating}";
			FilmCountries.Text = Countries;
			FilmDirector.Text = Director;
			FilmActros.Text = Actors;
			FilmDuration.Text = $"{Duration} минут";
			FilmPremiereDate.Text = PremiereDate;
		}
		private ObservableCollection<AppView> post;
		public void AddPost()
		{
			post = new ObservableCollection<AppView>();
			AppView posterfilm = new AppView();
			posterfilm.AddPoster(Poster);
			post.Add(posterfilm);
			ListBoxPoster.ItemsSource = post;
		}
		private ObservableCollection<AppViewSession> infoforsession;
		public void InfoForListBox()
		{
			TimeSpan timenow = new TimeSpan(0, 0, 0);
			try
			{
				StringBuilder bild = new StringBuilder($"{DateTime.Now}");
				Console.WriteLine(bild);
				bild.Remove(0, 11);
				bild.Remove(2, 6);

				StringBuilder bild2 = new StringBuilder($"{DateTime.Now}");
				bild2.Remove(0, 14);
				bild2.Remove(2, 3);

				string strr1 = Convert.ToString(bild);
				string strr2 = Convert.ToString(bild2);
				int h = Convert.ToInt32(strr1);
				int min = Convert.ToInt32(strr2);
				timenow = new TimeSpan(h, min, 0);
			}
			catch(Exception)
			{
				StringBuilder bild = new StringBuilder($"{DateTime.Now}");
				Console.WriteLine(bild);
				bild.Remove(0, 11);
				bild.Remove(1, 6);

				StringBuilder bild2 = new StringBuilder($"{DateTime.Now}");
				bild2.Remove(0, 13);
				bild2.Remove(2, 3);

				string strr1 = Convert.ToString(bild);
				string strr2 = Convert.ToString(bild2);
				int h = Convert.ToInt32(strr1);
				int min = Convert.ToInt32(strr2);
				timenow = new TimeSpan(h, min, 0);
			}
			using (SQL_course_work cw = new SQL_course_work())
			{
				var info = cw.Session.ToList();
				infoforsession = new ObservableCollection<AppViewSession>();
				foreach (var i in info)
				{
					if (i.date == DateSession && i.filmID == FilmID)
					{
						if (timenow < i.time)
						{
							AppViewSession allSession = new AppViewSession();
							var forBD = cw.Database.SqlQuery<Film>($"select * from film where Film.filmID = '{i.filmID}'");
							foreach (var check in forBD)
							{
								allSession.InfoForListBox(i.sessionID, i.filmID, i.date, i.time, i.hallID, i.number_of_free_seats, i.price_for_place, check.filmName, i.End_date, i.End_time);
								infoforsession.Add(allSession);
							}
						}
					}
				}
				ListBoxSession.ItemsSource = infoforsession;
			}
		}
		private void ListBoxSession_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			try
			{
				var contentForListBox = ListBoxSession.SelectedItem as AppViewSession;
				if (contentForListBox != null)
				{
					IDSession = Convert.ToInt32(contentForListBox.sessionID);
					TicketWPF ticketWPF = new TicketWPF(LOGIN, IDSession, ADMIN, FilmID);
					ticketWPF.Show();
					this.Close();
				}
			}
			catch(Exception)
			{
				MessageBox.Show("Ошибка ");
			}
			
		}

	}
}