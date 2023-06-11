﻿namespace KentWebForms.Infrastructure.HttpServices
{
    using KentWebForms.Infrastructure.Helper;
    using KentWebForms.Infrastructure.Models;
    using KentWebForms.Infrastructure.Models.Courses;
    using KentWebForms.Infrastructure.Requests.Courses;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class CourseHttpService
    {
        public async Task<Response<List<UserCourse>>> GetUserCourses(GetUserCoursesRequest request)
        {
            string apiRoute = "course/user_courses";
            var response = await HttpHelper.Get<GetUserCoursesRequest, List<UserCourse>>(apiRoute, request);
            return response;
        }
    }
}
