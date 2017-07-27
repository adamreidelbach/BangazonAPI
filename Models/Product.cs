using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BangazonAPI.Models
{
  public class Product
  {
    [Key]
    public int ProductId { get; set; }
    [Required]
    public int ProductTypeId { get; set; }
    public ProductType ProductType { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public float Price { get; set; }
    [Required]

    [ForeignKey("Customer")] 
    public int SellerId { get; set; } // this is the same as CustomerId
    public Customer Customer { get; set; }
    public virtual ICollection<OrderProduct> OrderProducts {get; set;}
  }
}