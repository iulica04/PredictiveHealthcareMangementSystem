﻿namespace Application.DTOs
{
    public class MedicDto : UserDto
    {
        public required string Rank { get; set; }
        public required string Specialization { get; set; }
        public required string Hospital { get; set; }

    }
}
