using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Eltemtek.ToDoList.Db.DataAccess
{
    [Table("tbl_note")]
    public partial class TblNote
    {
        [Key]
        public int Noteid { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [StringLength(100)]
        public string Note { get; set; }
        public int Userid { get; set; }

        [ForeignKey(nameof(Userid))]
        public virtual TblUser User { get; set; }
    }
}
