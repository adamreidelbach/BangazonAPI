using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//Purpose: Contain computer info to then be used with the employeeController later
//Author: Team code

namespace BangazonAPI.Models
{
  public class Computer
  {
    [Key]
    public int ComputerId { get; set; }
    [Required]
    [DataType(DataType.Date)]
    public DateTime PurchaseDate { get; set; }
    public DateTime DecomissionDate { get; set; }
    public ICollection<ComputerEmployee> ComputerEmployees;

    //ANYTIME THIS CONSTRUCTOR IS RAN IT'LL AUTO CREATE THE CURRENT TIMESTAMP
    public Computer() {
      PurchaseDate = DateTime.Now;
    }

  }
}