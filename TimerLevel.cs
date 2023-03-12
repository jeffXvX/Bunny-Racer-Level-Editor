using System.ComponentModel.DataAnnotations;

public class TimerLevel
{
	[Required]
	[Range(1,9999, ErrorMessage ="Timer must be 1-9999")]
	public int Timer { get; set; }


	[Required]
	[Range(1, 20, ErrorMessage = "Level must be 1-20")]
	public int Level { get; set; }

}