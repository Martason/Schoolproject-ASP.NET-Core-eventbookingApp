﻿using Microsoft.AspNetCore.SignalR;

namespace EventiaWebapp.Models
{
    public class Organizer
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
