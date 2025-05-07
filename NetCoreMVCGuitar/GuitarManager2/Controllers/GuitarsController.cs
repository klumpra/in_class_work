using Microsoft.AspNetCore.Mvc;
using GuitarManager.Database;
using GuitarManager.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace GuitarManager.Controllers
{
    public class GuitarsController : Controller
    {
        private readonly GuitarDbContext _context;

        public GuitarsController(GuitarDbContext context)
        {
            _context = context;
        }

        // GET: Guitars
        public async Task<IActionResult> Index()
        {
            var guitarList = await _context.Guitars.ToListAsync();
            return View(guitarList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Guitars/Create
        [HttpPost]
        public async Task<IActionResult> Create(Guitar guitar)
        {
            if (ModelState.IsValid)
            {
                _context.Guitars.Add(guitar);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(guitar);
        }

        // GET: Guitars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guitar = await _context.Guitars.FindAsync(id);
            if (guitar == null)
            {
                return NotFound();
            }
            return View(guitar);
        }

        // POST: Guitars/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(Guitar guitar)
        {
            if (ModelState.IsValid)
            {

                _context.Guitars.Update(guitar);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guitar = await _context.Guitars.FirstOrDefaultAsync(g => g.Id == id);
            if (guitar == null)
            {
                return NotFound();
            }

            return View(guitar);
        }

        // POST: Guitars/Delete/5
        [HttpPost]
        public async Task<IActionResult> Delete(int guitarId)
        {
            var guitar = await _context.Guitars.FindAsync(guitarId);
            _context.Guitars.Remove(guitar);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}

