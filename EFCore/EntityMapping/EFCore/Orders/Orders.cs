using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EFCore.EntityMapping.Categories
{
    [Serializable]
    [Table("Orders")]
    public class Orders
    {

        [Key]
        [Column("OrderID")]
        public int Id { get; set; }

        [Column("CustomerID")]
        public string CustomerID { get; set; }

        [Column("EmployeeID")]
        public int EmployeeID { get; set; }
        [Column("OrderDate")]
        public DateTime OrderDate { get; set; }
        [Column("RequiredDate")]
        public DateTime RequiredDate { get; set; }
        [Column("ShippedDate")]
        public DateTime? ShippedDate { get; set; }
        [Column("ShipVia")]
        public int ShipVia { get; set; }
        [Column("Freight")]
        public decimal Freight { get; set; }
        [Column("ShipName")]
        public string ShipName { get; set; }
        [Column("ShipAddress")]
        public string ShipAddress { get; set; }
        [Column("ShipCity")]
        public string ShipCity { get; set; }
        [Column("ShipRegion")]
        public string ShipRegion { get; set; }
        [Column("ShipPostalCode")]
        public string ShipPostalCode { get; set; }
        [Column("ShipCountry")]
        public string ShipCountry { get; set; }


        [NotMapped]
        public int EntityId
        {
            get { return Id; }
            set { Id = value; }
        }
    }
}
