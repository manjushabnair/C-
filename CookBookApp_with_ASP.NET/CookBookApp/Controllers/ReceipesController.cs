using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CookBookApp.Data;
using CookBookApp.Models;

namespace CookBookApp.Controllers
{
    public class ReceipesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReceipesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Receipes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Receipes.ToListAsync());
        }

        // GET: Receipes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receipes = await _context.Receipes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (receipes == null)
            {
                return NotFound();
            }

            return View(receipes);
        }

        // GET: Receipes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Receipes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ReceipeTitle,ReceipeText")] Receipes receipes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(receipes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(receipes);
        }

        // GET: Receipes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receipes = await _context.Receipes.FindAsync(id);
            if (receipes == null)
            {
                return NotFound();
            }
            return View(receipes);
        }

        // POST: Receipes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ReceipeTitle,ReceipeText")] Receipes receipes)
        {
            if (id != receipes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(receipes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReceipesExists(receipes.Id))
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
            return View(receipes);
        }

        // GET: Receipes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receipes = await _context.Receipes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (receipes == null)
            {
                return NotFound();
            }

            return View(receipes);
        }

        // POST: Receipes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var receipes = await _context.Receipes.FindAsync(id);
            _context.Receipes.Remove(receipes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReceipesExists(int id)
        {
            return _context.Receipes.Any(e => e.Id == id);
        }
    }
}
