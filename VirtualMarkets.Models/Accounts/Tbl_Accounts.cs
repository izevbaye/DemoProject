using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DemoProject.Models.Accounts
{
    public class Tbl_Accounts
    {
    }

    public class Tbl_Users
    {
        [Key]
        public int AccountID { get; set; }

        [ForeignKey("ASPNetUsers")]
        public string ASPNetID { get; set; }
        //   public string Email { get; set; }
        public string Account_Type { get; set; }
        // public int AccountID { get; set; }
        public Guid UniqueID { get; set; }
        public DateTime Dates { get; set; }
        public bool IsSuspended { get; set; }

        [ForeignKey("UserID")]
        public Tbl_Users_Accounts_Address Tbl_Users_Accounts_Address { get; set; }

        [ForeignKey("UserID")]
        public Tbl_Users_Accounts Tbl_Users_Accounts { get; set; }

         
    }
    public class Tbl_Users_Accounts
    {
        [Key]
        public int AccountID { get; set; }
        public Guid UniqueID { get; set; }
        public int UserID { get; set; }
        //[EnumDataType(typeof(string), ErrorMessage = "{0} Opps")]
        //public Title Title { get; set; }

       // [ForeignKey("ASPNetUsers")]
        [Display(Name = "Email Address")]
       // [EmailAddress]
        [RegularExpression("^[_A-Za-z'`+-.]+([_A-Za-z0-9'+-.]+)*@([A-Za-z0-9-])+(\\.[A-Za-z0-9]+)*(\\.([A-Za-z]*){3,})$", ErrorMessage = "Enter proper email")]
        [Required(ErrorMessage = "Please enter your Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "The email is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your chosen Username")]
        [StringLength(50, MinimumLength = 6)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter the First name")]
        [StringLength(50, MinimumLength = 2)]
        public string First_Name { get; set; }
        [Required(ErrorMessage = "Please enter the last name")]
        [StringLength(50, MinimumLength = 2)]
        public string Last_Name { get; set; }
        //   public Gender Gender { get; set; }
        //  public Users_Phone Users_Phone { get; set; }

      //  [ForeignKey("Users_AddressManager_Virtual_Mobile")]
     //   [DataType(DataType.PhoneNumber)]
      //  [Display(Name = "Mobile Number")]
        public string Mobile { get; set; }

        public string Title { get; set; }

      //  [ForeignKey("ASPNetUsers")]
        public string ASPNetID { get; set; }
     //   [ForeignKey("ASPNetUsers")]
        //  public string Email { get; set; }

        public string Account_Type { get; set; }
        public DateTime Dates { get; set; }
        public bool IsSuspended { get; set; }

        [ForeignKey("UserID")]
        public Tbl_Users Tbl_Users { get; }
    }
    public class _Users_Accounts_INSERT
    {
        [Key]
        public int AccountID { get; set; }
        public Guid UniqueID { get; set; }
        public int UserID { get; set; }

        [Required(ErrorMessage = "Please enter your chosen Username")]
        [StringLength(50, MinimumLength = 6)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter the first name")]
        [StringLength(50, MinimumLength = 2)]
        public string First_Name { get; set; }

        [Required(ErrorMessage = "Please enter the last name")]
        [StringLength(50, MinimumLength = 2)]
        public string Last_Name { get; set; }


        public string Title { get; set; }

        [ForeignKey("ASPNetUsers")]
        public string ASPNetID { get; set; }
        [ForeignKey("ASPNetUsers")]
        [Display(Name = "Email Address")]
        [EmailAddress]
        [RegularExpression("^[_A-Za-z'`+-.]+([_A-Za-z0-9'+-.]+)*@([A-Za-z0-9-])+(\\.[A-Za-z0-9]+)*(\\.([A-Za-z]*){3,})$", ErrorMessage = "Enter proper email")]
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "The email is not valid")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Mobile Number")]
        public string Mobile { get; set; }
        public string Gender { get; set; }
        public string Account_Type { get; set; }
    }
    public enum Gender
    {
        male = 1, female = 2

    }
    public class Peronal
    {
        public Gender Gender { get; set; }
        public string Email { get; set; }

    }
    public enum Title
    {
        //Mr, Mrs, Miss, Chief 

        Mr = 1,
        Mrs = 2,
        Miss = 3,
        Chief = 4,
        Sir = 5,
        Madam = 6,
        Other = 7

    }
    public enum AddressType
    {
        Home = 1, Shipping = 2, Billing = 3, Default = 4, Deliver_to_Neighbour = 5
    }
    public struct ConvertEnum
    {
        public int Value
        {
            get;
            set;
        }
        public String Text
        {
            get;
            set;
        }
    }

    public class Tbl_Users_Accounts_Address
    {
        [Key]
        public int AccountID { get; set; }

        public string Email { get; set; }
        public string ASPNetID { get; set; }
        //  public string Title { get; set; }
        //  public string First_Name { get; set; }
        //  public string Last_Name { get; set; }

        ////  public string Gender { get; set; }
        //  public Gender Gender { get; set; }

        [ForeignKey("UserID")]
        public Tbl_Users Tbl_Users { get; set; }
        public string Flat_Name { get; set; }
        public string Building_Number { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string Post_Code { get; set; }
        public string Country { get; set; }
        public bool IsDefault { get; set; }

        public bool IsActive { get; set; }

        public string AddressType { get; set; } //------------------AddressType

    }


    public class Users_Phone
    {
        [Key]
        public int PhoneID { get; set; }
        public int AccountID { get; set; }
        // public int LandLine { get; set; }
        public string Phone_Nummber { get; set; }
        //public int Phone_Other { get; set; }
        public bool IsActive { get; set; }
    }
    public class Socials_and_Email
    {
        [Key]
        public string Account { get; set; }

    }
    public class Edit_User_Accounts
    {
        [Key]
        public string Account { get; set; }
        public string Email { get; set; }

        [ForeignKey("ASPNetUsers")]
        public string ASPNetID { get; set; }
    }

    public class Add_Users_Accounts_Address
    {
        [Key]
        // public string AccountID { get; set; }
        public string ASPNetID { get; set; }
        public string Email { get; set; }

        public string AccountID { get; set; }

        //[Required]
        //[DataValidate(ErrorMessage = "O campo DATA DE NASCIMENTO é inválido")]
        public string Flat_Name { get; set; }
        [Required(ErrorMessage = "Your House number is Required")]

        public string Building_Number { get; set; } //not int,, because you can have 1a or 1c
        [Required(ErrorMessage = "Please enter the first line of your address")]
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        //public string Address3 { get; set; }
        [Required(ErrorMessage = "Your county is required")]
        public string County { get; set; }
        [Required(ErrorMessage = "Your city is required")]
        public string City { get; set; }
        [Required(ErrorMessage = "Post Code is required")]
        [DataType(DataType.PostalCode)]
        public string Post_Code { get; set; }
        public string Country { get; set; }
        public bool IsDefault { get; set; }

        [Required(ErrorMessage = "Please select one from the dropdownlist")]
        public string AddressType { get; set; }

    }
}
