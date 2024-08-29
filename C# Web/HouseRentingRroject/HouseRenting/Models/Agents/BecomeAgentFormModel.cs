using System.ComponentModel.DataAnnotations;
using static HouseRenting.Data.DataConstants.Agent;

namespace HouseRenting.Models.Agents
{
    public class BecomeAgentFormModel
    {
        [Required]
        [StringLength(PhoneNumberMaxLength, MinimumLength = PhoneNumberMinLength)]
        [Display(Name ="Phone number")]
        [Phone]
        public string PhoneNumber { get; set; } = null!;
    }
}
