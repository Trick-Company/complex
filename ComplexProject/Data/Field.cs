﻿using System.ComponentModel.DataAnnotations;

namespace ComplexProject.Data
{
    public class Field
    {
        public int Id { set; get; }
        [Required]
        public string Name { set; get; }
        public string Description { set; get; }

        

        public List<Company> Li_company { set; get; }

    }
}
