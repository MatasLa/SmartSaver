﻿using System.ComponentModel.DataAnnotations;

namespace ePiggy.DataBase.Models
{
    public class Goals
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Price { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        public int PlaceInQueue { get; set; }

    }

}
