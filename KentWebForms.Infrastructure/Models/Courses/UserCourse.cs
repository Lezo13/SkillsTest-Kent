﻿namespace KentWebForms.Infrastructure.Models.Courses
{
    using System;

    public class UserCourse
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public string DisplayImgBase64 { get; set; }

        public string CoverImgBase64 { get; set; }

        public string State { get; set; }

        public DateTime CourseDateCreated { get; set; }

        public DateTime CourseDateUpdated { get; set; }

        public string UserId { get; set; }

        public string Status { get; set; }

        public DateTime DateEnrolled { get; set; }

        public DateTime DateCompleted { get; set; }
    }
}
