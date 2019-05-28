using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using TakeBackTheMusic.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;

namespace TakeBackTheMusic.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }
        public TakeBackTheMusicUser EventCreator { get; set; }
        public DateTime EventCreateDate { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public DateTime EventStart { get; set; }
        public DateTime EventEnd { get; set; }
        public decimal TicketPrice { get; set; }
        public string TicketLink { get; set; }
        public bool IsPrivate { get; set; }

        public List<EventArtist> EventArtists { get; set; }
    }

    public class EventArtist
    {
        [Key]
        public int EventArtistId { get; set; }
        public Artist ArtistID { get; set; }
        public DateTime ArtistStart { get; set; }

        public int EventID { get; set; }
        public Event Event { get; set; }
    }

    public class EventVenue
    {
        // Update class when Venue class is fully created - EventVenueId for table key, VenueId to reference venue class
        [Key]
        public int VenueID { get; set; }
        public bool IsNewVenue { get; set; }
        public string NewVenueName { get; set; }
        public string NewVenueCountry { get; set; }
        public string NewVenueState { get; set; }
        public string NewVenueCity { get; set; }
        public string NewVenuePostal { get; set; }
        public string NewVenueAddress1 { get; set; }
        public string NewVenueAddress2 { get; set; }

        public int EventID { get; set; }
        public Event Event { get; set; }
    }
}
