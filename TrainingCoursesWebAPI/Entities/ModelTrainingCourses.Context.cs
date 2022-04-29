﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrainingCoursesWebAPI.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TrainingCoursesEntities : DbContext
    {
        public TrainingCoursesEntities()
            : base("name=TrainingCoursesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<CourseEducatorTopic> CourseEducatorTopic { get; set; }
        public virtual DbSet<CourseForm> CourseForm { get; set; }
        public virtual DbSet<CoursePeople> CoursePeople { get; set; }
        public virtual DbSet<Educator> Educator { get; set; }
        public virtual DbSet<Organization> Organization { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<Qualification> Qualification { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Topic> Topic { get; set; }
    
        public virtual int RegistrationNumCreate()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RegistrationNumCreate");
        }
    
        public virtual ObjectResult<SelectCourse_Result> SelectCourse()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectCourse_Result>("SelectCourse");
        }
    
        public virtual ObjectResult<SelectCourseCourseID_Result> SelectCourseCourseID(Nullable<int> idCourse)
        {
            var idCourseParameter = idCourse.HasValue ?
                new ObjectParameter("idCourse", idCourse) :
                new ObjectParameter("idCourse", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectCourseCourseID_Result>("SelectCourseCourseID", idCourseParameter);
        }
    
        public virtual ObjectResult<SelectCourseEducatorTopic_Result> SelectCourseEducatorTopic(Nullable<int> idCourse)
        {
            var idCourseParameter = idCourse.HasValue ?
                new ObjectParameter("idCourse", idCourse) :
                new ObjectParameter("idCourse", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectCourseEducatorTopic_Result>("SelectCourseEducatorTopic", idCourseParameter);
        }
    
        public virtual ObjectResult<string> SelectRegistrationNumber(Nullable<int> courseID, Nullable<int> peopleID)
        {
            var courseIDParameter = courseID.HasValue ?
                new ObjectParameter("courseID", courseID) :
                new ObjectParameter("courseID", typeof(int));
    
            var peopleIDParameter = peopleID.HasValue ?
                new ObjectParameter("peopleID", peopleID) :
                new ObjectParameter("peopleID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SelectRegistrationNumber", courseIDParameter, peopleIDParameter);
        }
    
        public virtual ObjectResult<SelectCourseEducatorTopicIDCourse_Result> SelectCourseEducatorTopicIDCourse(Nullable<int> idCourse)
        {
            var idCourseParameter = idCourse.HasValue ?
                new ObjectParameter("idCourse", idCourse) :
                new ObjectParameter("idCourse", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectCourseEducatorTopicIDCourse_Result>("SelectCourseEducatorTopicIDCourse", idCourseParameter);
        }
    }
}
