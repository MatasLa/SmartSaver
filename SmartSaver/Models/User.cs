using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;


namespace DataBases
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }

    }

}