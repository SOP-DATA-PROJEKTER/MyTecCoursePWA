﻿using MyTecCoursePWA.Interfaces;

namespace MyTecCoursePWA.Models
{
    public class Education : ISelectable
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public List<Pathway>? Pathways { get; set; }
    }
}
