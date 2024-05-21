    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    namespace Party.Models
    {
        public class Birthday
        {
            public int Id { get; set; }
            [Required(ErrorMessage = "Sissesta pidu siia")]
            public string Nimetus { get; set; }

            [Required(ErrorMessage = "Sissesta paäev siia")]
        [   DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            public DateTime Date { get; set; }

            public string Notes { get; set; }
        }



    }