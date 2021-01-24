using Mis.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mis.Entities.Concrete.Base
{
    public abstract class EntityBase : IEntity
    {
        /// <summary>
        /// Auto Increment Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        /// <summary>
        /// Now / GetDate()
        /// </summary>
        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Who created?
        /// </summary>
        [Required(ErrorMessage = "Required")]
        public virtual int CreatedBy { get; set; } = 0;

        /// <summary>
        /// Status of data (Enabled or Disabled)
        /// </summary>
        [Required(ErrorMessage = "Required")]
        public virtual bool IsActive { get; set; } = true;
    }
}
