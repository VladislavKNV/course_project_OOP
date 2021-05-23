using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using System.Threading.Tasks;

namespace course_project_v0._0._2.View
{
	class AppViewSession : ViewModelBase
	{
		public string sessionID { get; set; }
		public string filmID { get; set; }
		public string filmName { get; set; }
		public string DateForInfo { get; set; }
		public string TimeForInfo { get; set; }
		public string Info_number_of_free_seats { get; set; }
		public string Info_price { get; set; }
		public string hall { get; set; }
		public string End_Time { get; set; }
		public string End_Date { get; set; }


		public void InfoForListBox(int _sessionID, int _filmID, DateTime _date, TimeSpan _time, int _hall, int _number_of_free_seats, int _price, string _filmname, DateTime _endDate, TimeSpan _endTime)
		{
			StringBuilder bild = new StringBuilder($"{_date}");
			StringBuilder bildtime = new StringBuilder($"{_time}");
			StringBuilder bild2 = new StringBuilder($"{_endDate}");
			StringBuilder bildtime2 = new StringBuilder($"{_endTime}");
			bild.Remove(10, 8);
			bildtime.Remove(5, 3);
			bild2.Remove(10, 8);
			bildtime2.Remove(5, 3);
			sessionID = "" +_sessionID;
			filmID = "ID фильма: " + _filmID;
			DateForInfo ="Дата: " +  bild;
			TimeForInfo = "Время: " +  bildtime;
			hall = "Зал: " + _hall;
			Info_number_of_free_seats = "Количество свободных мест: " + _number_of_free_seats;
			Info_price ="Цена билета: " + _price + " рублей";
			filmName = "Название фильма: " + _filmname;
			End_Date = "Дата окончания сеанса: " + bild2;
			End_Time = "Время окончания сеанса: " + bildtime2;
		}
	}
}
