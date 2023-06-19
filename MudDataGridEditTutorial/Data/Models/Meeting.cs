using System;
using System.ComponentModel.DataAnnotations;

namespace MudDataGridEditTutorial.Data.Models
{
    public class Meeting
    {    
        DateTime _startTime;        
        DateTime _endTime;        
        DateTime _publishTime;        
        DateTime _unpublishTime;
        
        [Key]
        public int Id { get; set; }
                      
        public string Name { get; set; }        
        
        public string Description { get; set; }

        public string ThumbnailSource { get; set; }

        public string RegisterButtonText { get; set; } = "Buy Tickets";
        
        public string RegisterButtonLink { get; set; }
        
        public string MoreInfoButtonText { get; set; } = "More Info";
        
        public string MoreInfoButtonLink { get; set; }
        
        public string VolunteerButtonText { get; set; }
        
        public string VolunteerButtonLink { get; set; }               
        
        public string MeetingFilePath { get; set; }
        
        public DateTime StartTime 
        { 
            get { return _startTime; } 
            set { _startTime = value; } 
        }
        public DateTime? StartTimeNullable
        {
            get { return (DateTime?)_startTime; } 
            set { _startTime = (DateTime)value; }
        }        
        
        public DateTime EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }
        public DateTime? EndTimeNullable
        {
            get {  return (DateTime?)_endTime;} 
            set { _endTime = (DateTime)value; }

        }
        
        public DateTime PublishTime
        {
            get { return _publishTime; }
            set { _publishTime = value; }
        }
        public DateTime? PublishTimeNullable
        {
            get { return (DateTime?)_publishTime; } 
            set { _publishTime = (DateTime)value; }            
        }
        
        public DateTime UnpublishTime
        {
            get { return _unpublishTime; }
            set { _unpublishTime = value; }
        }
        public DateTime? UnpublishTimeNullable
        {
            get { return (DateTime?)_unpublishTime; } 
            set { _unpublishTime = (DateTime)value; }
        }

        // FK Many-to-one, Location is child
        [Required]public int LocationId { get; set; }
        // FK Many-to-one navigation, Location is child
        [Required]public virtual Location Location { get; set; }
    }
}
