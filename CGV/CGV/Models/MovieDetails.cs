using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGV.Models
{
	[Table("MovieDetails")]
	public class MovieDetails
	{
		public string IDMovie { get; set; }
		public string IDCategory { get; set; }
		
		//public Movie Movie { get; set; }
		public FilmGenre FilmGenre { get; set; }
	}
}
