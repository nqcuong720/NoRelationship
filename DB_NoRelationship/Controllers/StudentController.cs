// <copyright file="StudentController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DB_NoRelationship.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using DB_NoRelationship.Data;
    using DB_NoRelationship.Entities;
    using DB_NoRelationship.ViewModels;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Internal;

    public class StudentController : Controller
    {
        private readonly EntityContext _context;

        public StudentController(EntityContext context)
        {
            _context = context;
        }

        // GET: Student
        public IActionResult Index()
        {
            // var result2 = _context.ClassEntities.ToList();
            // var result1 = _context.StudentEntities.ToList();
            // var result = _context.StudentEntities.Join(
            //    _context.ClassEntities,
            //    student => student.ClassId,
            //    c => c.Id,
            //    (student, c) => new
            //    {
            //        FistName = student.FirstName,
            //        LastName = student.LastName,
            //        Age = student.StudentAge,
            //        Note = student.Note,
            //        ClassId = student.ClassId,
            //        ClassName = c.ClassName

            // });
            var result = from s in _context.StudentEntities
                          join c in _context.ClassEntities
                          on s.ClassId equals c.Id
                          select new StudentModel
                          {
                              Id = s.Id,
                              FirstName = s.FirstName,
                              LastName = s.LastName,
                              StudentAge = s.StudentAge,
                              Note = s.Note,
                              Class = c.ClassName
                          };

            var result0 = from s in _context.Set<StudentEntities>()
                          from c in _context.Set<ClassEntities>()
                          from d in _context.Set<DepartmentEntities>()
                          where d.Id == c.Department && c.Id == s.ClassId
                          select new StudentModel
                          {
                              Id = s.Id,
                              FirstName = s.FirstName,
                              LastName = s.LastName,
                              StudentAge = s.StudentAge,
                              Note = s.Note,
                              Class = c.ClassName,
                              Department = d.DepartmentName,
                              Image = s.Image
                          };
            var result2 = from s in _context.StudentEntities
                          join c in _context.ClassEntities
                          on s.ClassId equals c.Id
                          join d in _context.DepartmentEntities
                          on c.Department equals d.Id
                          select new StudentModel
                          {
                              Id = s.Id,
                              FirstName = s.FirstName,
                              LastName = s.LastName,
                              StudentAge = s.StudentAge,
                              Note = s.Note,
                              Class = c.ClassName,
                              Department = d.DepartmentName
                          };

            // var result = result0.Select(s => new StudentModel
            // {
            //    Id = s.Id,
            //    FirstName = s.FistName,
            //    LastName = s.LastName,
            //    StudentAge = s.Age,
            //    Note = s.Note,
            //    Class = s.ClassName
            // });
            return View(result0);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(StudentEntities student, IFormFile Image)
        {
            if (ModelState.IsValid)
            {
                var urlImage = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Image", Image.FileName);
                using (var file = new FileStream(urlImage, FileMode.Create))
                {
                    await Image.CopyToAsync(file);
                }

                student.Image = Image.FileName;
            }

            _context.Add(student);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
