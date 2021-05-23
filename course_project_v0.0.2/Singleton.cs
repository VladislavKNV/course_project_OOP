using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using course_project_v0._0._2.View;

namespace course_project_v0._0._2
{
	public sealed class Singleton
	{
		Sing_Up sing_Up = new Sing_Up();
		public Brush bgColor;
		public Singleton()//получ знач формы и выводит 
		{
			bgColor = sing_Up.Background;
			
		}
		private static Singleton _instance;
		public static Singleton GetInstance()//что-нибудь придумать
		{
			if (_instance == null)
			{
				_instance = new Singleton();
			}
			return _instance;
		}
	}
}
