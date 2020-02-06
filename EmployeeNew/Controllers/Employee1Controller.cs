using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeNew.Data;
using EmployeeNew.Models;

namespace EmployeeNew.Controllers
{
    public class Employee1Controller : Controller
    {
        private readonly EmployeeContext _context;

        public Employee1Controller(EmployeeContext context)
        {
            _context = context;
        }

        // GET: Employee1 
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employee1.ToListAsync());
        }
        ////public IActionResult Index()
        ////{
        ////    return View(_context.Employee1.ToList());
        ////}

        // GET: Employee1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee1 = await _context.Employee1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee1 == null)
            {
                return NotFound();
            }

            return View(employee1);
        }

        // GET: Employee1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employee1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,Dept")] Employee1 employee1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee1);
        }

        // GET: Employee1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee1 = await _context.Employee1.FindAsync(id);
            if (employee1 == null)
            {
                return NotFound();
            }
            return View(employee1);
        }

        // POST: Employee1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Dept")] Employee1 employee1)
        {
            if (id != employee1.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Employee1Exists(employee1.Id))
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
            return View(employee1);
        }

        // GET: Employee1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee1 = await _context.Employee1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee1 == null)
            {
                return NotFound();
            }

            return View(employee1);
        }

        // POST: Employee1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee1 = await _context.Employee1.FindAsync(id);
            _context.Employee1.Remove(employee1);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Employee1Exists(int id)
        {
            return _context.Employee1.Any(e => e.Id == id);
        }
    }
}
