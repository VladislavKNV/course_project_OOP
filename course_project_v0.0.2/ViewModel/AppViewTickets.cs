using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace course_project_v0._0._2.View
{
	class AppViewTickets : ViewModelBase
	{
		public string TicketID { get; set; }
		public string SessionID { get; set; }
		public string UserID { get; set; }
		public string FilmName { get; set; }
		public string price { get; set; }
		public string Date { get; set; }
		public string Time { get; set; }
		public string Row { get; set; }
		public string Place { get; set; }
		public byte[] poster { get; set; }

		public void InfoForTickets(int _ticketID, int _sessionID, int _userID, string _filmName, int _price, DateTime _date, TimeSpan _time, int _row, int _place, byte[] _poster)
		{
			StringBuilder bild = new StringBuilder($"{_date}");
			StringBuilder bildtime = new StringBuilder($"{_time}");
			bild.Remove(10, 8);
			bildtime.Remove(5, 3);
			TicketID = "" + _ticketID;
			UserID = "" + _userID;
			SessionID = "" + _sessionID;
			FilmName = "Фильм: " + _filmName;
			Date = "Дата: " + bild;
			Time = "Время: " + bildtime;
			Row = "Ряд: " + _row;
			Place = "Место: " + _place;
			price = "Цена билета: " + _price;
			poster = _poster;
		}

		public void InfoForAdminTickets(int _ticketID, int _sessionID, int _userID, string _filmName, int _price, DateTime _date, TimeSpan _time, int _row, int _place)
		{
			StringBuilder bild = new StringBuilder($"{_date}");
			StringBuilder bildtime = new StringBuilder($"{_time}");
			bild.Remove(10, 8);
			bildtime.Remove(5, 3);
			TicketID ="" +  _ticketID;
			UserID = "ID пользователя: " +_userID;
			SessionID = "ID сеанса: " + _sessionID;
			FilmName = "Фильм: " + _filmName;
			Date = "Дата: " + bild;
			Time = "Время: " + bildtime;
			Row = "Ряд: " + _row;
			Place = "Место: " + _place;
			price = "Цена билета: " + _price;
		}
	}

}
