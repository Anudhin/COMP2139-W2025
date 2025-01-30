using System.ComponentModel.DataAnnotations;

namespace COMP2139_ICE.Models;

public class Project
{
    /// <summary>
    /// This is the primary key for the project
    /// [Required]: Ensures that the property must be set
    /// </summary>
    public int ProjectId { get; set; }
    
    ///  <summary>
    /// The Name of the project
    /// [Required]: Ensures that the property must be set
    /// </summary>

    [Required]
    
    public required string Name { get; set; }
    
    public string Description { get; set; }
    
    [DataType(DataType.Date)]
    public DateTime StartDate { get; set; }
    
    [DataType(DataType.Date)]
    public DateTime EndDate { get; set; }
    
    public String Status { get; set; }
}