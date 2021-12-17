using System;
using System.ComponentModel.DataAnnotations;
 
namespace WebApplication.Domain.Entities
{
    public abstract class EntityBase
    {
        [Required]
        public Guid Id { get; set; }
        
        public virtual string Title { get; set; }

        [Display(Name = "Text")]
        public virtual string Text { get; set; }
        
        [Display(Name = "Name")]
        public virtual string NameChar { get; set; }
         
        [Display(Name = "Rank")]
        public virtual string NameRank { get; set; } 
        
        [Display(Name = "Quote")]
        public virtual string Quote { get; set; }
        
        [Display(Name = "Image")]
        public virtual string Image  { get; set; }
        
        [Display(Name = "Text image")]
        public virtual string ImageText  { get; set; }
        
        [Display(Name = "Label")]
        public virtual string TitleImagePath  { get; set; }
    }
}