﻿namespace SlackCleanup.SlackApiImplementation.Model
{
    public class ProfileData : FlexibleJsonModel
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RealName { get; set; }
        public string RealNameNormalized { get; set; }

        public string Email { get; set; }
        public string Skype { get; set; }
        public string Phone { get; set; }

        public string Image24 { get; set; }
        public string Image32 { get; set; }
        public string Image48 { get; set; }
        public string Image72 { get; set; }
        public string Image192 { get; set; }
        public string ImageOriginal { get; set; }
    }
}