using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Text.RegularExpressions;
using course_project_v0._0._2.DataBase;
using System.Security.Cryptography;
using System;

namespace course_project_v0._0._2
{
	public partial class Sing_In : Window
	{
		public Sing_In()
		{
			InitializeComponent();
		}
		private void Button_Click_Reg(object sender, RoutedEventArgs e)
		{
			try
			{
				Sing_Up sing_Up = new Sing_Up();
				sing_Up.Show();
			}
			catch(Exception)
			{
				MessageBox.Show("Ошибка");
			}
		}
		private void Button_Click_Sing_In(object sender, RoutedEventArgs e)
		{
			//Hide();

			if (loginbool == false)
			{
				LoginLabel.Content = "Неверный логин.";
			}
			if (passbool == false)
			{
				PassLabel.Content = "Неверный пароль.";
			}
			if (loginbool == true && passbool == true)
			{
				using (SQL_course_work cw = new SQL_course_work())
				{
					var forBD = cw.Database.SqlQuery<UsersBD>($"select * from UsersBD where UsersBD.login = '{TextBoxLogin.Text.Trim()}'");
					foreach (var check in forBD)
					{
						if (check.login.Trim() == TextBoxLogin.Text.Trim())
						{
							if (check.password.Trim() == GetHashPassword(PasswordBox.Password.Trim()))
							{
								try
								{
									loginbool_for_sing_In = true;
									MainWindow mainWindow = new MainWindow(check.admin, check.login);
									mainWindow.Show();
								}
								catch(Exception)
								{
									MessageBox.Show("Нет подключения к интернету");
								}
							}
							else
							{
								PassLabel.Content = "Неверный логин или пароль.";
								LoginLabel.Content = "Неверный логин или пароль.";
							}	
						}
					}
					if (loginbool_for_sing_In == false)
					{
						LoginLabel.Content = "Неверный логин или пароль.";
						PassLabel.Content = "Неверный логин или пароль.";
					}
				}
			}
		}

		public bool loginbool = false;
		public bool loginbool_for_sing_In = false;
		public bool passbool = false;
		private void LoginTextBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			string pattern = @"\b\w{4,20}\b";

			if (Regex.IsMatch(TextBoxLogin.Text, pattern, RegexOptions.IgnoreCase))
			{
				TextBoxLogin.BorderBrush = Brushes.LimeGreen;
				loginbool = true;
				LoginLabel.Content = null;
			}
			else
			{
				TextBoxLogin.BorderBrush = Brushes.DarkRed;
				loginbool = false;
			}
		}
		private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
		{
			string pattern = @"\b\w{4,20}\b";
			if (Regex.IsMatch(PasswordBox.Password, pattern, RegexOptions.IgnoreCase))
			{
				PasswordBox.BorderBrush = Brushes.LimeGreen;
				PassLabel.Content = null;
				passbool = true;
			}
			else
			{
				PasswordBox.BorderBrush = Brushes.DarkRed;
				passbool = false;
			}

		}
		private string GetHashPassword(string s)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(s);
			MD5CryptoServiceProvider CSP =
				new MD5CryptoServiceProvider(); 
			byte[] byteHash = CSP.ComputeHash(bytes);
			string hash = string.Empty;
			foreach (byte b in byteHash)
			{
				hash += string.Format("{0:x2}", b);
			}
			return hash;
		}
	}
}
