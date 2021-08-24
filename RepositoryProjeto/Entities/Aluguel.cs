using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace RepositoryProjeto.Entities
{

    [Table("Aluguel")]
    public partial class Aluguel : Entity
    {
        public int Id { get; set; }

        public int Id_customer { get; set; }

        public int Id_movie { get; set; }

        public DateTime date { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Movie Movie { get; set; }
    }

    public class AluguelView
    {
        public string CustomerName { get; set; }
        public string MovieName { get; set; }
        public int MovieId { get; set; }
    }
}
