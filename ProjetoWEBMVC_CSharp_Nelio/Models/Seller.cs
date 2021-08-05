using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ProjetoWEBMVC_CSharp_Nelio.Models
{
    public class Seller
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} required")]
        [StringLength(60,MinimumLength =3,ErrorMessage ="{0} {2}-60")]
        public string Name { get; set; }


        [EmailAddress(ErrorMessage ="Enter email valid")]
        [Required(ErrorMessage = "{0} required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }



        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }


        [Range(100.0,50000.0,ErrorMessage ="{0} deve ser {1} to {2}")]
        [Required(ErrorMessage = "{0} required")]
        [Display(Name="Base Salary")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double BaseSalary { get; set; }

        public Departament Departament { get; set; }

        public int DepartamentId { get; set; }

        public ICollection<SalesRecords> Sales { get; set; } = new List<SalesRecords>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Departament departament)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddSales(SalesRecords sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecords sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales
                .Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
