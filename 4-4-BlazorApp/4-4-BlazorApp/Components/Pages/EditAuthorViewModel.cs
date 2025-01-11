using System.ComponentModel.DataAnnotations;


[CustomValidation(typeof(EditAuthorViewModel), "NameAndPhoneCheck")]
public class EditAuthorViewModel
{
	[Display(Name = "著者ID")]

	public string AuthorId { get; set; } = string.Empty;
	[Display(Name = "著者名（名）")]
	[Required(ErrorMessage = "著者名（名）は必須入力です。")]
	public string AuthorFirstName { get; set; } = string.Empty;
	[Display(Name = "著者名（姓）")]
	[Required(ErrorMessage = "著者名（姓）は必須入力です。")]
	public string AuthorLastName { get; set; } = string.Empty;
	[Display(Name = "電話番号")]
	[Required(ErrorMessage = "電話番号は必須入力です。")]
	[RegularExpression(@"^\d{3} \d{3}-\d{4}$", ErrorMessage ="電話番号は012 345-6789のように入力してください。")]
	public string Phone { get; set; } = string.Empty;

	public static ValidationResult NameAndPhoneCheck(EditAuthorViewModel vm, ValidationContext ctx)
	{
		if (vm.AuthorFirstName == "Nobuyuki" && vm.AuthorLastName == "Akama")
			return new ValidationResult("Nobuyuki Akama という名前は入力済みのため登録できません。", new List<string>() { "AuthorFirstName", "AuthorFirstName" });
		return ValidationResult.Success;
	}
}

