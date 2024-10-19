using System.ComponentModel.DataAnnotations;

namespace BookTrackerWeb.Models;

public class Book
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Author {get;set;}
    [DataType(DataType.Date)]
    public DateTime? StartDate {get;set;}
    [DataType(DataType.Date)]
    public DateTime? EndDate{get;set;}
    public bool? IsCompleted{get;set;}
    public bool? Active{get;set;}
}