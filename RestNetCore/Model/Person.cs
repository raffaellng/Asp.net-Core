﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestNetCore.Model
{
    [Table("person")]
    public class Person
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long Id { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName{ get; set; }

        [Column("gender")]
        public string Gender{ get; set; }

        [Column("address")]
        public string Address{ get; set; }
    }
}
