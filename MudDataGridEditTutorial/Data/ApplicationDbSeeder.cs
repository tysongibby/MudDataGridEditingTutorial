using MudDataGridEditTutorial.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MudDataGridEditTutorial.Data
{
    public class ApplicationDbSeeder
    {

        public static void Seed(ApplicationDbContext context)
        {
            SeedLocations(context);
            SeedMeetings(context);
        }

        private static void SeedLocations(ApplicationDbContext context)
        {            
            context.Locations.AddRange(
                    new List<Location>
                    {
                        new Location
                        {
                            Name = "1 Test Location Name",        
                            Description = "1 Test Location Description"
                        },
                        new Location
                        {
                            Name = "2 Test Location Name",
                            Description = "2 Test Location Description"
                        },
                        new Location
                        {
                            Name = "3 Test Location Name",
                            Description = "3 Test Location Description"
                        },
                        new Location
                        {
                            Name = "4 Test Location Name",
                            Description = "4 Test Location Description"
                        },
                        new Location
                        {
                            Name = "5 Test Location Name",
                            Description = "5 Test Location Description"
                        },
                        new Location
                        {
                            Name = "6 Test Location Name",
                            Description = "6 Test Location Description"
                        },
                        new Location
                        {
                            Name = "7 Test Location Name",
                            Description = "7 Test Location Description"
                        },
                    }
                );
            

            context.SaveChanges();
        }

        private static void SeedMeetings(ApplicationDbContext context)
        {
            //int Index = 1;
            string imageFilePathPart = "/images/";
            string meetingPathPart = "/events/";
            string volunteerLinkPathPart = "/volunteerlink/"; // TODO: replace with real link part
            string buyTicketsLink = "https://buytickets.at/webergop";
            // TODO: PartyTimeDbData.SeedMeetings - after Meetings are created, add MoreInfoLink value for Meeting.

            context.Meetings.AddRange(
                new List<Meeting>
                {
                    new Meeting
                    {
                        Name = "1 Test Meeting",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce congue sapien at mi placerat, vel porttitor dolor tempor. Vestibulum orci odio, hendrerit non dignissim non, consectetur id dui. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus arcu nulla, feugiat ut tristique sed, mollis eget elit. In nec rutrum sapien. Morbi finibus felis vitae gravida vestibulum. Sed vitae dolor est. Integer ut ipsum venenatis, blandit enim et, sollicitudin dolor. Donec finibus, purus ac posuere malesuada, mauris metus tristique orci, a mollis libero nisi quis lorem.",
                        Location = context.Locations.FirstOrDefault(l => l.Id == 6),
                        StartTime = DateTime.Parse("2023-05-10 19:00:00"),
                        EndTime = DateTime.Parse("2023-05-10 20:00:00"),
                        PublishTime = DateTime.Parse("2023-05-10 19:00:00"),
                        UnpublishTime = DateTime.Parse("2023-05-10 20:00:00"),
                        RegisterButtonText = "Buy Tickets",
                        RegisterButtonLink = buyTicketsLink,
                        MoreInfoButtonText = "More Info",                        
                        VolunteerButtonText = "Volunteer",
                        VolunteerButtonLink = volunteerLinkPathPart,
                        MeetingFilePath = meetingPathPart
                    },
                    new Meeting
                    {
                        Name = "2 Test Meeting",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce congue sapien at mi placerat, vel porttitor dolor tempor. Vestibulum orci odio, hendrerit non dignissim non, consectetur id dui. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus arcu nulla, feugiat ut tristique sed, mollis eget elit. In nec rutrum sapien. Morbi finibus felis vitae gravida vestibulum. Sed vitae dolor est. Integer ut ipsum venenatis, blandit enim et, sollicitudin dolor. Donec finibus, purus ac posuere malesuada, mauris metus tristique orci, a mollis libero nisi quis lorem.",
                        Location = context.Locations.FirstOrDefault(l => l.Id == 7),
                        StartTime = DateTime.Parse("2023-05-10 19:00:00"),
                        EndTime = DateTime.Parse("2023-05-10 20:00:00"),
                        PublishTime = DateTime.Parse("2023-05-10 19:00:00"),
                        UnpublishTime = DateTime.Parse("2023-10-10 20:00:00"),
                        RegisterButtonText = "Buy Tickets",
                        RegisterButtonLink = buyTicketsLink,
                        MoreInfoButtonText = "More Info",                        
                        VolunteerButtonText = "Volunteer",
                        VolunteerButtonLink = volunteerLinkPathPart,
                        MeetingFilePath = meetingPathPart
                    },
                    new Meeting
                    {
                        Name = "3 Test Meeting",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce congue sapien at mi placerat, vel porttitor dolor tempor. Vestibulum orci odio, hendrerit non dignissim non, consectetur id dui. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus arcu nulla, feugiat ut tristique sed, mollis eget elit. In nec rutrum sapien. Morbi finibus felis vitae gravida vestibulum. Sed vitae dolor est. Integer ut ipsum venenatis, blandit enim et, sollicitudin dolor. Donec finibus, purus ac posuere malesuada, mauris metus tristique orci, a mollis libero nisi quis lorem.",
                        Location = context.Locations.FirstOrDefault(l => l.Id == 1),
                        StartTime = DateTime.Parse("2023-05-10 19:00:00"),
                        EndTime = DateTime.Parse("2023-05-10 20:00:00"),
                        PublishTime = DateTime.Parse("2023-06-02 19:00:00"),
                        UnpublishTime = DateTime.Parse("2024-05-02 21:00:00"),
                        RegisterButtonText = "Buy Tickets",
                        RegisterButtonLink = buyTicketsLink,
                        MoreInfoButtonText = "More Info",                              
                        VolunteerButtonText = "Volunteer",
                        VolunteerButtonLink = volunteerLinkPathPart,
                        MeetingFilePath = meetingPathPart
                    },
                    new Meeting
                    {
                        Name = "4 Test Meeting",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce congue sapien at mi placerat, vel porttitor dolor tempor. Vestibulum orci odio, hendrerit non dignissim non, consectetur id dui. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus arcu nulla, feugiat ut tristique sed, mollis eget elit. In nec rutrum sapien. Morbi finibus felis vitae gravida vestibulum. Sed vitae dolor est. Integer ut ipsum venenatis, blandit enim et, sollicitudin dolor. Donec finibus, purus ac posuere malesuada, mauris metus tristique orci, a mollis libero nisi quis lorem.",
                        Location = context.Locations.FirstOrDefault(l => l.Id == 2),
                        StartTime = DateTime.Parse("2023-04-10 19:00:00"),
                        EndTime = DateTime.Parse("2023-05-10 20:00:00"),
                        PublishTime = DateTime.Parse("2023-06-14 19:00:00"),
                        UnpublishTime = DateTime.Parse("2024-06-14 21:00:00"),
                        RegisterButtonText = "Buy Tickets",
                        RegisterButtonLink = buyTicketsLink,
                        MoreInfoButtonText = "More Info",                        
                        VolunteerButtonText = "Volunteer",
                        VolunteerButtonLink = volunteerLinkPathPart,
                        MeetingFilePath = meetingPathPart
                    },
                    new Meeting
                    {
                        Name = "5 Test Meeting",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce congue sapien at mi placerat, vel porttitor dolor tempor. Vestibulum orci odio, hendrerit non dignissim non, consectetur id dui. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus arcu nulla, feugiat ut tristique sed, mollis eget elit. In nec rutrum sapien. Morbi finibus felis vitae gravida vestibulum. Sed vitae dolor est. Integer ut ipsum venenatis, blandit enim et, sollicitudin dolor. Donec finibus, purus ac posuere malesuada, mauris metus tristique orci, a mollis libero nisi quis lorem.",
                        Location = context.Locations.FirstOrDefault(l => l.Id == 3),
                        StartTime = DateTime.Parse("2023-05-10 19:00:00"),
                        EndTime = DateTime.Parse("2023-05-10 20:00:00"),
                        PublishTime = DateTime.Parse("2023-06-14 19:00:00"),
                        UnpublishTime = DateTime.Parse("2024-07-14 20:00:00"),
                        RegisterButtonText = "Buy Tickets",
                        RegisterButtonLink = buyTicketsLink,
                        MoreInfoButtonText = "More Info",                        
                        VolunteerButtonText = "Volunteer",
                        VolunteerButtonLink = volunteerLinkPathPart,
                        MeetingFilePath = meetingPathPart
                    },
                    new Meeting
                    {
                        Name = "6 Test Meeting",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce congue sapien at mi placerat, vel porttitor dolor tempor. Vestibulum orci odio, hendrerit non dignissim non, consectetur id dui. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus arcu nulla, feugiat ut tristique sed, mollis eget elit. In nec rutrum sapien. Morbi finibus felis vitae gravida vestibulum. Sed vitae dolor est. Integer ut ipsum venenatis, blandit enim et, sollicitudin dolor. Donec finibus, purus ac posuere malesuada, mauris metus tristique orci, a mollis libero nisi quis lorem.",
                        Location = context.Locations.FirstOrDefault(l => l.Id == 4),
                        StartTime = DateTime.Parse("2023-06-10 19:00:00"),
                        EndTime = DateTime.Parse("2023-05-10 20:00:00"),
                        PublishTime = DateTime.Parse("2023-06-14 19:00:00"),
                        UnpublishTime = DateTime.Parse("2024-08-14 20:00:00"),
                        RegisterButtonText = "Buy Tickets",
                        RegisterButtonLink = buyTicketsLink,
                        MoreInfoButtonText = "More Info",                        
                        VolunteerButtonText = "Volunteer",
                        VolunteerButtonLink = volunteerLinkPathPart,
                        MeetingFilePath = meetingPathPart
                    },
                    new Meeting
                    {
                        Name = "7 Test Meeting",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce congue sapien at mi placerat, vel porttitor dolor tempor. Vestibulum orci odio, hendrerit non dignissim non, consectetur id dui. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus arcu nulla, feugiat ut tristique sed, mollis eget elit. In nec rutrum sapien. Morbi finibus felis vitae gravida vestibulum. Sed vitae dolor est. Integer ut ipsum venenatis, blandit enim et, sollicitudin dolor. Donec finibus, purus ac posuere malesuada, mauris metus tristique orci, a mollis libero nisi quis lorem.",
                        Location = context.Locations.FirstOrDefault(l => l.Id == 5),
                        StartTime = DateTime.Parse("2023-07-10 19:00:00"),
                        EndTime = DateTime.Parse("2023-05-10 20:00:00"),
                        PublishTime = DateTime.Parse("2023-06-14 19:00:00"),
                        UnpublishTime = DateTime.Parse("2024-09-14 20:00:00"),
                        RegisterButtonText = "Buy Tickets",
                        RegisterButtonLink = buyTicketsLink,
                        MoreInfoButtonText = "More Info",                        
                        VolunteerButtonText = "Volunteer",
                        VolunteerButtonLink = volunteerLinkPathPart,
                        MeetingFilePath = meetingPathPart
                    }
                });

            context.SaveChanges();
        }
    }
}
