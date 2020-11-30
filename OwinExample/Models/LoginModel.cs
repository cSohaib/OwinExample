using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace OwinExample.Models
{
    public class LoginModel
	{
		[Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[HiddenInput]
		[ScaffoldColumn(false)]
		public string ReturnUrl { get; set; }
	}
}