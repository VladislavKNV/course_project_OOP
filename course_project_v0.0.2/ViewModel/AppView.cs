using GalaSoft.MvvmLight;


namespace course_project_v0._0._2.View
{
	class AppView : ViewModelBase
    {
        public string filmID { get; set; }
        public string filmname { get; set; }
        public string year { get; set; }
        public byte[] poster { get; set; }
        public string plotDescription { get; set; }
        public string genres { get; set; }
        public string rating { get; set; }
        public string countries { get; set; }
        public string director { get; set; }
        public string actors { get; set; }
        public string duration { get; set; }
        public string premiereDate { get; set; }

        public void AddPoster(byte[] _poster)
        {
            poster = _poster;

        }
        public void Add(string _filmname, int _year,string _genres, float _rating, string _countries, string _director, int _duration, byte[] _poster,int _filmID)
        {
            filmID = "" + _filmID;
            filmname = _filmname;
            year = "Год: " + (int)_year;
            genres = "Жанры: " + _genres;
            rating = "Рейтинг: " + (float)_rating;
            countries = "Страны: " + _countries;
            director = "Режисёр: " +  _director;
            duration = "Продолжительность: " +  (int)_duration;
            poster = _poster;

        }

        public void AddFilmsForAdmin(int _filmID, string _filmname, int _year,string _plotDescription, string _genres, float _rating, string _countries, string _director,string _actors, int _duration, byte[] _poster, string _premiereDate)
		{
            filmID = "" + _filmID;
            filmname = _filmname;
            year = "" + (int)_year;
            poster = _poster;
            plotDescription = _plotDescription;
            genres = _genres;
            rating = "" + (float)_rating;
            countries = _countries;
            director = _director;
            actors = _actors;
            duration = "" + (int)_duration;
            premiereDate = _premiereDate;
		}
    }

}
