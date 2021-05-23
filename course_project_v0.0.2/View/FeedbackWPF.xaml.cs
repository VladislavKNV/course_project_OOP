using System;
using System.Linq;
using System.Windows;
using course_project_v0._0._2.DataBase;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Net.Sockets;
using System.IO;

namespace course_project_v0._0._2.View
{
	public partial class FeedbackWPF : Window
	{
		public FeedbackWPF(bool admin, string login)
		{
			LOGIN = login;
			ADMIN = admin;
			InitializeComponent();
			InfoForFeedback();
			userid();
		}
		public bool ADMIN;
		public bool rev = false;
		public string LOGIN;
		public int USERid;
		private void Button_Click_Save(object sender, RoutedEventArgs e)
		{
			try
			{
				using (SQL_course_work cw = new SQL_course_work())
				{
					if (rev == true)
					{
						Feedback feedback = new Feedback()
						{
							//
							userID = USERid,
							feedback1 = Feedback_TextBox.Text.Trim(),
							login = LOGIN.Trim(),
							dateFeedback = DateTime.Now,
						};
						cw.Feedback.Add(feedback);
						cw.SaveChanges();
					}
				}
				MessageBox.Show("Спасибо за отзыв.");
				InfoForFeedback();
			}
			catch(Exception)
			{
				MessageBox.Show("Нет подключения к интернету");
			}
		}
		private ObservableCollection<AppViewFeedback> infoforfeedback;
		public void InfoForFeedback()
		{
			using (SQL_course_work cw = new SQL_course_work())
			{
				var info = cw.Feedback.ToList();
				infoforfeedback = new ObservableCollection<AppViewFeedback>();
				foreach (var i in info)
				{
					AppViewFeedback allFeedback = new AppViewFeedback();

					allFeedback.AddFeedback(i.login, i.feedback1, i.dateFeedback, i.feedbackID);
					infoforfeedback.Add(allFeedback);
				}
				ListBoxFeedbacks.ItemsSource = infoforfeedback;
			}
		}
		public void	userid()
		{
			using (SQL_course_work cw = new SQL_course_work())
			{
				var forenter = cw.Database.SqlQuery<UsersBD>($"select * from UsersBD");
				foreach (var check in forenter)
				{
					if (check.login == LOGIN)
					{
						USERid = check.userID;
					}
				}
			}
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
		private void RevTextBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			string pattern = @"\b\w{1,3000}\b";
			if (Regex.IsMatch(Feedback_TextBox.Text, pattern, RegexOptions.IgnoreCase))
			{
				rev = true;
			}
			else
			{
				rev = false;
			}
		}
	}
}
