using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace course_project_v0._0._2.View
{
	class AppViewFeedback : ViewModelBase
	{
		public string FeedbackID { get; set; }
		public string login { get; set; }
		public string feedback { get; set; }
		public string dateFeedback { get; set; }

		public void AddFeedback(string _login, string _feedback, DateTime _dateFeedback, int _feedbackID)
		{
			StringBuilder bild = new StringBuilder($"{_dateFeedback}");
			bild.Remove(10, 8);
			login = "Пользователь: " +_login;
			feedback ="Отзыв: " + _feedback;
			dateFeedback = "Дата: " + bild;
			FeedbackID = "" + _feedbackID;

		}
	}
}
