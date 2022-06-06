using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Text;

namespace Domain
{
	public class Product : Concept
	{		
		[Display(Name = "Production Date")]
		[DataType(DataType.Date)]
		public DateTime DateProd { get; set; }
		[DataType(DataType.MultilineText)]
		public String Description { get; set; }
		[Required(ErrorMessage = "le champ name est obligatoire")]
		[MaxLength(50, ErrorMessage = "la taille max dans BDD est 50")]
		[StringLength(25, ErrorMessage = "la taille max saisie est 25")]
		public String Name { get; set; }
		[DataType(DataType.Currency)]
		public Double Price { get; set; }
		public int ProductId { get; set; }
		[Range(0, int.MaxValue)]
		public int Quantity { get; set; }
		[ForeignKey("MyCategory")]
		public int? CategoryId { get; set; }
		public virtual Category MyCategory { get; set; }
		public virtual IList<Provider> Providers { get; set; }
		public virtual IList<Facture> Facture { get; set; }
		public string Image { get; set; }
		//public Category Category { get; set; }

		public PackagingType MyPackagingType { get; set; } 

		public override void GetDetails()
		{
			Console.WriteLine("Product Name : {0} , Quantitée {1} , Category {2}", Name, Quantity, MyCategory.Name);
		}

		public virtual void GetMyType()
		{
			Console.WriteLine("UNKONWN");
		}

		private PropertyInfo[] _PropertyInfos = null;

		public override string ToString()
		{
			if (_PropertyInfos == null)
				_PropertyInfos = this.GetType().GetProperties();

			var sb = new StringBuilder();

			foreach (var info in _PropertyInfos)
			{
				var value = info.GetValue(this, null) ?? "(null)";
				sb.AppendLine(info.Name + ": " + value.ToString());
			}

			return sb.ToString();
		}
	}
}
