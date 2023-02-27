using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreSqlDb.Models
{
    public class Todo
    {
        private DateTime _releaseDate;

        public int ID { get; set; }
        public string Description { get; set; }


        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get { return _releaseDate; } set {
      // for opting into timestamp with time zone (timestamptz) PostgreSQL type
      // stored as UTC timestamp e.g. 'Tue, 17 Jan 2023 20:29:14 GMT' (no explicit time zone)
      // https://www.npgsql.org/doc/types/datetime.html#net-types-and-postgresql-types
      _releaseDate = DateTime.SpecifyKind(value, DateTimeKind.Utc);
  } }
    }
}

