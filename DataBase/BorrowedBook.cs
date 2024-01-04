using System.ComponentModel.DataAnnotations;

namespace DataBase;

public class BorrowedBook
{
    [Key]
    public int Id { get; set; }
    
    public Reader Reader { get; set; }
    
    public BookInfo Book { get; set; }
    
    public DateTime Deadline { get; set; }
}