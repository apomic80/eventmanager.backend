﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Business.Domain
{
    public class AgendaItem
    {
        public int Id { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }

        [Required]
        [StringLength(5)]
        public string StartTime { get; set; }

        [Required]
        [StringLength(5)]
        public string EndTime { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public int? SpeakerId { get; set; }
        public Speaker Speaker { get; set; }

        public int Order { get; set; }
    }
}
