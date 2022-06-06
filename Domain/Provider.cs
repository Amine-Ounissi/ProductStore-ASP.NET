using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Provider : Concept
    {
        private string confirmPassword { get; set; }
        [DataType(DataType.Password)]
        [Required]
        [NotMapped]
        [Compare("Password")]
        public string ConfirmPassword {
            get { return confirmPassword; }

            set {
                if (value.Equals(Password))
                    confirmPassword = value;
                else Console.WriteLine("erreur2!");

            }

        }
        public DateTime DateCreated { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        [DataType(DataType.Password),MinLength(8),Required]
        private string password;
       

        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length > 5 & value.Length < 20)
                    password = value;
                else
                    Console.WriteLine("err");
            }
        }

        public string UserName { get; set; }
        public virtual IList<Product> Products { get; set; }



        public override void GetDetails()
        {
            Console.WriteLine("Provider infos:\nUserName:" + UserName + "\nDateCreated:" + DateCreated + "\n");
            foreach (Product product in Products)
            {
                product.GetDetails();
            }

        }
        public static void SetIsApproved(string password, string confirmPassword, ref bool isApproved)
        {
            if (password == confirmPassword) { isApproved = true; }
            else { isApproved = false; }


        }
        public static void SetIsApproved(Provider P1)
        {
            P1.IsApproved = P1.Password.Equals(P1.ConfirmPassword);

        }

        /*public bool Login(string username, string password)
        {
            return username.Equals(UserName)&& password.Equals(Password);
        }*/
        public bool Login(string username, string password,string email=null)
        {
            if (email!=null)
                return username.Equals(UserName) && password.Equals(Password) && email.Equals(Email);
            else
                return username.Equals(UserName) && password.Equals(Password);
        }

        public void GetProducts(string filterType, string filterValue)
        {
            switch(filterType){
                case "Name":
                    foreach(Product pr in Products)
                    {
                        if(pr.Name.Equals(filterValue))
                            pr.GetDetails();
                    }
                    break;
                case "Dateprod":
                    foreach(Product pr in Products) 
                    {
                        if (pr.DateProd == DateTime.Parse(filterValue))
                            pr.GetDetails();
                       
                    }
                    break;
                case "Price":
                    foreach (Product pr in Products)
                    {
                        if (pr.Price ==double.Parse(filterValue))
                            pr.GetDetails();
                    }
                    break;


            }


        }

    }
}
