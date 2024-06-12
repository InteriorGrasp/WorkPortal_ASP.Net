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
    public class AdminLoginController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminLoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdminLogin
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.AdminLogins.Include(a => a.Department);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: AdminLogin/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminLogin = await _context.AdminLogins
                .Include(a => a.Department)
                .FirstOrDefaultAsync(m => m.AdminLoginId == id);
            if (adminLogin == null)
            {
                return NotFound();
            }

            return View(adminLogin);
        }

        // GET: AdminLogin/Create
        public IActionResult Create()
        {
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "DepartmentId", "Address");
            return View();
        }

        // POST: AdminLogin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AdminLoginId,Password,DepartmentId")] AdminLogin adminLogin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(adminLogin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "DepartmentId", "Address", adminLogin.DepartmentId);
            return View(adminLogin);
        }

        // GET: AdminLogin/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminLogin = await _context.AdminLogins.FindAsync(id);
            if (adminLogin == null)
            {
                return NotFound();
            }
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "DepartmentId", "Address", adminLogin.DepartmentId);
            return View(adminLogin);
        }

        // POST: AdminLogin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("AdminLoginId,Password,DepartmentId")] AdminLogin adminLogin)
        {
            if (id != adminLogin.AdminLoginId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adminLogin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminLoginExists(adminLogin.AdminLoginId))
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
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "DepartmentId", "Address", adminLogin.DepartmentId);
            return View(adminLogin);
        }

        // GET: AdminLogin/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminLogin = await _context.AdminLogins
                .Include(a => a.Department)
                .FirstOrDefaultAsync(m => m.AdminLoginId == id);
            if (adminLogin == null)
            {
                return NotFound();
            }

            return View(adminLogin);
        }

        // POST: AdminLogin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var adminLogin = await _context.AdminLogins.FindAsync(id);
            if (adminLogin != null)
            {
                _context.AdminLogins.Remove(adminLogin);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminLoginExists(string id)
        {
            return _context.AdminLogins.Any(e => e.AdminLoginId == id);
        }
    }
}
