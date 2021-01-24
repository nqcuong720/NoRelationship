// <copyright file="ClassController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DB_NoRelationship.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using DB_NoRelationship.Data;
    using DB_NoRelationship.Entities;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;

    public class ClassController : Controller
    {
        private readonly EntityContext _context;

        public ClassController(EntityContext context)
        {
            _context = context;
        }

        // GET: Class
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClassEntities.ToListAsync());
        }

        // GET: Class/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classEntities = await _context.ClassEntities
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classEntities == null)
            {
                return NotFound();
            }

            return View(classEntities);
        }

        // GET: Class/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Class/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for.
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClassName,Id")] ClassEntities classEntities)
        {
            if (ModelState.IsValid)
            {
                _context.Add(classEntities);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(classEntities);
        }

        // GET: Class/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classEntities = await _context.ClassEntities.FindAsync(id);
            if (classEntities == null)
            {
                return NotFound();
            }

            return View(classEntities);
        }

        // POST: Class/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for.
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ClassName,Id")] ClassEntities classEntities)
        {
            if (id != classEntities.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(classEntities);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassEntitiesExists(classEntities.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            return View(classEntities);
        }

        // GET: Class/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classEntities = await _context.ClassEntities
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classEntities == null)
            {
                return NotFound();
            }

            return View(classEntities);
        }

        // POST: Class/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var classEntities = await _context.ClassEntities.FindAsync(id);
            _context.ClassEntities.Remove(classEntities);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClassEntitiesExists(long id)
        {
            return _context.ClassEntities.Any(e => e.Id == id);
        }
    }
}
