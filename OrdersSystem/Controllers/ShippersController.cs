﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OrdersSystem.Data;
using OrdersSystem.Models;

namespace OrdersSystem.Controllers
{
    public class ShippersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShippersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Shippers
        public async Task<IActionResult> Index()
        {
              return _context.Shipper != null ? 
                          View(await _context.Shipper.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Shipper'  is null.");
        }

        // GET: Shippers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Shipper == null)
            {
                return NotFound();
            }

            var shipper = await _context.Shipper
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shipper == null)
            {
                return NotFound();
            }

            return View(shipper);
        }

        // GET: Shippers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Shippers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ShipperName,Phone")] Shipper shipper)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shipper);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shipper);
        }

        // GET: Shippers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Shipper == null)
            {
                return NotFound();
            }

            var shipper = await _context.Shipper.FindAsync(id);
            if (shipper == null)
            {
                return NotFound();
            }
            return View(shipper);
        }

        // POST: Shippers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ShipperName,Phone")] Shipper shipper)
        {
            if (id != shipper.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shipper);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShipperExists(shipper.Id))
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
            return View(shipper);
        }

        // GET: Shippers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Shipper == null)
            {
                return NotFound();
            }

            var shipper = await _context.Shipper
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shipper == null)
            {
                return NotFound();
            }

            return View(shipper);
        }

        // POST: Shippers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Shipper == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Shipper'  is null.");
            }
            var shipper = await _context.Shipper.FindAsync(id);
            if (shipper != null)
            {
                _context.Shipper.Remove(shipper);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShipperExists(int id)
        {
          return (_context.Shipper?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
