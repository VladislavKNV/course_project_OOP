using course_project_v0._0._2.View;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using course_project_v0._0._2.DataBase;

namespace course_project_v0._0._2
{
	public partial class MainWindow : Window
	{
		public MainWindow(bool admi, string login)
		{
            InitializeComponent();
            ADMIN = admi;
            LOGIN = login;
			if (ADMIN == false)
			{
                ButtonForAdmin.Visibility = Visibility.Hidden;
            }
            DateForPicker();
            check_free_seats();
            InfoForListBox();
        }
        public bool ADMIN;
        public string LOGIN { get; set; }
        public void DateForPicker()
		{
             Datepic.SelectedDate = DateTime.Now;
        }
        private ObservableCollection<AppView> infoforfilm;
        public void InfoForListBox()
        {
            using (SQL_course_work cw = new SQL_course_work())
            {
                int[] idFilms = new int[50];
                bool coincidence = true;
                var info = cw.Film.ToList();
                infoforfilm = new ObservableCollection<AppView>();
                var forBD = cw.Database.SqlQuery<Session>($"select * from Session");
                foreach (var check in forBD)
                {
					if (check.date == Datepic.SelectedDate.Value)
					{
                        
                        foreach (var i in info)
                        {
                            for (int f = 0; f < idFilms.Length; f++)
                            {
								if (idFilms[f] == Convert.ToInt32(i.filmID))
								{
                                    coincidence = false;
								}
                            }
                            if (i.filmID == check.filmID && coincidence == true)
                            {
                                AppView allFilms = new AppView();
                                allFilms.Add(i.filmName, (int)i.year, i.genres, (float)i.rating, i.countries, i.director, (int)i.duration, i.poster, i.filmID);
                                infoforfilm.Add(allFilms);
                                for (int n = 0; n < idFilms.Length; n++)
								{
                                    if (n == 0)
                                    {
                                        if (idFilms[n] == 0)
                                        {
                                            idFilms[n] = Convert.ToInt32(i.filmID);
                                        }
                                    }
                                    bool fi = true;
									if (idFilms[n] == 0 && n != 0)
									{
                                        for (int o = 0; o < idFilms.Length; o++)
                                        {
											if (idFilms[o] == Convert.ToInt32(i.filmID))
                                            {
                                                fi = false;
											}
                                        }
                                        if (idFilms[n] != Convert.ToInt32(i.filmID) && fi == true)
										{
                                        idFilms[n] = Convert.ToInt32(i.filmID);
                                        }
                                    }

                                }
                            }
                            coincidence = true;
                        }
                        
                    }
                }
                ListBoxFilms.ItemsSource = infoforfilm;
            }
        }

		private void Button_Click_Admin(object sender, RoutedEventArgs e)
		{
			try
			{
                this.Close();
                AdminAddFilm adminAddFilm = new AdminAddFilm(ADMIN, LOGIN);
                adminAddFilm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }
          
        private void Button_Click_Feedback(object sender, RoutedEventArgs e)
        {
			try
			{
                this.Close();
                FeedbackWPF feedbackWPF = new FeedbackWPF(ADMIN, LOGIN);
                feedbackWPF.Show();

            }
            catch(Exception)
			{
                MessageBox.Show("Ошибка");
			}
            
        }

        private void ListBoxFilms_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			try
			{
                var contentForListBox = ListBoxFilms.SelectedItem as AppView;
                if (contentForListBox != null)
                {
                    SessionWPF sessionWPF = new SessionWPF(Convert.ToInt32(contentForListBox.filmID), ADMIN, LOGIN, Datepic.SelectedDate.Value);
                    sessionWPF.Show();
                    this.Close();
                }
            }
            catch(Exception)
			{
                MessageBox.Show("Ошибка ");
			}
           
        }
		private void Datepic_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
            InfoForListBox();
        }
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
             Datepic.BlackoutDates.AddDatesInPast();
        }
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			try
			{
                BasketWPF basketWPF = new BasketWPF(LOGIN, ADMIN);
                basketWPF.Show();
                this.Close();
            }
			catch
			{
                MessageBox.Show("Ошибка");
			}
          
		}

        public void check_free_seats()
		{
            using (SQL_course_work cw = new SQL_course_work())
            {
                int seats = 0;
                var forBD = cw.Database.SqlQuery<Session>($"select * from Session");
                foreach (var check in forBD)
                {
                    var fortic = cw.Database.SqlQuery<Ticket>($"select * from Ticket where Ticket.sessionID = '{check.sessionID}'");
                    foreach (var i in fortic)
                    {
						if (i.sessionID == check.sessionID)
						{
                            seats++;
						}
                    }

                    SQL_course_work context = new SQL_course_work();
                    var customer = context.Session
                        .Where(c => c.sessionID == check.sessionID)
                        .FirstOrDefault();
                   
                        customer.number_of_free_seats = (90 - seats);
                    context.SaveChanges();
                }
            }
         }
    }
}
