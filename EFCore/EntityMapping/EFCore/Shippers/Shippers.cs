using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EFCore.EntityMapping.Categories
{
    [Serializable]
    [Table("Shippers")]
    public class Shippers
    {

            [Key]
            [Column("ShipperID")]
            public int Id { get; set; }

            [Column("CompanyName")]
            public string CompanyName { get; set; }

            [Column("Phone")]
            public string Phone { get; set; }


            [NotMapped]
            public int EntityId
            {
                get { return Id; }
                set { Id = value; }
            }
        }
    }

