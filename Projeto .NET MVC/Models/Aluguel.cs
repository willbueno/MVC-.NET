namespace Projeto.NET_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Aluguel")]
    public partial class Aluguel
    {
        public int Id { get; set; }

        public int Id_customer { get; set; }

        public int Id_movie { get; set; }

        public DateTime date { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
