﻿namespace StudentAdminPortalAPI.DataModels
{
    public class Address
    {
        public Guid Id { get; set; }
        public string? PhysicalAddress { get; set; }
        public string? PostalAddress { get; set; }

        //navigation props

        public Guid StudentId { get; set; }

    }
}
