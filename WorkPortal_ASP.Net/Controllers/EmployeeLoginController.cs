using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WorkPortal_ASP.Net.Data;
using WorkPortal_ASP.Net.Models;

namespace WorkPortal_ASP.Net.Controllers
{
    public class EmployeeLoginController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeLoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EmployeeLogin
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.EmployeeLogins.Include(e => e.Employee);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: EmployeeLogin/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeLogin = await _context.EmployeeLogins
                .Include(e => e.Employee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employeeLogin == null)
            {
                return NotFound();
            }

            return View(employeeLogin);
        }

        // GET: EmployeeLogin/Create
        public IActionResult Create()
        {
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeId", "Name");
            return View();
        }

        // POST: EmployeeLogin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Password,EmployeeId")] EmployeeLogin employeeLogin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeLogin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeId", "Name", employeeLogin.EmployeeId);
            return View(employeeLogin);
        }

        // GET: EmployeeLogin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeLogin = await _context.EmployeeLogins.FindAsync(id);
            if (employeeLogin == null)
            {
                return NotFound();
            }
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeId", "Name", employeeLogin.EmployeeId);
            return View(employeeLogin);
        }

        // POST: EmployeeLogin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Password,EmployeeId")] EmployeeLogin employeeLogin)
        {
            if (id != employeeLogin.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeLogin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeLoginExists(employeeLogin.Id))
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
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeId", "Name", employeeLogin.EmployeeId);
            return View(employeeLogin);
        }

        // GET: EmployeeLogin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeLogin = await _context.EmployeeLogins
                .Include(e => e.Employee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employeeLogin == null)
            {
                return NotFound();
            }

            return View(employeeLogin);
        }

        // POST: EmployeeLogin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeLogin = await _context.EmployeeLogins.FindAsync(id);
            if (employeeLogin != null)
            {
                _context.EmployeeLogins.Remove(employeeLogin);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeLoginExists(int id)
        {
            return _context.EmployeeLogins.Any(e => e.Id == id);
        }
    }
}